using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend title.</summary>
	public class PolarChartLegendTitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartLegendTitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's font options.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend title's position.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Generates space around the legend title.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Margin(Action<PolarChartLegendTitleMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the legend title.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the legend title.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Subtitle(Action<PolarChartLegendTitleSubtitleBuilder> configurator)
		{
			NestedOptions("subtitle", configurator);
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Subtitle(string value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Subtitle(JS value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's text.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's text.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's vertical alignment.</summary>
		[Generated]
		public PolarChartLegendTitleBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
