// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Threading.Tasks;
using Statiq.Common;

namespace Silk.NET.Statiq.TableOfContents.ProcessModules
{
    public class AddTableOfContents : ParentModule
    {
        public AddTableOfContents(params string[] patterns) : this(true, patterns)
        {
        }
        public AddTableOfContents(bool anyIfNotFound, params string[] patterns)
            : base(new LoadRawToc(patterns), new BakeTocModels(), new BakeTocIntoDocuments(anyIfNotFound))
        {
        }
        public AddTableOfContents(PathMatcher matcher, params string[] patterns)
            : base(new LoadRawToc(patterns), new BakeTocModels(), new BakeTocIntoDocuments(matcher))
        {
        }
        public AddTableOfContents(PathMatcher matcher, bool anyIfNotFound, params string[] patterns)
            : base(new LoadRawToc(patterns), new BakeTocModels(), new BakeTocIntoDocuments(matcher, anyIfNotFound))
        {
        }

        protected override async Task<IEnumerable<IDocument>> ExecuteContextAsync(IExecutionContext context)
            => await context.ExecuteModulesAsync(Children, context.Inputs);
    }
}
