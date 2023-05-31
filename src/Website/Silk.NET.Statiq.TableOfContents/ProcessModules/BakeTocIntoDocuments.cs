// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Silk.NET.Statiq.TableOfContents.Internals;
using Statiq.Common;
using static Silk.NET.Statiq.TableOfContents.Internals.Utilities;

namespace Silk.NET.Statiq.TableOfContents.ProcessModules
{
    public class BakeTocIntoDocuments : ParallelModule
    {
        private readonly bool _anyIfNotFound;
        private ObjectDocument<BakedToc>[]? _tocs;
        private PathMatcher _pathMatcher;

        public BakeTocIntoDocuments(bool anyIfNotFound = true)
            => (_pathMatcher, _anyIfNotFound) = ((x, y) => x == y, anyIfNotFound);

        public BakeTocIntoDocuments(PathMatcher matcher, bool anyIfNotFound = true)
            => (_pathMatcher, _anyIfNotFound) = (matcher, anyIfNotFound);

        protected override void BeforeExecution(IExecutionContext context)
            => _tocs = context.Inputs.OfType<ObjectDocument<BakedToc>>().ToArray();

        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync
        (
            IDocument input,
            IExecutionContext context
        )
        {
            if (!_tocs?.Any() ?? true)
            {
                // early out if there's no tocs to begin with
                return await input.YieldAsync();
            }

            if (input is ObjectDocument<BakedToc>)
            {
                // if the document is itself a toc, remove it from the pipeline.
                return DocumentList<IDocument>.Empty;
            }

            // find a toc in which the document has a matching entry in its map.
            var matchingToc = input.Source.IsNull
                ? null
                : _tocs?.SelectMany(x => x.Object.TocMap)
                    .FirstOrDefault(x => _pathMatcher(x.Key, input.Source.GetRelativeInputPath()));
            if (matchingToc?.Value.Value is null) // would be matchingToc is null but FirstOrDefault is strange...
            {
                if (_anyIfNotFound)
                {
                    // if there is no matching ToC and _anyIfNotFound mode is on (e.g. get any ToC so we can still
                    // render a navbar), 
                    context.LogWarning(input, "Document is not part of any ToC, using \"any-if-not-found\" mode...");
                    var fallbackMetadata = input.Concat
                    (
                        Yield
                        (
                            new KeyValuePair<string, object>
                            (
                                nameof(TableOfContentsModel),
                                new TableOfContentsModel
                                (
                                    _tocs!.Select(x => x.Object.TocMap.Select(y => y.Value.Root).FirstOrDefault())
                                        .FirstOrDefault(x => x is not null)
                                    ?? throw new InvalidOperationException
                                    (
                                        "Any-if-not-found mode failed: ToCs are empty."
                                    ),
                                    null
                                )
                            )
                        )
                    );

                    // clone the document with the model added as metadata to it
                    return await input.Clone(fallbackMetadata).YieldAsync();
                }

                // _anyIfNotFound mode is off, just return the original document.
                context.LogWarning(input, "Document is not part of any ToC!");
                return await input.YieldAsync();
            }
            
            context.LogDebug(input, $"Using ToC \"{matchingToc.Value.Value.Root.TocFile}\"");

            // clone the model to ensure it's self-contained, unique for this document, & can't be modified/messed with
            var theToc = Clone(matchingToc.Value.Value);

            // set the current document as active in the model
            theToc.Node!.IsActive = true;

            // add the model to the metadata
            var md = input.Concat(Yield(new KeyValuePair<string, object>(nameof(TableOfContentsModel), theToc)));

            // ensure everything has a title property
            if (theToc.Node!.Name is not null && input.GetString("Title") is null)
            {
                md = md.Concat(Yield(new KeyValuePair<string, object>("Title", theToc.Node!.Name)));
            }
            else if (theToc.Node!.Name is null)
            {
                theToc.Node!.Name = input.GetString("Title");
            }

            // clone the document with the model added as metadata to it
            return await input.Clone(md).YieldAsync();
        }

        private static TableOfContentsModel Clone
        (
            (TableOfContentsElement Root, TableOfContentsElement Value) @in
        )
        {
            TableOfContentsElement? value = null;
            var root = CoreClone(@in.Root, @in.Value, ref value);
            if (value is null)
            {
                throw new ArgumentException("Given Value was not present within the Root");
            }

            return new(root, value);
        }

        private static TableOfContentsElement CoreClone
        (
            TableOfContentsElement element,
            TableOfContentsElement lookForValue,
            ref TableOfContentsElement? value
        )
        {
            TableOfContentsElement? tempValue = null;
            var ret = new TableOfContentsElement
            {
                Name = element.Name,
                Url = element.Url,
                FullUrl = element.FullUrl,
                Children = element.Children?.Select(x => CoreClone(x, lookForValue, ref tempValue)).ToList(),
                Metadata = element.Metadata?.ToDictionary(static x => x.Key, static x => x.Value),
                IsActive = false,
                TocBasePath = element.TocBasePath,
                TocFile = element.TocFile
            };

            foreach (var elem in ret.Children ?? Enumerable.Empty<TableOfContentsElement>())
            {
                elem.Parent = ret;
            }

            if (element == lookForValue)
            {
                value ??= ret;
            }

            value ??= tempValue;

            return ret;
        }
    }
}
