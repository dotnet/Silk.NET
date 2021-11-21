// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Statiq.Common;

namespace Silk.NET.Statiq
{
    public class CaptionShortCode : IShortcode
    {
        public Task<IEnumerable<ShortcodeResult>> ExecuteAsync
            (KeyValuePair<string, string>[] args, string content, IDocument document, IExecutionContext context) =>
            Task.FromResult(args.Select(x => new ShortcodeResult($"<p class=\"text-center\">\n{x.Value}\n</p>")));
    }
}
