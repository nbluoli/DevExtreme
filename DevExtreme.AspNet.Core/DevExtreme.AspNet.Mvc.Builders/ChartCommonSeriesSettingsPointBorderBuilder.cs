namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the series point border in scatter, line- and area-like series.</summary>
	public class ChartCommonSeriesSettingsPointBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the border.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the border.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the border visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the border visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets the width of the border in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets the width of the border in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
