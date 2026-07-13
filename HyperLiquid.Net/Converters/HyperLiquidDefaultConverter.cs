using HyperLiquid.Net.Objects.Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace HyperLiquid.Net.Converters
{
    internal class HyperLiquidDefaultConverter : JsonConverter<HyperLiquidDefault>
    {
        public override HyperLiquidDefault Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                var result = JsonSerializer.Deserialize<HyperLiquidDefault>(ref reader, (JsonTypeInfo<HyperLiquidDefault>)options.GetTypeInfo(typeof(HyperLiquidDefault)));
                return result!;
            }
            else
            {
                var error = reader.GetString()!;
                return new HyperLiquidDefault
                {
                    Type = error
                };
            }
        }

        public override void Write(Utf8JsonWriter writer, HyperLiquidDefault value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(value.Type);
            writer.WriteEndObject();
        }
    }
}
