using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfUpModelLayer.Shared
{
    public class Location
    {
        long Longitude { get; set; }
        long Latitude { get; set; }
        List<Tag> Tags { get; set; }
    }
}
