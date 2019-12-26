namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies connector options for series point labels.</summary>
	public class PolarChartCommonSeriesSettingsLabelConnectorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of label connectors.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of label connectors.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Indicates whether or not label connectors are visible.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not label connectors are visible.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of label connectors.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of label connectors.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelConnectorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
