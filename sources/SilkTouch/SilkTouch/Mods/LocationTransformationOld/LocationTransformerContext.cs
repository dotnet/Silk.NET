// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch.Mods.LocationTransformationOld;

/// <summary>
/// Additional information about the syntax node being processed.
/// </summary>
/// <param name="Symbol">The symbol used to find the node.</param>
/// <param name="IsDeclaration">Does the syntax node represent the declaration of the symbol?</param>
/// <param name="IsCandidateLocation">Does the syntax node represent a candidate location?</param>
public record struct LocationTransformerContext(ISymbol Symbol, bool IsDeclaration, bool IsCandidateLocation);
