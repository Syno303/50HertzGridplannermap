import React, { useEffect, useRef } from "react";
import "ol/ol.css";
import Map from "ol/Map";
import View from "ol/View";
import TileLayer from "ol/layer/Tile";
import OSM from "ol/source/OSM";
import VectorLayer from "ol/layer/Vector";
import VectorSource from "ol/source/Vector";
import Feature from "ol/Feature";
import Point from "ol/geom/Point";
import { fromLonLat } from "ol/proj";
import { Circle as CircleStyle, Fill, Stroke, Style } from "ol/style";
import Overlay from "ol/Overlay";
import { useDispatch, useSelector } from "react-redux";
import { getGridStationById } from "../../redux/reducers/gridstationSlice";
import { history } from "../../App";
import "./GridstationMap.css";

const GridstationMap = () => {
  const gridstations = useSelector(state => state.gridstation.gridstations);

  const currentCoordinate = useSelector(
    state => state.gridstation.currentCoordinate
  );
  const dispatch = useDispatch();
  const mapRef = useRef(null);

  useEffect(() => {
    const view = new View({
      center: fromLonLat([
        currentCoordinate.longitude,
        currentCoordinate.latitude
      ]),
      zoom: 14
    });
    const vectorSource = new VectorSource();
    const vectorLayer = new VectorLayer({
      source: vectorSource,
      style: feature => {
        const color = feature.get("color");
        return new Style({
          image: new CircleStyle({
            fill: new Fill({
              color: color
            }),
            stroke: new Stroke({
              color: color,
              width: 1
            }),
            radius: 7
          })
        });
      }
    });
    const overlay = new Overlay({
      element: document.getElementById("popup"),
      positioning: "bottom-center",
      offset: [0, -10]
    });

    const map = new Map({
      target: mapRef.current,
      layers: [
        new TileLayer({
          source: new OSM()
        }),
        vectorLayer
      ],
      view: view,
      overlays: [overlay]
    });
    map.on("pointermove", function (event) {
      map.getTargetElement().style.cursor = map.hasFeatureAtPixel(event.pixel)
        ? "pointer"
        : "";
    });
    map.on("click", function (event) {
      const feature = map.getFeaturesAtPixel(event.pixel)[0];
      if (feature) {
        const coordinates = feature.getGeometry().getCoordinates();
        const id = feature.get("id");
        overlay.setPosition(coordinates);
        dispatch(getGridStationById(id));
        history.push(`/gridstation/${id}`);
      }
    });

    gridstations.forEach(gridstation => {
      const color = gridstation.status ? "green" : "red";
      const feature = new Feature({
        geometry: new Point(
          fromLonLat([
            gridstation.coordinate.longitude,
            gridstation.coordinate.latitude
          ])
        ),
        id: gridstation.id,
        color: color
      });
      vectorSource.addFeature(feature);
    });
    const extent = vectorLayer.getSource().getExtent();
    if (extent && gridstations.length > 1) {
      map.getView().fit(extent, { padding: [50, 50, 50, 50] });
    }

    return () => map.setTarget(null);
  });

  return (
    <div className="gridstation_map_container">
      <div id="popup" className="ol-popup">
        <div id="popup-content"></div>
      </div>
      <div ref={mapRef} style={{ width: "100%", height: "600px" }}></div>
    </div>
  );
};

export default GridstationMap;
