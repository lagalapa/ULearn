namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            int reminder = count % 10;

            if (count % 100 >= 11 && count % 100 <= 14)
                return "рублей";
            else if (reminder == 1)
                return "рубль";
            else if (reminder >= 2 && reminder <= 4)
                return "рубля";
            else
                return "рублей";
		}
	}
}