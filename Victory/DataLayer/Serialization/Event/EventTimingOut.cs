using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EventTimingOut", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EventTimingOut
	{
		[DataMember]
		public System.Int64 EventSessionId {get; set;}
		[DataMember]
		public System.Int64 TimeInMilliseconds {get; set;}
	}
}
