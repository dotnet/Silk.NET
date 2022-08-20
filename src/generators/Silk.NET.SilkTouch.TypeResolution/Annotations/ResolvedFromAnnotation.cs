// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.TypeResolution.Annotations;

/// <summary>
/// An <see cref="ISymbolAnnotation"/> indicating what string a <see cref="TypeReference"/> was resolved from
/// Commonly added during type resolution. For debugging and native type discovery only. Do not use to implement multi-pass type resolution
/// </summary>
/// <param name="OriginalString">The original string the <see cref="TypeReference"/> this is referenced by was resolved from</param>
public sealed record ResolvedFromAnnotation(string OriginalString) : ISymbolAnnotation
{
    
}
