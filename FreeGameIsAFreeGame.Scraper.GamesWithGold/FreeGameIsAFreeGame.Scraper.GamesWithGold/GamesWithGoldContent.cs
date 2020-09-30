namespace FreeGameIsAFreeGame.Scraper.GamesWithGold
{
    internal class GamesWithGoldContent
    {
        public string Title { get; private set; }
        public string Include { get; private set; }
        public string Exclude { get; private set; }
        public string Link { get; private set; }
        public string Image { get; private set; }
        public string Dates { get; private set; }

        public GamesWithGoldContent(GamesLocale locale, int index)
        {
            var type = typeof(GamesLocale);
            Title = (string)type.GetProperty($"KeyCopytitlenowgame{index}").GetValue(locale);
            Include = (string)type.GetProperty($"KeyIncludenowgame{index}").GetValue(locale);
            Exclude = (string)type.GetProperty($"KeyExcludenowgame{index}").GetValue(locale);
            Link = (string)type.GetProperty($"KeyLinknowgame{index}").GetValue(locale);
            Image = (string)type.GetProperty($"KeyImagenowgame{index}").GetValue(locale);
            Dates = (string)type.GetProperty($"KeyCopydatesnowgame{index}").GetValue(locale);
        }
    }
}
