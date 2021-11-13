// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Microsoft.AspNetCore.Html;
using Silk.NET.Statiq.TableOfContents;
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
            if (relPath.FileName == "index.html")
            {
                relPath = relPath.Parent;
            }

            return relPath.ToString();
        }

        public IHtmlContent Raw(string str) => new HtmlString(str);
        public bool IsBlogPost => Model?.GetToc()?.Node?.Ancestors.Any(IsBlog) ?? false;
        public bool IsBlogHomePage => IsBlog(Model?.GetToc()?.Node);
        public string ContentClasses => IsBlogPost ? "silk-content silk-blog" : "silk-content";
        private bool IsBlog(TableOfContentsElement? x)
            => x?.Metadata is not null &&
               x.Metadata.TryGetValue("theme.silk.blog", out var val) &&
               bool.TryParse(val, out var bVal) && bVal;
    }
}
