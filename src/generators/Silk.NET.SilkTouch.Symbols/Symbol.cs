// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// The base Symbol. Represents shared properties of all Symbols. Primarily used with <see cref="SymbolVisitor"/>
/// </summary>
/// <param name="Annotations">The annotations of this symbol</param>
public abstract record Symbol(ImmutableArray<ISymbolAnnotation> Annotations);
