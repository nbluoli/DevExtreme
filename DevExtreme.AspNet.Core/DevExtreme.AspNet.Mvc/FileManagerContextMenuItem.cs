using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FileManagerContextMenuItem
	{
		[EnumMember(Value = "create")]
		Create,
		[EnumMember(Value = "upload")]
		Upload,
		[EnumMember(Value = "refresh")]
		Refresh,
		[EnumMember(Value = "download")]
		Download,
		[EnumMember(Value = "move")]
		Move,
		[EnumMember(Value = "copy")]
		Copy,
		[EnumMember(Value = "rename")]
		Rename,
		[EnumMember(Value = "delete")]
		Delete
	}
}
