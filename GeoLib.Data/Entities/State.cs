using GeoLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeoLib.Data
{
    public class State : IIdentifiableEntity
    {
        public int StateId { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public bool IsPrimaryState { get; set; }

        public int EntityId
        {
            get { return StateId; }
            set { StateId = value; }
        }
    }
}
