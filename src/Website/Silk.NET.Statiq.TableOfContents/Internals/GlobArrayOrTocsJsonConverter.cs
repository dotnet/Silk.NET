// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silk.NET.Statiq.TableOfContents.Internals
{
    internal class GlobArrayOrTocsJsonConverter : JsonConverter<List<TableOfContentsElement>?>
    {
        // TODO ==================================================== TODO
        // TODO ACTUALLY ADD SUPPORT FOR GLOB INCLUDES IN THE BAKERY TODO
        // TODO  AND MAKE THIS BE USED IN TableOfContentsElement.cs  TODO
        // TODO ==================================================== TODO
        public override List<TableOfContentsElement>? Read
            (ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try
            {
                var copy = reader;
                var stringArray = JsonSerializer.Deserialize<string[]>(ref copy, options);
                reader = copy;
                return stringArray?
                    .Select(x => new TableOfContentsElement { Url = $"::{{{string.Join(',', x)}}}" })
                    .ToList();
            }
            catch (JsonException)
            {
                return JsonSerializer.Deserialize<List<TableOfContentsElement>>(ref reader, options);
            }
        }

        public override void Write
            (Utf8JsonWriter writer, List<TableOfContentsElement>? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
