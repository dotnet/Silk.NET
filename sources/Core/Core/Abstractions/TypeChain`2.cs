// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// A chain type containing two types. This can be used to construct a full multilevel type chain by using this type for
/// one of the type parameters of this type.
/// </summary>
/// <param name="Item1">The first value in the chain.</param>
/// <param name="Item2">The second value in the chain.</param>
/// <typeparam name="T1">The type of the first value in the chain.</typeparam>
/// <typeparam name="T2">The type of the second value in the chain.</typeparam>
public readonly record struct TypeChain<T1, T2>(T1 Item1, T2 Item2) : ITypeChain
{
    /// <inheritdoc />
    public bool Accept<TVisitor>(TVisitor visitor)
        where TVisitor : ITypeChain.Visitor => visitor.Visit(Item1) && visitor.Visit(Item2);
}
