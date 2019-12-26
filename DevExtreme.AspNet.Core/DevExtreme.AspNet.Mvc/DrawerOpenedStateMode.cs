using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DrawerOpenedStateMode
	{
		[EnumMember(Value = "overlap")]
		Overlap,
		[EnumMember(Value = "shrink")]
		Shrink,
		[EnumMember(Value = "push")]
		Push
	}
}