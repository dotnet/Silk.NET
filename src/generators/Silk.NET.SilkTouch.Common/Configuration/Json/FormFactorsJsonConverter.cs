// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silk.NET.SilkTouch.Configuration.Json
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for <see cref="FormFactors"/>.
    /// </summary>
    public class FormFactorsJsonConverter : JsonConverter<FormFactors?>
    {
        /// <inheritdoc />
        public override FormFactors? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => JsonSerializer.Deserialize<string[]>(ref reader)?.Aggregate(FormFactors.None, ParseFormFactorString);

        private static FormFactors ParseFormFactorString(FormFactors existing, string incoming)
            => existing |= incoming.ToLower().Trim() switch
            {
                "roslyn" => FormFactors.Roslyn,
                "cli" => FormFactors.CLI,
                _ => FormFactors.None
            };

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, FormFactors? value, JsonSerializerOptions options)
            => JsonSerializer.Serialize
            (
                writer,
                Enum.GetValues(typeof(FormFactors))
                    .OfType<FormFactors>()
                    .Where(x => (x & value) != 0)
                    .Select(static x => Enum.GetName(typeof(FormFactors), x))
            );
    }
}
