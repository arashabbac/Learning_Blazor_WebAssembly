namespace Dtx.Globalization
{
	/// <remarks>
	/// Version: 4.0.1 - Date: 1392/11/28
	/// </remarks>
	public static class CultureInfo
	{
		public static int GetCurrentCultureLcid()
		{
			return (System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
		}

		public static Dtx.Globalization.Cultures GetCurrentCulture()
		{
			Dtx.Globalization.Cultures enmCulture =
				(Dtx.Globalization.Cultures)GetCurrentCultureLcid();

			return (enmCulture);
		}

		public static string GetCssClass()
		{
			Dtx.Globalization.Cultures enmCulture = GetCurrentCulture();

			return (GetCssClass(enmCulture));
		}

		public static string GetCssClass(Cultures culture)
		{
			switch (culture)
			{
				case Cultures.Farsi:
				{
					return ("rtl");
				}

				default:
				{
					return ("ltr");
				}
			}
		}
	}
}
