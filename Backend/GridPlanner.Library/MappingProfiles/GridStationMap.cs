using System.Security.AccessControl;
using AutoMapper;
using GridPlanner.Library.Models.Entities;
using GridPlanner.Library.Models.Export;
using GridPlanner.Library.Models.Import;

namespace GridPlanner.Library.MappingProfiles;

public class GridStationMap:Profile
{
    public GridStationMap()
    {
        CreateMap<GridStation, GridStationExportDto>()
            .ForMember(dest => dest.Kilovoltage, opt => opt.MapFrom(src => $"{src.Kilovoltage} KV"))

             ;
        CreateMap<Coordinate, CoordinateExportDto>();
            
        CreateMap<Contact, ContactExportDto>();
        CreateMap<GridStationImportDto, GridStation>();
        CreateMap<CoordinateImportDto, Coordinate>()
            .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => GetLocalIndependentDouble(src.Longitude)))
            .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => GetLocalIndependentDouble(src.Latitude)));
        CreateMap<ContactImportDto, Contact>();

    }
    
    private double GetLocalIndependentDouble(string value)
    {
        try
        {
            var decimalSeparator = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            if (decimalSeparator == ".")
            {
                value = value.Replace(",", ".");
            }
            else
            {
                value = value.Replace(".", ",");
            }


            if (double.TryParse(value, out double retVal))
            {
                return retVal;
            }

            return 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return 0;
        }
      
    }
    
}