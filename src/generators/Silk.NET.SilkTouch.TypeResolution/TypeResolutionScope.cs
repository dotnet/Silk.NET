// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// Used to track types and child scopes, used to resolve <see cref="UnresolvedTypeReference"/>
/// </summary>
/// <param name="ChildTypeScopes">Mapping of child types to their scopes</param>
public sealed record TypeResolutionScope(Dictionary<TypeId, TypeResolutionScope> ChildTypeScopes)
{
}
