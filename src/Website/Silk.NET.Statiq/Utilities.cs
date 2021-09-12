// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Routing;
using Statiq.Common;
using Statiq.Razor;

namespace Silk.NET.Statiq
{
    public abstract class SilkPage : StatiqRazorPage<IDocument>
    {
        /// <summary>
        /// Converts a path which is relative to the input path to a URL which is relative to the current page's
        /// containing directory.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>The URL.</returns>
        public string InputUrl(string path)
        {
            var fs = IExecutionContext.Current.FileSystem;
            var absOutputPath = fs.RootPath / fs.GetOutputPath();
            var absDestDirPath = fs.RootPath / fs.GetOutputPath(Document.Destination.Parent);
            var relPath = absDestDirPath.GetRelativePath(absOutputPath / Href(path).TrimStart('/'));
            return relPath.ToString();
        }

        public IHtmlContent Raw(string str) => new HtmlString(str);
    }
}
