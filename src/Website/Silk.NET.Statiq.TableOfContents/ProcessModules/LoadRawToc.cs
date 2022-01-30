// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing;
using Silk.NET.Statiq.TableOfContents.Internals;
using Statiq.Common;
using static Silk.NET.Statiq.TableOfContents.Internals.Utilities;

namespace Silk.NET.Statiq.TableOfContents.ProcessModules
{
    public class LoadRawToc : ParallelModule
    {
        private readonly Matcher? _matcher;

        public LoadRawToc(params string[] patterns)
        {
            if (patterns.Length == 0)
            {
                _matcher = null; // micro-optimization
            }

            _matcher = new();
            _matcher.AddIncludePatterns(patterns.Where(x => x.FirstOrDefault() != '!'));
            _matcher.AddExcludePatterns(patterns.Where(x => x.FirstOrDefault() == '!').Select(x => x[1..]));
        }

        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync
            (IDocument input, IExecutionContext context)
        {
            // no source? keep it in the pipeline.
            if (input.Source.IsNull)
            {
                return await input.YieldAsync();
            }

            // check whether this file matches against any 
            var match = _matcher?.Execute
            (
                new InMemoryDirectoryInfo
                (
                    context.FileSystem.GetContainingInputPath(input.Source).ToString(),
                    Yield(input.Source.ToString())
                )
            );

            // assume that no pattern = everything is a toc (i.e it's a dedicated pipeline)
            var isAToC = match?.HasMatches ?? true;

            // if it's not a ToC, keep it in the pipeline as is
            if (!isAToC)
            {
                if (input.TryGetValue("TableOfContents", out var toc) && toc is MetadataDictionary md)
                {
                    context.Logger.LogDebug(input, "Found ToC in metadata");
                    var model = JsonSerializer.Deserialize<TableOfContentsElement>(md.ToJson());
                    if (model is not null && model.Url is null)
                    {
                        model.Url = input.Source.FileName.ToString();
                    }

                    return Load(model).Concat(Yield(input));
                }

                context.Logger.LogDebug(input, "Not a ToC");
                return await input.YieldAsync();
            }

            context.Logger.LogDebug(input, "Found ToC");
            using var sr = new StreamReader(input.GetContentStream());
            return Load(JsonSerializer.Deserialize<TableOfContentsElement>(await sr.ReadToEndAsync()));

            IEnumerable<IDocument> Load(TableOfContentsElement? e)
                => GetRawToCModels(input, e)
                    .Select(x => new ObjectDocument<LoadedRawToc>(x));
        }

        private static IEnumerable<LoadedRawToc> GetRawToCModels
        (
            IDocument doc,
            TableOfContentsElement? model
        )
        {
            // get the file name of the ToC JSON file
            var file = doc.Source;

            // all paths in the model are relative to the directory in which the toc is contained.
            // get the path of the ToC in the input directory, and walk relative to that.
            var tocBasePath = file.Parent.GetRelativeInputPath();

            // get all ToC entries
            var thisRet = Walk(model!, tocBasePath, file.Parent, file, model!)
                .Select(y => new LoadedRawToc(doc.Source, y))
                .ToArray();

            // make all the Parent properties work
            CreateParentReferences(thisRet.Select(y => y.Value.RootModel).Distinct());

            // we're done!
            return thisRet;
        }

        private static void CreateParentReferences
        (
            IEnumerable<TableOfContentsElement>? rootModels,
            TableOfContentsElement? parent = null
        )
        {
            foreach (var model in rootModels ?? Enumerable.Empty<TableOfContentsElement>())
            {
                model.Parent = parent;
                CreateParentReferences(model.Children, model);
            }
        }

        private static IEnumerable<(NormalizedPath, TableOfContentsElement, TableOfContentsElement)> Walk
        (
            TableOfContentsElement child,
            NormalizedPath tocBasePathRelative,
            NormalizedPath tocBasePathAbsolute,
            NormalizedPath tocFile,
            TableOfContentsElement root
        )
        {
            child.TocBasePath = tocBasePathAbsolute;
            child.TocFile = tocFile;
            if (child.Url is not null)
            {
                if (child.Url.StartsWith(">>"))
                {
                    child.Url = child.Url[2..];
                    child.FullUrl = tocBasePathRelative / child.Url;
                }
                else
                {
                    child.FullUrl = tocBasePathRelative / child.Url;
                    yield return (child.FullUrl, root, child);
                }
            }

            // recurse for children
            foreach (var element in child.Children ?? Enumerable.Empty<TableOfContentsElement>())
            {
                foreach (var walked in Walk(element, tocBasePathRelative, tocBasePathAbsolute, tocFile, root))
                {
                    yield return walked;
                }
            }
        }
    }
}
