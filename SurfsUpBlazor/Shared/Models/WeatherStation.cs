using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfsUpBlazor.Shared.Models
{
    public class WeatherStation
    {
        public string StationID { get; set; }
        public string StationName { get; set;}
        public string StationCountry { get; set; }
        public string StationOwner { get; set;}
        public string OperationFrom { get; set; }
        private string operationTo;
        public string OperationTo
        {
            get { return operationTo; }
            set
            {
                if (value == "null")
                {
                    operationTo = "n/a";
                }
                else
                {
                    operationTo = value;
                };
            }
        }

        public string IsActive { get; set; }

        private string latitude;

        public string Latitude
        {
            get { return latitude; }
            set
            {
                if (value == "null")
                {
                    latitude = "n/a";
                }
                else
                {
                    latitude = value;
                };
            }
        }
        private string longitude;

        public string Longitude
        {
            get { return longitude; }
            set
            {
                if (value == "null")
                {
                    longitude = "n/a";
                }
                else
                {
                    longitude = value;
                };
            }
        }

    }
}
