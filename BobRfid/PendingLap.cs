using System;
using System.Runtime.Serialization;

namespace BobRfid
{
    [DataContract]
    internal class PendingLap
    {
        [DataMember]
        public string Epc { get; set; }

        [DataMember]
        public TimeSpan LapTime { get; set; }

        [DataMember]
        public string LapId { get; set; }
    }
}