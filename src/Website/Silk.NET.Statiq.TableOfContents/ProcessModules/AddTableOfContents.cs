// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    }
}
