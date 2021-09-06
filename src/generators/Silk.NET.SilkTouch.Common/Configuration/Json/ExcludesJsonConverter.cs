// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silk.NET.SilkTouch.Configuration.Json
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting a JSON string array to an <see cref="Excludes"/> record.
    /// </summary>
    public class ExcludesJsonConverter : JsonConverter<Excludes>
    {
        /// <inheritdoc />
        public override Excludes? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var list = JsonSerializer.Deserialize<string[]>(ref reader);
            if (list is null)
            {
                return null;
            }

            var identifiers = new List<string>(list.Length);
            var hints = ExclusionHint.None;
            foreach (var exclusion in list)
            {
                var kvp = exclusion.Split(Constants.SemicolonDelimited, StringSplitOptions.RemoveEmptyEntries);
                // this is the ugliest piece of code I think I've ever wrote. basically, if it's a hint:
                // - join everything past the "hint: " in the string into one big string
                // - remove anything that isn't a letter (using NS20 APIs)
                // - parse the resultant string as a hint
                // given the number of calls to this code does not go up with the number of lines generated,
                // the performance is horrible but it's not too much a cause for concern as it is a "fixed cost".
                // definitely improve it in the future though as we do have access to new string(char*), meaning we can
                // come up with a Span-based solution it'll just be very very very verbose.
                if (string.Equals(kvp[0].Trim(), "hint", StringComparison.OrdinalIgnoreCase) && Enum.TryParse
                (
                    string.Join
                    (
                        string.Empty,
                        kvp.Skip(1).Select
                        (
                            static x => new string(x.Where(static y => char.IsUpper(y) || char.IsLower(y)).ToArray())
                        )
                    ), out ExclusionHint hint
                ))
                {
                    hints |= hint;
                }
                else if (string.Equals(kvp[0].Trim(), "name", StringComparison.OrdinalIgnoreCase))
                {
                    identifiers.Add(string.Join(":", kvp.Skip(1)));
                }
                else
                {
                    identifiers.Add(exclusion);
                }
            }

            return new(identifiers.ToArray(), hints);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Excludes? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
