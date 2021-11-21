// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Silk.NET.Statiq.TableOfContents.Internals;
using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents.ProcessModules
{
    public class BakeTocModels : Module
    {
        protected override async Task<IEnumerable<IDocument>> ExecuteContextAsync(IExecutionContext context)
        {
            // the goal of this section is to:
            // - use all the ToC JSON files
            // - walk the tree in each of those files
            // - collect:
            //     - the file in which the ToC element is declared
            //     - the relative path to the file the ToC element refers to
            //     - the object representation of the ToC tree to which the ToC element belongs
            //     - the raw ToC element
            // this is because we need to have all that information represented in a nice way before "baking" the ToC
            // trees together, so we can just construct one big tree for all related ToCs.
            var rawTocModels = context.Inputs.OfType<ObjectDocument<LoadedRawToc>>().Select(x => x.Object).ToArray();
            if (!rawTocModels.Any())
            {
                // we can stop here if we don't have any models at all. keep everything in the pipeline, though.
                return context.Inputs;
            }

            return context.Inputs.Where(x => x is not ObjectDocument<LoadedRawToc>)
                .Concat(await new ObjectDocument<BakedToc>(new(Bake(rawTocModels.ToArray()))).YieldAsync());
        }

        private static ConcurrentDictionary<NormalizedPath, (TableOfContentsElement Root, TableOfContentsElement Value)>
            Bake
            (
                IEnumerable<LoadedRawToc> rawTocModels
            )
        {
            var wip =
                new Dictionary<NormalizedPath, (NormalizedPath OriginalToCFile, NormalizedPath Rel,
                    TableOfContentsElement Root,
                    TableOfContentsElement Value)>();

            // First pass removing duplicates
            foreach (var (tocFile, val) in rawTocModels)
            {
                var (srcRel, root, value) = val;
                // note - there used to be a ! here but it didn't make sense so i removed it.
                // if everything breaks, add it back.
                if (wip.TryAdd(srcRel, (tocFile, srcRel, root, value)))
                {
                    continue;
                }

                if (wip.TryGetValue(srcRel, out var existing))
                {
                    if (existing.OriginalToCFile == tocFile)
                    {
                        // do nothing
                    }
                    else
                    {
                        // uh-oh, duplicate key TODO logging
                    }
                }
                else
                {
                    // uh-oh, unknown error TODO logging
                }
            }

            // Second pass resolve fragmented models (that are linked together using ::path/to/inner/toc.json)
            // key: tocFile, value: file that includes the tocFile
            var includedToCs = new Dictionary<NormalizedPath, NormalizedPath>(); 
            foreach (var tocFile in wip.Select(x => x.Value.OriginalToCFile).Distinct())
            {
                foreach (var (key, value) in wip)
                {
                    // get the key.
                    var rawNcsVal = value.Value.Url;

                    // we need to check whether this a) is an include and b) whether the include refers to the current
                    // ToC file.
                    if (rawNcsVal is null || !rawNcsVal.StartsWith("::"))
                    {
                        continue;
                    }

                    var ncsF = value.Value.TocBasePath / rawNcsVal[2..];
                    if (ncsF != tocFile)
                    {
                        continue;
                    }

                    // looks like it is, get literally anything from the ToC tree that is from the file we want.
                    var referencedToCRoot = wip.FirstOrDefault(x => x.Value.OriginalToCFile == tocFile);

                    // if this condition is true, this means that FirstOrDefault returned default (but we can't
                    // actually check that! grr...)
                    if (referencedToCRoot.Key == default && referencedToCRoot.Value == default)
                    {
                        // we can't find the toc file - they probably haven't included it as an input file.
                        // nuke this element of the tree... TODO logging
                        if (!wip.Remove(key))
                        {
                            // failed to nuke it from the tree! it's now in an undefined state TODO logging
                        }

                        continue;
                    }


                    // now, things would get incredibly weird if we let the same ToC be used twice, so let's not
                    // allow that.
                    if (includedToCs.TryGetValue(tocFile, out var val))
                    {
                        // detected inclusion of the same ToC more than once TODO logging
                        // actualTocFileName is included in value.OriginalToCFile and val, nuke it...
                        if (!wip.Remove(key))
                        {
                            // failed to nuke it from the tree! it's now in an undefined state TODO logging
                        }

                        continue;
                    }

                    if (!includedToCs.TryAdd(tocFile, value.OriginalToCFile))
                    {
                        // failed to add it to the tree! it's now in an undefined state TODO logging
                        continue;
                    }

                    // cool. so now we have:
                    // - key, which is the rel path we got from walking the ToC trees
                    // - wip[key], which is the ToC element that contains the include.
                    // - referencedToCRoot, which is the root element of the ToC we're trying to include
                    var parent = wip[key].Value.Parent;
                    var indexOfThisElement = parent?.Children?.IndexOf(wip[key].Value);

                    // purge all children of the include
                    if (!(parent?.Children?.Remove(wip[key].Value) ?? true))
                    {
                        // failed to disown child TODO logging
                    }

                    // create the parent-child relationship bonding the two ToC trees together

                    // set the included ToC's parent to the including ToC
                    referencedToCRoot.Value.Root.Parent = parent;
                    // add the included ToC as a child to the including ToC
                    if (indexOfThisElement is not null)
                    {
                        parent?.Children?.Insert(indexOfThisElement.Value, referencedToCRoot.Value.Root);
                    }
                    else
                    {
                        parent?.Children?.Add(referencedToCRoot.Value.Root);
                    }

                    // remove the ToC inclusion from the ToC model now that the other models are in there
                    if (!wip.Remove(key))
                    {
                        // failed to nuke it from the tree! it's now in an undefined state TODO logging
                    }

                    // replace all elements referencing the included ToC as the root
                    foreach (var (referencingKey, referencingVal) in wip)
                    {
                        if (referencingVal.Root == referencedToCRoot.Value.Root)
                        {
                            wip[referencingKey] = (tocFile, referencingVal.Rel, value.Root, referencingVal.Value);
                        }
                    }
                }
            }

            // Third pass getting it in the format the caller wants
            var ret =
                new ConcurrentDictionary<NormalizedPath, (TableOfContentsElement Root, TableOfContentsElement Value)>();
            foreach (var (key, value) in wip)
            {
                ret.TryAdd(key, (value.Root, value.Value));
            }

            return ret;
        }
    }
}
