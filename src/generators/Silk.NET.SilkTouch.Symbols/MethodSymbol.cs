// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="MemberSymbol"/> representing a method with a signature.
/// </summary>
public abstract record MethodSymbol(TypeReference ReturnType, ImmutableArray<TypeReference> Parameters, IdentifierSymbol Identifier) : MemberSymbol;
