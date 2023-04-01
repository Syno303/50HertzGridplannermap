import React, { useEffect } from "react";
import { useDispatch } from "react-redux";
import { useParams } from "react-router-dom";
import { getGridStationById } from "../../redux/reducers/gridstationSlice";
import Gridstation from "./Gridstation";

export default function GridstationDetail() {
  const dispatch = useDispatch();
  const params = useParams();

  useEffect(() => {
    dispatch(getGridStationById(params.id));
  }, [params.id, dispatch]);
  return <Gridstation />;
}
