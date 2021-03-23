namespace Dtx.Calendar
{
	public class Year : System.Object
	{
		private static System.Collections.Generic.List<Year> _years;
		public static System.Collections.Generic.List<Year> Years
		{
			get
			{
				if (_years == null)
				{
					_years =
						new System.Collections.Generic.List<Year>();

					for (int intIndex = 1300; intIndex <= 1400; intIndex++)
					{
						_years.Add(new Year(intIndex));
					}
				}

				return (_years);
			}
		}

		public Year()
		{
		}

		public Year(int value)
		{
			Value = value;
		}

		public int Value { get; set; }

		public string Text
		{
			get
			{
				return (Dtx.Text.Convert.DisplayNumber(Value));
			}
		}
	}
}
