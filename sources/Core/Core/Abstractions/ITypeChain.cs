// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Represents a visitable chain of arbitrary types. This can be used for extensible configuration structures.
/// </summary>
public interface ITypeChain
{
    /// <summary>
    /// Represents a type that visits a type chain.
    /// </summary>
    public interface Visitor
    {
        /// <summary>
        /// Visits the given type. If a recursive visit is desired (i.e. to visit the whole chain), check whether
        /// <typeparamref name="TType"/> is a <see cref="ITypeChain"/> and do this manually.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <typeparam name="TType">The type within the chain.</typeparam>
        /// <returns>A value indicating whether to continue with the visitation.</returns>
        bool Visit<TType>(TType value);
    }

    /// <summary>
    /// Visit all types at this level within the type chain until <see cref="Visitor.Visit{TType}"/> returns
    /// <c>false</c>.
    /// </summary>
    /// <param name="visitor">The visitor.</param>
    /// <typeparam name="TVisitor">The visitor type.</typeparam>
    /// <returns>A value indicating whether to continue with the visitation.</returns>
    bool Accept<TVisitor>(TVisitor visitor)
        where TVisitor : Visitor;
}
