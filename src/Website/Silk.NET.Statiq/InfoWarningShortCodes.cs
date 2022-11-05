// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Statiq.Common;

namespace Silk.NET.Statiq
{
    public class InfoShortCode : IShortcode
    {
        public Task<IEnumerable<ShortcodeResult>> ExecuteAsync
            (KeyValuePair<string, string>[] args, string content, IDocument document, IExecutionContext context) =>
            Task.FromResult(args.Select(x => new ShortcodeResult($"<div class=\"alert alert-info\" role=\"alert\">{x.Value}</div>")));
    }
    
    public class WarningShortCode : IShortcode
    {
        public Task<IEnumerable<ShortcodeResult>> ExecuteAsync
            (KeyValuePair<string, string>[] args, string content, IDocument document, IExecutionContext context) =>
            Task.FromResult(args.Select(x => new ShortcodeResult($"<div class=\"alert alert-warning\" role=\"alert\">{x.Value}</div>")));
    }
}
