﻿using System;

namespace Nest
{
	public class DateNanosAttribute : ElasticsearchDocValuesPropertyAttributeBase, IDateNanosProperty
	{
		public DateNanosAttribute() : base(FieldType.DateNanos) { }

		public double Boost
		{
			get => Self.Boost.GetValueOrDefault();
			set => Self.Boost = value;
		}

		public string Format
		{
			get => Self.Format;
			set => Self.Format = value;
		}

		public bool IgnoreMalformed
		{
			get => Self.IgnoreMalformed.GetValueOrDefault();
			set => Self.IgnoreMalformed = value;
		}

		public bool Index
		{
			get => Self.Index.GetValueOrDefault();
			set => Self.Index = value;
		}

		public DateTime NullValue
		{
			get => Self.NullValue.GetValueOrDefault();
			set => Self.NullValue = value;
		}

		double? IDateNanosProperty.Boost { get; set; }
		string IDateNanosProperty.Format { get; set; }
		bool? IDateNanosProperty.IgnoreMalformed { get; set; }

		bool? IDateNanosProperty.Index { get; set; }
		DateTime? IDateNanosProperty.NullValue { get; set; }
		private IDateNanosProperty Self => this;
	}
}
