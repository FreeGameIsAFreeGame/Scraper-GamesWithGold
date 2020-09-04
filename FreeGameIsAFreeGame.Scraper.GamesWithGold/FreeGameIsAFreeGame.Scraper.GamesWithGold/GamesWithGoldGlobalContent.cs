using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FreeGameIsAFreeGame.Scraper.GamesWithGold
{
    using J = JsonPropertyAttribute;

    internal partial class GamesWithGoldGlobalContent
    {
        [J("locales")] public Dictionary<string, GamesLocale> Locales { get; set; }
    }

    internal partial class GamesLocale
    {
        [J("keyCopytitlenowgame1")] public string KeyCopytitlenowgame1 { get; set; }
        [J("keyIncludenowgame1")] public string KeyIncludenowgame1 { get; set; }
        [J("keyExcludenowgame1")] public string KeyExcludenowgame1 { get; set; }
        [J("keyLinknowgame1")] public string KeyLinknowgame1 { get; set; }
        [J("keyRetailernowgame1")] public string KeyRetailernowgame1 { get; set; }
        [J("keyImagenowgame1")] public string KeyImagenowgame1 { get; set; }
        [J("keyAltnowgame1")] public string KeyAltnowgame1 { get; set; }
        [J("keyCopydatesnowgame1")] public string KeyCopydatesnowgame1 { get; set; }
        [J("keyPlaysonnowgame1")] public string KeyPlaysonnowgame1 { get; set; }
        [J("keyCopytitlenowgame2")] public string KeyCopytitlenowgame2 { get; set; }
        [J("keyIncludenowgame2")] public string KeyIncludenowgame2 { get; set; }
        [J("keyExcludenowgame2")] public string KeyExcludenowgame2 { get; set; }
        [J("keyLinknowgame2")] public string KeyLinknowgame2 { get; set; }
        [J("keyRetailernowgame2")] public string KeyRetailernowgame2 { get; set; }
        [J("keyImagenowgame2")] public string KeyImagenowgame2 { get; set; }
        [J("keyAltnowgame2")] public string KeyAltnowgame2 { get; set; }
        [J("keyCopydatesnowgame2")] public string KeyCopydatesnowgame2 { get; set; }
        [J("keyPlaysonnowgame2")] public string KeyPlaysonnowgame2 { get; set; }
        [J("keyCopytitlenowgame3")] public string KeyCopytitlenowgame3 { get; set; }
        [J("keyIncludenowgame3")] public string KeyIncludenowgame3 { get; set; }
        [J("keyExcludenowgame3")] public string KeyExcludenowgame3 { get; set; }
        [J("keyLinknowgame3")] public string KeyLinknowgame3 { get; set; }
        [J("keyRetailernowgame3")] public string KeyRetailernowgame3 { get; set; }
        [J("keyImagenowgame3")] public string KeyImagenowgame3 { get; set; }
        [J("keyAltnowgame3")] public string KeyAltnowgame3 { get; set; }
        [J("keyCopydatesnowgame3")] public string KeyCopydatesnowgame3 { get; set; }
        [J("keyPlaysonnowgame3")] public string KeyPlaysonnowgame3 { get; set; }
        [J("keyCopytitlenowgame4")] public string KeyCopytitlenowgame4 { get; set; }
        [J("keyIncludenowgame4")] public string KeyIncludenowgame4 { get; set; }
        [J("keyExcludenowgame4")] public string KeyExcludenowgame4 { get; set; }
        [J("keyLinknowgame4")] public string KeyLinknowgame4 { get; set; }
        [J("keyRetailernowgame4")] public string KeyRetailernowgame4 { get; set; }
        [J("keyImagenowgame4")] public string KeyImagenowgame4 { get; set; }
        [J("keyAltnowgame4")] public string KeyAltnowgame4 { get; set; }
        [J("keyCopydatesnowgame4")] public string KeyCopydatesnowgame4 { get; set; }
        [J("keyPlaysonnowgame4")] public string KeyPlaysonnowgame4 { get; set; }
        [J("keyCopytitlenowgame5")] public string KeyCopytitlenowgame5 { get; set; }
        [J("keyIncludenowgame5")] public string KeyIncludenowgame5 { get; set; }
        [J("keyExcludenowgame5")] public string KeyExcludenowgame5 { get; set; }
        [J("keyLinknowgame5")] public string KeyLinknowgame5 { get; set; }
        [J("keyRetailernowgame5")] public string KeyRetailernowgame5 { get; set; }
        [J("keyImagenowgame5")] public string KeyImagenowgame5 { get; set; }
        [J("keyAltnowgame5")] public string KeyAltnowgame5 { get; set; }
        [J("keyCopydatesnowgame5")] public string KeyCopydatesnowgame5 { get; set; }
        [J("keyPlaysonnowgame5")] public string KeyPlaysonnowgame5 { get; set; }
        [J("keyCopytitlenowgame6")] public string KeyCopytitlenowgame6 { get; set; }
        [J("keyIncludenowgame6")] public string KeyIncludenowgame6 { get; set; }
        [J("keyExcludenowgame6")] public string KeyExcludenowgame6 { get; set; }
        [J("keyLinknowgame6")] public string KeyLinknowgame6 { get; set; }
        [J("keyRetailernowgame6")] public string KeyRetailernowgame6 { get; set; }
        [J("keyImagenowgame6")] public string KeyImagenowgame6 { get; set; }
        [J("keyAltnowgame6")] public string KeyAltnowgame6 { get; set; }
        [J("keyCopydatesnowgame6")] public string KeyCopydatesnowgame6 { get; set; }
        [J("keyPlaysonnowgame6")] public string KeyPlaysonnowgame6 { get; set; }
        [J("keyCopytitlenowgame7")] public string KeyCopytitlenowgame7 { get; set; }
        [J("keyIncludenowgame7")] public string KeyIncludenowgame7 { get; set; }
        [J("keyExcludenowgame7")] public string KeyExcludenowgame7 { get; set; }
        [J("keyLinknowgame7")] public string KeyLinknowgame7 { get; set; }
        [J("keyRetailernowgame7")] public string KeyRetailernowgame7 { get; set; }
        [J("keyImagenowgame7")] public string KeyImagenowgame7 { get; set; }
        [J("keyAltnowgame7")] public string KeyAltnowgame7 { get; set; }
        [J("keyCopydatesnowgame7")] public string KeyCopydatesnowgame7 { get; set; }
        [J("keyPlaysonnowgame7")] public string KeyPlaysonnowgame7 { get; set; }
        [J("keyCopytitlenowgame8")] public string KeyCopytitlenowgame8 { get; set; }
        [J("keyIncludenowgame8")] public string KeyIncludenowgame8 { get; set; }
        [J("keyExcludenowgame8")] public string KeyExcludenowgame8 { get; set; }
        [J("keyLinknowgame8")] public string KeyLinknowgame8 { get; set; }
        [J("keyRetailernowgame8")] public string KeyRetailernowgame8 { get; set; }
        [J("keyImagenowgame8")] public string KeyImagenowgame8 { get; set; }
        [J("keyAltnowgame8")] public string KeyAltnowgame8 { get; set; }
        [J("keyCopydatesnowgame8")] public string KeyCopydatesnowgame8 { get; set; }
        [J("keyPlaysonnowgame8")] public string KeyPlaysonnowgame8 { get; set; }

        public GamesWithGoldContent ToGamesWithGoldContent(int index)
        {
            return new GamesWithGoldContent(this, index);
        }
    }

    internal partial class GamesWithGoldGlobalContent
    {
        public static GamesWithGoldGlobalContent FromJson(string json) =>
            JsonConvert.DeserializeObject<GamesWithGoldGlobalContent>(json,
                Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            },
        };
    }
}
