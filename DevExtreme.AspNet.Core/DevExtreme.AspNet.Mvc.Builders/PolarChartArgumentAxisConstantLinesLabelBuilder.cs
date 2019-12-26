using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining constant line label options.</summary>
	public class PolarChartArgumentAxisConstantLinesLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a constant line label.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the text to be displayed in a constant line label.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed in a constant line label.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to display labels for the axis constant lines.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to display labels for the axis constant lines.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLinesLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
