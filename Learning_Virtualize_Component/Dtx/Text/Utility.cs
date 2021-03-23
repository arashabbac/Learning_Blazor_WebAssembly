namespace Dtx.Text
{
	/// <summary>
	/// Version: 1.0.0
	/// Update Date: 1393/07/26
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public static class Utility
	{
		static Utility()
		{
		}

		public static string FixText(string text)
		{
			if (text == null)
			{
				return (string.Empty);
			}

			text = text.Trim();
			if (text == string.Empty)
			{
				return (string.Empty);
			}

			while (text.Contains("  "))
			{
				text = text.Replace("  ", " ");
			}

			return (text);
		}
	}
}
