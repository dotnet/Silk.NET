// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Vulkan;

/// <summary>
/// Base interface for any struct that has can set the next value.
/// </summary>
/// <remarks><para>Note that any structure marked <see cref="IChainable"/> must start with a
/// <see cref="StructureType"/> and a <c>void*</c> field, in that order. This is so that a pointer to it can be coerced
/// to a pointer to a <see cref="BaseInStructure"/>.</para></remarks>
public interface IChainable : IStructuredType
{
    /// <summary>
    /// Points to the next <see cref="IChainable"/> in this chain, if any; otherwise <see langword="null"/>.
    /// </summary>
    unsafe BaseInStructure* PNext { get; set; }
}
