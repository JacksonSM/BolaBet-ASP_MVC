using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BolaBet.Application.EntitiesMatchesApi
{

    public enum Nationality { Italy, Poland, Slovenia };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                NationalityConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class NationalityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Nationality) || t == typeof(Nationality?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Italy":
                    return Nationality.Italy;
                case "Poland":
                    return Nationality.Poland;
                case "Slovenia":
                    return Nationality.Slovenia;
            }
            throw new Exception("Cannot unmarshal type Nationality");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Nationality)untypedValue;
            switch (value)
            {
                case Nationality.Italy:
                    serializer.Serialize(writer, "Italy");
                    return;
                case Nationality.Poland:
                    serializer.Serialize(writer, "Poland");
                    return;
                case Nationality.Slovenia:
                    serializer.Serialize(writer, "Slovenia");
                    return;
            }
            throw new Exception("Cannot marshal type Nationality");
        }

        public static readonly NationalityConverter Singleton = new NationalityConverter();
    }
}
