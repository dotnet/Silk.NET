// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Silk.NET.Statiq.TableOfContents.Internals;
using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents
{
    public class TableOfContentsElement
    {
        /// <summary>
        /// The name of this page.
        /// </summary>
        [JsonInclude]
        public string? Name { get; internal set; }

        /// <summary>
        /// The URL to the file referenced in the table of contents, relative to the table of contents file.
        /// </summary>
        [JsonInclude]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Url { get; internal set; }

        /// <summary>
        /// The URL to the file referenced in the table of contents, relative to the input directory.
        /// </summary>
        [JsonIgnore]
        public NormalizedPath FullUrl { get; internal set; }

        /// <summary>
        /// The value, usable in the HTML href attribute (unless relativity matters), of this ToC element.
        /// </summary>
        [JsonIgnore]
        public string Href => "~/" + FullUrl;

        /// <summary>
        /// The elements beneath this element in the table of contents.
        /// </summary>
        [JsonInclude]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        // TODO [JsonConverter(typeof(GlobArrayOrTocsJsonConverter))]
        public List<TableOfContentsElement>? Children { get; internal set; }

        /// <summary>
        /// Miscellaneous metadata, defined by the user and used by the Razor theme.
        /// </summary>
        [JsonInclude]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; internal set; }

        /// <summary>
        /// Whether the <see cref="TableOfContentsModel"/> containing this element is being passed to the page
        /// represented by this element.
        /// </summary>
        [JsonIgnore]
        public bool IsActive { get; internal set; }

        /// <summary>
        /// Whether any of the direct descendants in <see cref="Children"/> of this table of contents element are
        /// active, as defined by <see cref="IsActive"/>.
        /// </summary>
        /// <remarks>
        /// i.e. this method returns true when one of this element's children is active, but false when one of the
        /// children's children are active. To return true even in the latter case, use <see cref="IsAnyChildActive"/>.
        /// </remarks>
        [JsonIgnore]
        public bool IsChildActive => Children?.Any(static x => x.IsActive) ?? false;

        /// <summary>
        /// Whether any of the descendants in <see cref="Children"/> of this table of contents element are
        /// active, as defined by <see cref="IsActive"/>.
        /// </summary>
        /// <remarks>
        /// i.e. this method returns true when one of this element's children is active, even when one of the
        /// children's children are active, regardless of the depth of the descendant. To return false in the latter
        /// case, use <see cref="IsChildActive"/>.
        /// </remarks>
        [JsonIgnore]
        public bool IsAnyChildActive => Children?.Any(static x => x.IsActive || x.IsAnyChildActive) ?? false;

        public IEnumerable<TableOfContentsElement> Ancestors
        {
            get
            {
                static IEnumerable<TableOfContentsElement> GetAncestorsThisFirst(TableOfContentsElement @this)
                {
                    var currentNode = @this;
                    while (currentNode is not null)
                    {
                        if (currentNode != @this)
                        {
                            yield return currentNode;
                        }

                        currentNode = currentNode.Parent;
                    }
                }

                return GetAncestorsThisFirst(this).Reverse();
            }
        }
        
        [JsonIgnore]
        internal NormalizedPath TocBasePath { get; set; }
        
        [JsonIgnore]
        internal NormalizedPath TocFile { get; set; }
        
        [JsonIgnore]
        public TableOfContentsElement? Parent { get; internal set; }
    }
}