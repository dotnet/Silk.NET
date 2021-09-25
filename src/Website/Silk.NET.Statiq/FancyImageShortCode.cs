// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Statiq.Common;

namespace Silk.NET.Statiq
{
    public class FancyImageShortCode : IShortcode
    {
        public Task<IEnumerable<ShortcodeResult>> ExecuteAsync(KeyValuePair<string, string>[] args, string content, IDocument document, IExecutionContext context)
        {
            string? imageUrl = null;
            var width = "600px"; // keep this in sync with silk.css .silk-content > img
            string? altText = null;
            string? caption = null;
            var center = true;
            for (var i = 0; i < args.Length; i++)
            {
                var kvp = args[i];
                if (string.IsNullOrWhiteSpace(kvp.Key))
                {
                    kvp = new
                    (
                        i switch { 0 => "url", 1 => "alt", 2 => "caption", 3 => "width", _ => string.Empty },
                        kvp.Value
                    );
                }
                switch (kvp.Key.ToLower())
                {
                    case "url":
                    {
                        imageUrl = kvp.Value;
                        break;
                    }

                    case "alt":
                    {
                        altText = kvp.Value;
                        break;
                    }

                    case "caption":
                    {
                        caption = kvp.Value;
                        break;
                    }

                    case "width":
                    {
                        width = kvp.Value;
                        break;
                    }

                    case "center":
                    {
                        center = bool.Parse(kvp.Value);
                        break;
                    }

                    default:
                    {
                        throw new KeyNotFoundException("Unknown key/position for argument to fancy image shortcode.");
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                throw new ArgumentException("Needs image url", nameof(args));
            }

            var sb = new StringBuilder();
            var align = center ? "text-center" : "text-left";
            sb.AppendLine($"<p class=\"{align}\">");
            sb.Append($"    <img src=\"{imageUrl}\" style=\"width: {width};\"");
            if (!string.IsNullOrWhiteSpace(altText))
            {
                sb.Append($" alt=\"{altText}\"");
            }

            sb.AppendLine(">");
            if (!string.IsNullOrWhiteSpace(caption))
            {
                sb.AppendLine("<br />");
                sb.AppendLine(caption);
            }

            sb.AppendLine("</p>");

            return Task.FromResult<IEnumerable<ShortcodeResult>>(new[] { new ShortcodeResult(sb.ToString()) });
        }
    }
}
