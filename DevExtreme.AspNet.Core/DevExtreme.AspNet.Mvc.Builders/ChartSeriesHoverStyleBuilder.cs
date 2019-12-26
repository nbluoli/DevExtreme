using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by the series when a user points to it.</summary>
	public class ChartSeriesHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Border(Action<ChartSeriesHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of the series in the hovered state.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series in the hovered state.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series line when the series is in the hovered state. Applies only to line-like series.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Configures hatching that applies when a user points to the series.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Hatching(Action<ChartSeriesHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the pixel-measured width of the series line when the series is in the hovered state.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured width of the series line when the series is in the hovered state.</summary>
		[Generated]
		public ChartSeriesHoverStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
