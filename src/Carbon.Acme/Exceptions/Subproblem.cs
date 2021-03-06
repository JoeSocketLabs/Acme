﻿using System.Runtime.Serialization;

namespace Carbon.Acme
{
    public class Subproblem
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "detail")]
        public string Detail { get; set; }

        [DataMember(Name = "identifier")]
        public Identifier Identifier { get; set; }
    }
}