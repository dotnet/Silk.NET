// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper.Annotations;

/// <summary>
/// An <see cref="ISymbolAnnotation"/> that indicates the original name as seen by the <see cref="ClangScraper"/>.
/// </summary>
/// <param name="NativeName">The native name</param>
public sealed record NativeNameAnnotation(string NativeName) : ISymbolAnnotation
{
}
