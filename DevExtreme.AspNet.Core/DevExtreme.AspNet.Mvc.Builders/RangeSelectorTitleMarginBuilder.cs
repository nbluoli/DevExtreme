namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the title.</summary>
	public class RangeSelectorTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the title.</summary>
		[Generated]
		public RangeSelectorTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
