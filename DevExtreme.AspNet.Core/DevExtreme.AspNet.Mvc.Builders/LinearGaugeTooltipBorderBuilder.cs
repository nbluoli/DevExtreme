namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip's border.</summary>
	public class LinearGaugeTooltipBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeTooltipBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors a tooltip's border.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's border.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of a tooltip's border.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's border.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's border.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip's border is visible.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip's border is visible.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of a tooltip's border in pixels.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of a tooltip's border in pixels.</summary>
		[Generated]
		public LinearGaugeTooltipBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
