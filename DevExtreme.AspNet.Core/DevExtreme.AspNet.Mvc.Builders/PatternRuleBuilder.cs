namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands that the validated field match a specified pattern.</summary>
	public class PatternRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PatternRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PatternRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public PatternRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public PatternRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public PatternRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public PatternRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the regular expression that the validated value must match.</summary>
		[Generated]
		public PatternRuleBuilder Pattern(string value)
		{
			base.Options["pattern"] = value;
			return this;
		}

		/// <summary>Specifies the regular expression that the validated value must match.</summary>
		[Generated]
		public PatternRuleBuilder Pattern(JS value)
		{
			base.Options["pattern"] = value;
			return this;
		}
	}
}
