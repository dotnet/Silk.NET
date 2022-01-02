// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Vulkan;

/// <summary>
/// Marks a <see cref="IChainable">chainable</see> struct indicating which <see cref="IChainStart">chain</see> this type
/// extends.
/// </summary>
/// <typeparam name="TChain">A chain start structure.</typeparam>
public interface IExtendsChain<out TChain> : IChainable
    where TChain : unmanaged, IChainable
{
}
