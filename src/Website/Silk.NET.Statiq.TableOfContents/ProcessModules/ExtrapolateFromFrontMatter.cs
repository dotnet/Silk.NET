// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents.ProcessModules
{
    public class ExtrapolateFromFrontMatter : ParallelModule
    {
        private ConcurrentBag<TableOfContentsElement> _removeFromOutput = new();
        private ConcurrentDictionary<IDocument, (int, TableOfContentsElement)> _visited = new();

        protected override void BeforeExecution(IExecutionContext context)
        {
            _visited = new();
            _removeFromOutput = new();
        }

        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync
            (IDocument input, IExecutionContext context)
        {
            var toc = await MakeTocAsync(input, 0);
            if (toc is null)
            {
                return await input.YieldAsync();
            }

            return new[] { input, new ObjectDocument<TableOfContentsElement>(toc) };

            async Task<TableOfContentsElement?> MakeTocAsync(IDocument document, int currentDepth)
            {
                var title = document.GetString("Title");
                var children = input.Get<string[]>("Children");
                if (children is null)
                {
                    var sChildren = input.GetString("Children");
                    if (sChildren is not null)
                    {
                        children = new[] { sChildren };
                    }
                }

                if (title is null)
                {
                    return null;
                }

                var ret = new TableOfContentsElement
                {
                    Name = title,
                    Children = (children is null
                        ? null
                        : (await Globber.GetFiles(context.FileSystem.GetInputDirectory(input.Source.Parent))
                            .SelectMany(x => context.Inputs.Where(y => x.Path == y.Source))
                            .ParallelSelectAsync(async x => await MakeTocAsync(x, currentDepth + 1)))
                        .Where(x => x is not null)
                        .ToList())!,
                    Metadata = input.Get<Dictionary<string, string>>("TocMetadata"),
                    Url = $"_toc/{document.Source.GetRelativeInputPath().ToString()}",
                    TocFile = $"{Guid.NewGuid()}.json",
                    TocBasePath = "."
                };

                var (previousDepth, existingRet) = _visited.GetOrAdd(document, (currentDepth, ret));

                // if we've found this document deeper somewhere else, prefer that
                if (previousDepth > currentDepth)
                {
                    return null;
                }

                if (previousDepth == currentDepth)
                {
                    context.LogWarning
                    (
                        input,
                        "Found the same document at the same depth within another extrapolated ToC - this is " +
                        "undefined behaviour!"
                    );
                }

                _removeFromOutput.Add(existingRet);
                return ret;
            }
        }

        protected override void AfterExecution(IExecutionContext context, ExecutionOutputs outputs)
        {
            outputs.Outputs = outputs.Outputs
                .Where(x => x is not ObjectDocument<TableOfContentsElement> e || !_removeFromOutput.Contains(e.Object));
        }
    }
}
