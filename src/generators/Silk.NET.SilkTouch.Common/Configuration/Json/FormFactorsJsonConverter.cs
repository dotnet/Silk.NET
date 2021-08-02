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
            => StringToFormFactors(reader.GetString());

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, FormFactors? value, JsonSerializerOptions options)
            => writer.WriteStringValue(value is not null ? FormFactorsToString(value.Value) : null);

        private static string FormFactorsToString(FormFactors ff)
            => (((ff & FormFactors.Roslyn) == FormFactors.Roslyn ? "Roslyn;" : string.Empty) +
                ((ff & FormFactors.CLI) == FormFactors.CLI ? "CLI;" : string.Empty))
                .TrimEnd(';');

        private static FormFactors? StringToFormFactors(string? str)
            => str?
                .Split(Constants.SemicolonDelimited, StringSplitOptions.RemoveEmptyEntries)
                .Aggregate
                (
                    FormFactors.Any, static(current, ff) => current | ff.Trim().ToLower() switch
                    {
                        "roslyn" => FormFactors.Roslyn,
                        "cli" => FormFactors.CLI,
                        "commandline" => FormFactors.CLI,
                        _ => FormFactors.Any
                    }
                );
    }
}
