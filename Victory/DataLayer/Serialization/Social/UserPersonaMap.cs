using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "UserPersonaMap", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class UserPersonaMap
	{
		[DataMember]
		public System.Int64 personaId {get; set;}
		[DataMember]
		public System.Int64 userId {get; set;}
	}
}
