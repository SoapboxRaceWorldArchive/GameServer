using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "P2PCryptoTicket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class P2PCryptoTicket
	{
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.String SessionKey {get; set;}
	}
}
