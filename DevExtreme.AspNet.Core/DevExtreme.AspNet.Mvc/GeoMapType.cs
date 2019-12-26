using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GeoMapType
	{
		[EnumMember(Value = "hybrid")]
		Hybrid,
		[EnumMember(Value = "roadmap")]
		Roadmap,
		[EnumMember(Value = "satellite")]
		Satellite
	}
}