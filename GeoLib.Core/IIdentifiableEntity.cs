using System;
using System.Collections.Generic;
using System.Linq;

namespace GeoLib.Core
{
    public interface IIdentifiableEntity
    {
        int EntityId { get; set; }
    }
}
