using System.Runtime.Serialization;
using System.Xml.Serialization;
using SoapCore.Tests.Serialization.Models.Xml;

namespace SoapCore.Tests.Model
{
	[DataContract]
	[XmlRoot(Namespace = ServiceNamespace.Value + "FaultDetail")]
	[XmlType(Namespace = ServiceNamespace.Value + "FaultDetail")]
	public class FaultDetail
	{
		[DataMember]
		[XmlElement(Namespace = ServiceNamespace.Value + "ExceptionDetails")]
		public string ExceptionProperty { get; set; }
	}
}
