// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ReSharper disable StaticMemberInGenericType
#pragma warning disable CS0659, CS0660
using Silk.NET.Core.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Silk.NET.Vulkan;

/// <summary>
/// Base class for all <see cref="Chain{T}">Managed Chains</see>.
/// </summary>
public abstract unsafe partial class Chain
{
    /// <summary>
    /// Gets the maximum supported chain <see cref="Count"/>.
    /// </summary>
    public static readonly int MaximumCount = 16;

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <returns>A new <see cref="Chain{TChain}"/> with 1 items.</returns>
    /// <seealso cref="CreateAny{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> Create<TChain>(TChain head = default)
        where TChain : unmanaged,  IChainStart
        => new(head);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <returns>A new <see cref="Chain{TChain}"/> with 1 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> CreateAny<TChain>(TChain head = default)
        where TChain : unmanaged, IChainable
        => new(head);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain}"/> with 1 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain}"/> with 1 items.</returns>
    /// <seealso cref="LoadAny{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> Load<TChain>(TChain chain)
        where TChain : unmanaged,  IChainStart
        => LoadAny<TChain>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain}"/> with 1 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain}"/> with 1 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> LoadAny<TChain>(TChain chain)
        where TChain : unmanaged, IChainable
    {
        var size = Chain<TChain>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        return new Chain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain}"/> with 1 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain}"/> with 1 items.</returns>
    /// <seealso cref="LoadAny{TChain}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> Load<TChain>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        => LoadAny<TChain>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain}"/> with 1 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain}"/> with 1 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> LoadAny<TChain>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
    {
        var size = Chain<TChain>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        errors = string.Empty;
        return new Chain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1}(TChain, T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> Create<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        => new(head, item1);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1}(TChain, T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> CreateAny<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        => new(head, item1);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> Load<TChain, T1>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> LoadAny<TChain, T1>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> Load<TChain, T1>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> LoadAny<TChain, T1>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 2");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 2");
                    existingPtr->PNext = null;
                }
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2}(TChain, T1, T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2> Create<TChain, T1, T2>(TChain head = default, T1 item1 = default, T2 item2 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2}(TChain, T1, T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2> CreateAny<TChain, T1, T2>(TChain head = default, T1 item1 = default, T2 item2 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        => new(head, item1, item2);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2> Load<TChain, T1, T2>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2> LoadAny<TChain, T1, T2>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;
        return new Chain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2> Load<TChain, T1, T2>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2}"/> with 3 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2}"/> with 3 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2> LoadAny<TChain, T1, T2>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 3");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 3");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 3");
                    existingPtr->PNext = null;
                }
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3}(TChain, T1, T2, T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3> Create<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3}(TChain, T1, T2, T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3> CreateAny<TChain, T1, T2, T3>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        => new(head, item1, item2, item3);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3> Load<TChain, T1, T2, T3>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3> LoadAny<TChain, T1, T2, T3>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;
        return new Chain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3> Load<TChain, T1, T2, T3>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3> LoadAny<TChain, T1, T2, T3>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 4");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 4");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 4");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 4");
                    existingPtr->PNext = null;
                }
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4}(TChain, T1, T2, T3, T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4> Create<TChain, T1, T2, T3, T4>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4}(TChain, T1, T2, T3, T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4> CreateAny<TChain, T1, T2, T3, T4>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4> Load<TChain, T1, T2, T3, T4>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4> LoadAny<TChain, T1, T2, T3, T4>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;
        return new Chain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4> Load<TChain, T1, T2, T3, T4>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4> LoadAny<TChain, T1, T2, T3, T4>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 5");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 5");
                    existingPtr->PNext = null;
                }
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5}(TChain, T1, T2, T3, T4, T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5> Create<TChain, T1, T2, T3, T4, T5>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5}(TChain, T1, T2, T3, T4, T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5> CreateAny<TChain, T1, T2, T3, T4, T5>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5> Load<TChain, T1, T2, T3, T4, T5>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5> LoadAny<TChain, T1, T2, T3, T4, T5>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;
        return new Chain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5> Load<TChain, T1, T2, T3, T4, T5>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5> LoadAny<TChain, T1, T2, T3, T4, T5>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 6");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 6");
                    existingPtr->PNext = null;
                }
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6}(TChain, T1, T2, T3, T4, T5, T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6> Create<TChain, T1, T2, T3, T4, T5, T6>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6}(TChain, T1, T2, T3, T4, T5, T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6> CreateAny<TChain, T1, T2, T3, T4, T5, T6>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6> Load<TChain, T1, T2, T3, T4, T5, T6>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6> LoadAny<TChain, T1, T2, T3, T4, T5, T6>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6> Load<TChain, T1, T2, T3, T4, T5, T6>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6> LoadAny<TChain, T1, T2, T3, T4, T5, T6>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 7");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 7");
                    existingPtr->PNext = null;
                }
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain, T1, T2, T3, T4, T5, T6, T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Create<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain, T1, T2, T3, T4, T5, T6, T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Load<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Load<TChain, T1, T2, T3, T4, T5, T6, T7>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 8");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 8");
                    existingPtr->PNext = null;
                }
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain, T1, T2, T3, T4, T5, T6, T7, T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain, T1, T2, T3, T4, T5, T6, T7, T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 9");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 9");
                    existingPtr->PNext = null;
                }
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 10");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 10");
                    existingPtr->PNext = null;
                }
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item10 = Unsafe.AsRef<T10>(existingPtr);
        }
        *((T10*)newPtr) = item10;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 11");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 11");
                    existingPtr->PNext = null;
                }
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        *((T10*)newPtr) = item10;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item10 = Unsafe.AsRef<T10>(existingPtr);
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item11 = Unsafe.AsRef<T11>(existingPtr);
        }
        *((T11*)newPtr) = item11;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 12");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 12");
                    existingPtr->PNext = null;
                }
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        *((T11*)newPtr) = item11;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item10 = Unsafe.AsRef<T10>(existingPtr);
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item11 = Unsafe.AsRef<T11>(existingPtr);
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item12 = Unsafe.AsRef<T12>(existingPtr);
        }
        *((T12*)newPtr) = item12;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 13");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 13");
                    existingPtr->PNext = null;
                }
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        *((T12*)newPtr) = item12;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item10 = Unsafe.AsRef<T10>(existingPtr);
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item11 = Unsafe.AsRef<T11>(existingPtr);
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item12 = Unsafe.AsRef<T12>(existingPtr);
        }
        *((T12*)newPtr) = item12;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Offset);
        newPtr = newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item13 = Unsafe.AsRef<T13>(existingPtr);
        }
        *((T13*)newPtr) = item13;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        *((T12*)newPtr) = item12;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Offset);
        newPtr = newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 14");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 14");
                    existingPtr->PNext = null;
                }
                item13 = Unsafe.AsRef<T13>(existingPtr);
            }
        }
        *((T13*)newPtr) = item13;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        where T14 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        where T14 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        where T14 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        where T14 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item10 = Unsafe.AsRef<T10>(existingPtr);
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item11 = Unsafe.AsRef<T11>(existingPtr);
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item12 = Unsafe.AsRef<T12>(existingPtr);
        }
        *((T12*)newPtr) = item12;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset);
        newPtr = newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item13 = Unsafe.AsRef<T13>(existingPtr);
        }
        *((T13*)newPtr) = item13;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Offset);
        newPtr = newPtr->PNext;

        T14 item14 = default;
        expectedStructureType = item14.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item14 = Unsafe.AsRef<T14>(existingPtr);
        }
        *((T14*)newPtr) = item14;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        where T14 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        where T14 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        *((T12*)newPtr) = item12;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item13Offset);
        newPtr = newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item13 = Unsafe.AsRef<T13>(existingPtr);
            }
        }
        *((T13*)newPtr) = item13;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Offset);
        newPtr = newPtr->PNext;

        T14 item14 = default;
        expectedStructureType = item14.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 14, expected length 15");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 15; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 15");
                    existingPtr->PNext = null;
                }
                item14 = Unsafe.AsRef<T14>(existingPtr);
            }
        }
        *((T14*)newPtr) = item14;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <typeparam name="T15">Type of Item 15.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <seealso cref="CreateAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        where T14 : unmanaged, IExtendsChain<TChain>
        where T15 : unmanaged, IExtendsChain<TChain>
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <typeparam name="T2">Type of Item 2.</typeparam>
    /// <typeparam name="T3">Type of Item 3.</typeparam>
    /// <typeparam name="T4">Type of Item 4.</typeparam>
    /// <typeparam name="T5">Type of Item 5.</typeparam>
    /// <typeparam name="T6">Type of Item 6.</typeparam>
    /// <typeparam name="T7">Type of Item 7.</typeparam>
    /// <typeparam name="T8">Type of Item 8.</typeparam>
    /// <typeparam name="T9">Type of Item 9.</typeparam>
    /// <typeparam name="T10">Type of Item 10.</typeparam>
    /// <typeparam name="T11">Type of Item 11.</typeparam>
    /// <typeparam name="T12">Type of Item 12.</typeparam>
    /// <typeparam name="T13">Type of Item 13.</typeparam>
    /// <typeparam name="T14">Type of Item 14.</typeparam>
    /// <typeparam name="T15">Type of Item 15.</typeparam>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Create{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        where T14 : unmanaged,  IChainable
        where T15 : unmanaged,  IChainable
        => new(head, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        where T14 : unmanaged, IExtendsChain<TChain>
        where T15 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        where T14 : unmanaged,  IChainable
        where T15 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item1 = Unsafe.AsRef<T1>(existingPtr);
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item2 = Unsafe.AsRef<T2>(existingPtr);
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item3 = Unsafe.AsRef<T3>(existingPtr);
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item4 = Unsafe.AsRef<T4>(existingPtr);
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item5 = Unsafe.AsRef<T5>(existingPtr);
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item6 = Unsafe.AsRef<T6>(existingPtr);
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item7 = Unsafe.AsRef<T7>(existingPtr);
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item8 = Unsafe.AsRef<T8>(existingPtr);
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item9 = Unsafe.AsRef<T9>(existingPtr);
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item10 = Unsafe.AsRef<T10>(existingPtr);
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item11 = Unsafe.AsRef<T11>(existingPtr);
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item12 = Unsafe.AsRef<T12>(existingPtr);
        }
        *((T12*)newPtr) = item12;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset);
        newPtr = newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item13 = Unsafe.AsRef<T13>(existingPtr);
        }
        *((T13*)newPtr) = item13;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset);
        newPtr = newPtr->PNext;

        T14 item14 = default;
        expectedStructureType = item14.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            item14 = Unsafe.AsRef<T14>(existingPtr);
        }
        *((T14*)newPtr) = item14;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Offset);
        newPtr = newPtr->PNext;

        T15 item15 = default;
        expectedStructureType = item15.StructureType();
        if (existingPtr is not null &&
            existingPtr->SType == expectedStructureType) {
            if (existingPtr->PNext is not null) {
                existingPtr->PNext = null;
            }
            item15 = Unsafe.AsRef<T15>(existingPtr);
        }
        *((T15*)newPtr) = item15;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Load<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out string errors, TChain chain)
        where TChain : unmanaged,  IChainStart
        where T1 : unmanaged, IExtendsChain<TChain>
        where T2 : unmanaged, IExtendsChain<TChain>
        where T3 : unmanaged, IExtendsChain<TChain>
        where T4 : unmanaged, IExtendsChain<TChain>
        where T5 : unmanaged, IExtendsChain<TChain>
        where T6 : unmanaged, IExtendsChain<TChain>
        where T7 : unmanaged, IExtendsChain<TChain>
        where T8 : unmanaged, IExtendsChain<TChain>
        where T9 : unmanaged, IExtendsChain<TChain>
        where T10 : unmanaged, IExtendsChain<TChain>
        where T11 : unmanaged, IExtendsChain<TChain>
        where T12 : unmanaged, IExtendsChain<TChain>
        where T13 : unmanaged, IExtendsChain<TChain>
        where T14 : unmanaged, IExtendsChain<TChain>
        where T15 : unmanaged, IExtendsChain<TChain>
        => LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> LoadAny<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(out string errors, TChain chain)
        where TChain : unmanaged, IChainable
        where T1 : unmanaged,  IChainable
        where T2 : unmanaged,  IChainable
        where T3 : unmanaged,  IChainable
        where T4 : unmanaged,  IChainable
        where T5 : unmanaged,  IChainable
        where T6 : unmanaged,  IChainable
        where T7 : unmanaged,  IChainable
        where T8 : unmanaged,  IChainable
        where T9 : unmanaged,  IChainable
        where T10 : unmanaged,  IChainable
        where T11 : unmanaged,  IChainable
        where T12 : unmanaged,  IChainable
        where T13 : unmanaged,  IChainable
        where T14 : unmanaged,  IChainable
        where T15 : unmanaged,  IChainable
    {
        var size = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        chain.StructureType();
        *((TChain*)newHeadPtr) = chain;
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        *((T1*)newPtr) = item1;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item2Offset);
        newPtr = newPtr->PNext;

        T2 item2 = default;
        expectedStructureType = item2.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 2, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 3; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item2 = Unsafe.AsRef<T2>(existingPtr);
            }
        }
        *((T2*)newPtr) = item2;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item3Offset);
        newPtr = newPtr->PNext;

        T3 item3 = default;
        expectedStructureType = item3.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 3, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 4; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item3 = Unsafe.AsRef<T3>(existingPtr);
            }
        }
        *((T3*)newPtr) = item3;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item4Offset);
        newPtr = newPtr->PNext;

        T4 item4 = default;
        expectedStructureType = item4.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 4, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 5; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item4 = Unsafe.AsRef<T4>(existingPtr);
            }
        }
        *((T4*)newPtr) = item4;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item5Offset);
        newPtr = newPtr->PNext;

        T5 item5 = default;
        expectedStructureType = item5.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 5, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 6; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item5 = Unsafe.AsRef<T5>(existingPtr);
            }
        }
        *((T5*)newPtr) = item5;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item6Offset);
        newPtr = newPtr->PNext;

        T6 item6 = default;
        expectedStructureType = item6.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 6, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 7; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item6 = Unsafe.AsRef<T6>(existingPtr);
            }
        }
        *((T6*)newPtr) = item6;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item7Offset);
        newPtr = newPtr->PNext;

        T7 item7 = default;
        expectedStructureType = item7.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 7, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 8; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item7 = Unsafe.AsRef<T7>(existingPtr);
            }
        }
        *((T7*)newPtr) = item7;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item8Offset);
        newPtr = newPtr->PNext;

        T8 item8 = default;
        expectedStructureType = item8.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 8, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 9; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item8 = Unsafe.AsRef<T8>(existingPtr);
            }
        }
        *((T8*)newPtr) = item8;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item9Offset);
        newPtr = newPtr->PNext;

        T9 item9 = default;
        expectedStructureType = item9.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 9, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 10; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item9 = Unsafe.AsRef<T9>(existingPtr);
            }
        }
        *((T9*)newPtr) = item9;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item10Offset);
        newPtr = newPtr->PNext;

        T10 item10 = default;
        expectedStructureType = item10.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 10, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 11; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item10 = Unsafe.AsRef<T10>(existingPtr);
            }
        }
        *((T10*)newPtr) = item10;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item11Offset);
        newPtr = newPtr->PNext;

        T11 item11 = default;
        expectedStructureType = item11.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 11, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 12; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item11 = Unsafe.AsRef<T11>(existingPtr);
            }
        }
        *((T11*)newPtr) = item11;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item12Offset);
        newPtr = newPtr->PNext;

        T12 item12 = default;
        expectedStructureType = item12.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 12, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 13; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item12 = Unsafe.AsRef<T12>(existingPtr);
            }
        }
        *((T12*)newPtr) = item12;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item13Offset);
        newPtr = newPtr->PNext;

        T13 item13 = default;
        expectedStructureType = item13.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 13, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 14; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item13 = Unsafe.AsRef<T13>(existingPtr);
            }
        }
        *((T13*)newPtr) = item13;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item14Offset);
        newPtr = newPtr->PNext;

        T14 item14 = default;
        expectedStructureType = item14.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 14, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 15; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                item14 = Unsafe.AsRef<T14>(existingPtr);
            }
        }
        *((T14*)newPtr) = item14;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Offset);
        newPtr = newPtr->PNext;

        T15 item15 = default;
        expectedStructureType = item15.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 15, expected length 16");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 16; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 16");
                    existingPtr->PNext = null;
                }
                item15 = Unsafe.AsRef<T15>(existingPtr);
            }
        }
        *((T15*)newPtr) = item15;

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

}

/// <summary>
/// Represents a 1 element long structure chain.
/// </summary>
public interface IChain<TChain> : IDisposable, IReadOnlyList<IChainable>
{
    /// <summary>
    /// The first structure in the structure chain.
    /// </summary>
    TChain Head { get; set; }

    /// <summary>
    /// A reference to the first structure in the chain.
    /// </summary>
    ref TChain HeadRef { get; }
}

/// <summary>
/// A <see cref="Chain{TChain}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
public unsafe sealed class Chain<TChain> : Chain, IEquatable<Chain<TChain>>, IChain<TChain>
    where TChain : unmanaged, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = HeadSize;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    internal Chain(TChain head = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        HeadPtr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = null;
        }
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        return new Chain<TChain>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item1">The item to append.</param>    
    /// <typeparam name="T1">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T1}(T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1> Add<T1>(T1 item1 = default)
        where T1 : unmanaged, IExtendsChain<TChain>
        => AddAny(item1);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item1">The item to append.</param>
    /// <typeparam name="T1">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T1}(T1)" />
    public new Chain<TChain, T1> AddAny<T1>(T1 item1 = default)
        where T1 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 0
        item1.StructureType();
        *((T1*)(newHeadPtr + previousSize)) = item1;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => throw new InvalidOperationException("Cannot truncate chain of length 1.");

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
        => throw new InvalidOperationException("Cannot truncate chain of length 1.");

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
    }

    /// <inheritdoc />
    public override int Count => 1;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain> left, Chain<TChain> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain> left, Chain<TChain> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    public void Deconstruct(out TChain head)
    {
            head = Head;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 2 element long structure chain.
/// </summary>
public interface IChain<TChain, T1> : IChain<TChain>
{
    /// <summary>
    /// Structure no. 2 in the structure chain.
    /// </summary>
    T1 Item1 { get; set; }

    /// <summary>
    /// A reference to structure no. 2 in the structure chain.
    /// </summary>
    ref T1 Item1Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
public unsafe sealed class Chain<TChain, T1> : Chain, IEquatable<Chain<TChain, T1>>, IChain<TChain, T1>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item1Offset + Item1Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    internal Chain(TChain head = default, T1 item1 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        Item1Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item2">The item to append.</param>    
    /// <typeparam name="T2">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T2}(T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2> Add<T2>(T2 item2 = default)
        where T2 : unmanaged, IExtendsChain<TChain>
        => AddAny(item2);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item2">The item to append.</param>
    /// <typeparam name="T2">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T2}(T2)" />
    public new Chain<TChain, T1, T2> AddAny<T2>(T2 item2 = default)
        where T2 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 1
        item2.StructureType();
        *((T2*)(newHeadPtr + previousSize)) = item2;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2>.Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T1)" />
    /// <seealso cref="TruncateAny(out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T1)" />
    /// <seealso cref="TruncateAny(out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of this instance.
    /// </summary>
    /// <param name="item1">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain> Truncate(out T1 item1)
        => TruncateAny(out item1);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of this instance.
    /// </summary>
    /// <param name="item1">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T1)" />
    public Chain<TChain> TruncateAny(out T1 item1)
    {
        // Retrieve last item.
        item1 = Item1;

        var newSize = MemorySize - Item1Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = null;
        return new Chain<TChain>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
    }

    /// <inheritdoc />
    public override int Count => 2;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1> left, Chain<TChain, T1> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1> left, Chain<TChain, T1> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public void Deconstruct(out TChain head, out T1 item1)
    {
            head = Head;
            item1 = Item1;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 3 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2> : IChain<TChain, T1>
{
    /// <summary>
    /// Structure no. 3 in the structure chain.
    /// </summary>
    T2 Item2 { get; set; }

    /// <summary>
    /// A reference to structure no. 3 in the structure chain.
    /// </summary>
    ref T2 Item2Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2> : Chain, IEquatable<Chain<TChain, T1, T2>>, IChain<TChain, T1, T2>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item2Offset + Item2Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        Item2Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        return new Chain<TChain, T1, T2>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items, by appending <paramref name="item3"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item3">The item to append.</param>    
    /// <typeparam name="T3">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T3}(T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3> Add<T3>(T3 item3 = default)
        where T3 : unmanaged, IExtendsChain<TChain>
        => AddAny(item3);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items, by appending <paramref name="item3"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item3">The item to append.</param>
    /// <typeparam name="T3">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T3}(T3)" />
    public new Chain<TChain, T1, T2, T3> AddAny<T3>(T3 item3 = default)
        where T3 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 2
        item3.StructureType();
        *((T3*)(newHeadPtr + previousSize)) = item3;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3>.Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T2)" />
    /// <seealso cref="TruncateAny(out T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T2)" />
    /// <seealso cref="TruncateAny(out T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 2 items, by removing 
    /// <paramref name="item2"/> from the end of this instance.
    /// </summary>
    /// <param name="item2">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T2)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1> Truncate(out T2 item2)
        => TruncateAny(out item2);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by removing 
    /// <paramref name="item2"/> from the end of this instance.
    /// </summary>
    /// <param name="item2">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T2)" />
    public Chain<TChain, T1> TruncateAny(out T2 item2)
    {
        // Retrieve last item.
        item2 = Item2;

        var newSize = MemorySize - Item2Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = null; 
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
    }

    /// <inheritdoc />
    public override int Count => 3;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2> left, Chain<TChain, T1, T2> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2> left, Chain<TChain, T1, T2> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 4 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3> : IChain<TChain, T1, T2>
{
    /// <summary>
    /// Structure no. 4 in the structure chain.
    /// </summary>
    T3 Item3 { get; set; }

    /// <summary>
    /// A reference to structure no. 4 in the structure chain.
    /// </summary>
    ref T3 Item3Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3> : Chain, IEquatable<Chain<TChain, T1, T2, T3>>, IChain<TChain, T1, T2, T3>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item3Offset + Item3Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        Item3Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        return new Chain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending <paramref name="item4"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item4">The item to append.</param>    
    /// <typeparam name="T4">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T4}(T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4> Add<T4>(T4 item4 = default)
        where T4 : unmanaged, IExtendsChain<TChain>
        => AddAny(item4);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items, by appending <paramref name="item4"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item4">The item to append.</param>
    /// <typeparam name="T4">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T4}(T4)" />
    public new Chain<TChain, T1, T2, T3, T4> AddAny<T4>(T4 item4 = default)
        where T4 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 3
        item4.StructureType();
        *((T4*)(newHeadPtr + previousSize)) = item4;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4>.Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T3)" />
    /// <seealso cref="TruncateAny(out T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T3)" />
    /// <seealso cref="TruncateAny(out T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 3 items, by removing 
    /// <paramref name="item3"/> from the end of this instance.
    /// </summary>
    /// <param name="item3">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T3)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2> Truncate(out T3 item3)
        => TruncateAny(out item3);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2}"/> with 3 items, by removing 
    /// <paramref name="item3"/> from the end of this instance.
    /// </summary>
    /// <param name="item3">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T3)" />
    public Chain<TChain, T1, T2> TruncateAny(out T3 item3)
    {
        // Retrieve last item.
        item3 = Item3;

        var newSize = MemorySize - Item3Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = null; 
        return new Chain<TChain, T1, T2>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
    }

    /// <inheritdoc />
    public override int Count => 4;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3> left, Chain<TChain, T1, T2, T3> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3> left, Chain<TChain, T1, T2, T3> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 5 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4> : IChain<TChain, T1, T2, T3>
{
    /// <summary>
    /// Structure no. 5 in the structure chain.
    /// </summary>
    T4 Item4 { get; set; }

    /// <summary>
    /// A reference to structure no. 5 in the structure chain.
    /// </summary>
    ref T4 Item4Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4>>, IChain<TChain, T1, T2, T3, T4>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item4Offset + Item4Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        Item4Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        return new Chain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending <paramref name="item5"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item5">The item to append.</param>    
    /// <typeparam name="T5">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T5}(T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5> Add<T5>(T5 item5 = default)
        where T5 : unmanaged, IExtendsChain<TChain>
        => AddAny(item5);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by appending <paramref name="item5"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item5">The item to append.</param>
    /// <typeparam name="T5">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T5}(T5)" />
    public new Chain<TChain, T1, T2, T3, T4, T5> AddAny<T5>(T5 item5 = default)
        where T5 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 4
        item5.StructureType();
        *((T5*)(newHeadPtr + previousSize)) = item5;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5>.Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T4)" />
    /// <seealso cref="TruncateAny(out T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T4)" />
    /// <seealso cref="TruncateAny(out T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 4 items, by removing 
    /// <paramref name="item4"/> from the end of this instance.
    /// </summary>
    /// <param name="item4">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T4)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3> Truncate(out T4 item4)
        => TruncateAny(out item4);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3}"/> with 4 items, by removing 
    /// <paramref name="item4"/> from the end of this instance.
    /// </summary>
    /// <param name="item4">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T4)" />
    public Chain<TChain, T1, T2, T3> TruncateAny(out T4 item4)
    {
        // Retrieve last item.
        item4 = Item4;

        var newSize = MemorySize - Item4Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
    }

    /// <inheritdoc />
    public override int Count => 5;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4> left, Chain<TChain, T1, T2, T3, T4> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4> left, Chain<TChain, T1, T2, T3, T4> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 6 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5> : IChain<TChain, T1, T2, T3, T4>
{
    /// <summary>
    /// Structure no. 6 in the structure chain.
    /// </summary>
    T5 Item5 { get; set; }

    /// <summary>
    /// A reference to structure no. 6 in the structure chain.
    /// </summary>
    ref T5 Item5Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5>>, IChain<TChain, T1, T2, T3, T4, T5>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item5Offset + Item5Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        Item5Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending <paramref name="item6"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item6">The item to append.</param>    
    /// <typeparam name="T6">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T6}(T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6> Add<T6>(T6 item6 = default)
        where T6 : unmanaged, IExtendsChain<TChain>
        => AddAny(item6);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by appending <paramref name="item6"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item6">The item to append.</param>
    /// <typeparam name="T6">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T6}(T6)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6> AddAny<T6>(T6 item6 = default)
        where T6 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 5
        item6.StructureType();
        *((T6*)(newHeadPtr + previousSize)) = item6;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6>.Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T5)" />
    /// <seealso cref="TruncateAny(out T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T5)" />
    /// <seealso cref="TruncateAny(out T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 5 items, by removing 
    /// <paramref name="item5"/> from the end of this instance.
    /// </summary>
    /// <param name="item5">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T5)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4> Truncate(out T5 item5)
        => TruncateAny(out item5);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4}"/> with 5 items, by removing 
    /// <paramref name="item5"/> from the end of this instance.
    /// </summary>
    /// <param name="item5">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T5)" />
    public Chain<TChain, T1, T2, T3, T4> TruncateAny(out T5 item5)
    {
        // Retrieve last item.
        item5 = Item5;

        var newSize = MemorySize - Item5Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
    }

    /// <inheritdoc />
    public override int Count => 6;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5> left, Chain<TChain, T1, T2, T3, T4, T5> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5> left, Chain<TChain, T1, T2, T3, T4, T5> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 7 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6> : IChain<TChain, T1, T2, T3, T4, T5>
{
    /// <summary>
    /// Structure no. 7 in the structure chain.
    /// </summary>
    T6 Item6 { get; set; }

    /// <summary>
    /// A reference to structure no. 7 in the structure chain.
    /// </summary>
    ref T6 Item6Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6>>, IChain<TChain, T1, T2, T3, T4, T5, T6>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item6Offset + Item6Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        Item6Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending <paramref name="item7"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item7">The item to append.</param>    
    /// <typeparam name="T7">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T7}(T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Add<T7>(T7 item7 = default)
        where T7 : unmanaged, IExtendsChain<TChain>
        => AddAny(item7);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by appending <paramref name="item7"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item7">The item to append.</param>
    /// <typeparam name="T7">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T7}(T7)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7> AddAny<T7>(T7 item7 = default)
        where T7 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 6
        item7.StructureType();
        *((T7*)(newHeadPtr + previousSize)) = item7;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7>.Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T6)" />
    /// <seealso cref="TruncateAny(out T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T6)" />
    /// <seealso cref="TruncateAny(out T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 6 items, by removing 
    /// <paramref name="item6"/> from the end of this instance.
    /// </summary>
    /// <param name="item6">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T6)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5> Truncate(out T6 item6)
        => TruncateAny(out item6);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5}"/> with 6 items, by removing 
    /// <paramref name="item6"/> from the end of this instance.
    /// </summary>
    /// <param name="item6">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T6)" />
    public Chain<TChain, T1, T2, T3, T4, T5> TruncateAny(out T6 item6)
    {
        // Retrieve last item.
        item6 = Item6;

        var newSize = MemorySize - Item6Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
    }

    /// <inheritdoc />
    public override int Count => 7;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6> left, Chain<TChain, T1, T2, T3, T4, T5, T6> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6> left, Chain<TChain, T1, T2, T3, T4, T5, T6> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 8 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7> : IChain<TChain, T1, T2, T3, T4, T5, T6>
{
    /// <summary>
    /// Structure no. 8 in the structure chain.
    /// </summary>
    T7 Item7 { get; set; }

    /// <summary>
    /// A reference to structure no. 8 in the structure chain.
    /// </summary>
    ref T7 Item7Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item7Offset + Item7Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        Item7Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending <paramref name="item8"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item8">The item to append.</param>    
    /// <typeparam name="T8">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T8}(T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Add<T8>(T8 item8 = default)
        where T8 : unmanaged, IExtendsChain<TChain>
        => AddAny(item8);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by appending <paramref name="item8"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item8">The item to append.</param>
    /// <typeparam name="T8">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T8}(T8)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> AddAny<T8>(T8 item8 = default)
        where T8 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 7
        item8.StructureType();
        *((T8*)(newHeadPtr + previousSize)) = item8;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>.Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T7)" />
    /// <seealso cref="TruncateAny(out T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T7)" />
    /// <seealso cref="TruncateAny(out T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 7 items, by removing 
    /// <paramref name="item7"/> from the end of this instance.
    /// </summary>
    /// <param name="item7">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T7)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6> Truncate(out T7 item7)
        => TruncateAny(out item7);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6}"/> with 7 items, by removing 
    /// <paramref name="item7"/> from the end of this instance.
    /// </summary>
    /// <param name="item7">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T7)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6> TruncateAny(out T7 item7)
    {
        // Retrieve last item.
        item7 = Item7;

        var newSize = MemorySize - Item7Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
    }

    /// <inheritdoc />
    public override int Count => 8;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 9 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7>
{
    /// <summary>
    /// Structure no. 9 in the structure chain.
    /// </summary>
    T8 Item8 { get; set; }

    /// <summary>
    /// A reference to structure no. 9 in the structure chain.
    /// </summary>
    ref T8 Item8Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item8Offset + Item8Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        Item8Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending <paramref name="item9"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item9">The item to append.</param>    
    /// <typeparam name="T9">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T9}(T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Add<T9>(T9 item9 = default)
        where T9 : unmanaged, IExtendsChain<TChain>
        => AddAny(item9);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by appending <paramref name="item9"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item9">The item to append.</param>
    /// <typeparam name="T9">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T9}(T9)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> AddAny<T9>(T9 item9 = default)
        where T9 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 8
        item9.StructureType();
        *((T9*)(newHeadPtr + previousSize)) = item9;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T8)" />
    /// <seealso cref="TruncateAny(out T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T8)" />
    /// <seealso cref="TruncateAny(out T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 8 items, by removing 
    /// <paramref name="item8"/> from the end of this instance.
    /// </summary>
    /// <param name="item8">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T8)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7> Truncate(out T8 item8)
        => TruncateAny(out item8);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7}"/> with 8 items, by removing 
    /// <paramref name="item8"/> from the end of this instance.
    /// </summary>
    /// <param name="item8">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T8)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7> TruncateAny(out T8 item8)
    {
        // Retrieve last item.
        item8 = Item8;

        var newSize = MemorySize - Item8Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
    }

    /// <inheritdoc />
    public override int Count => 9;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 10 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>
{
    /// <summary>
    /// Structure no. 10 in the structure chain.
    /// </summary>
    T9 Item9 { get; set; }

    /// <summary>
    /// A reference to structure no. 10 in the structure chain.
    /// </summary>
    ref T9 Item9Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item9Offset + Item9Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        Item9Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending <paramref name="item10"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item10">The item to append.</param>    
    /// <typeparam name="T10">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T10}(T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Add<T10>(T10 item10 = default)
        where T10 : unmanaged, IExtendsChain<TChain>
        => AddAny(item10);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by appending <paramref name="item10"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item10">The item to append.</param>
    /// <typeparam name="T10">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T10}(T10)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> AddAny<T10>(T10 item10 = default)
        where T10 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 9
        item10.StructureType();
        *((T10*)(newHeadPtr + previousSize)) = item10;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T9)" />
    /// <seealso cref="TruncateAny(out T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T9)" />
    /// <seealso cref="TruncateAny(out T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 9 items, by removing 
    /// <paramref name="item9"/> from the end of this instance.
    /// </summary>
    /// <param name="item9">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T9)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> Truncate(out T9 item9)
        => TruncateAny(out item9);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8}"/> with 9 items, by removing 
    /// <paramref name="item9"/> from the end of this instance.
    /// </summary>
    /// <param name="item9">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T9)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8> TruncateAny(out T9 item9)
    {
        // Retrieve last item.
        item9 = Item9;

        var newSize = MemorySize - Item9Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
    }

    /// <inheritdoc />
    public override int Count => 10;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 11 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
    /// <summary>
    /// Structure no. 11 in the structure chain.
    /// </summary>
    T10 Item10 { get; set; }

    /// <summary>
    /// A reference to structure no. 11 in the structure chain.
    /// </summary>
    ref T10 Item10Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
    where T10 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = sizeof(T10);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item10Offset + Item10Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            *((T10*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T10 Item10Ref => ref Unsafe.AsRef<T10>(Item10Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        *((T10*)itemPtr) = item10;
        Item9Ptr->PNext = itemPtr;
        Item10Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = Item10Ptr;
        var item10 = default(T10);
        item10.StructureType();
        *((T10*)Item10Ptr) = item10;
        Item10Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending <paramref name="item11"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item11">The item to append.</param>    
    /// <typeparam name="T11">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T11}(T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Add<T11>(T11 item11 = default)
        where T11 : unmanaged, IExtendsChain<TChain>
        => AddAny(item11);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by appending <paramref name="item11"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item11">The item to append.</param>
    /// <typeparam name="T11">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T11}(T11)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> AddAny<T11>(T11 item11 = default)
        where T11 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 10
        item11.StructureType();
        *((T11*)(newHeadPtr + previousSize)) = item11;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T10)" />
    /// <seealso cref="TruncateAny(out T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T10)" />
    /// <seealso cref="TruncateAny(out T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 10 items, by removing 
    /// <paramref name="item10"/> from the end of this instance.
    /// </summary>
    /// <param name="item10">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T10)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> Truncate(out T10 item10)
        => TruncateAny(out item10);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9}"/> with 10 items, by removing 
    /// <paramref name="item10"/> from the end of this instance.
    /// </summary>
    /// <param name="item10">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T10)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9> TruncateAny(out T10 item10)
    {
        // Retrieve last item.
        item10 = Item10;

        var newSize = MemorySize - Item10Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
    }

    /// <inheritdoc />
    public override int Count => 11;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 12 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
{
    /// <summary>
    /// Structure no. 12 in the structure chain.
    /// </summary>
    T11 Item11 { get; set; }

    /// <summary>
    /// A reference to structure no. 12 in the structure chain.
    /// </summary>
    ref T11 Item11Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
    where T10 : unmanaged,  IChainable
    where T11 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = sizeof(T10);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = sizeof(T11);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item11Offset + Item11Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            *((T10*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T10 Item10Ref => ref Unsafe.AsRef<T10>(Item10Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            *((T11*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T11 Item11Ref => ref Unsafe.AsRef<T11>(Item11Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        *((T10*)itemPtr) = item10;
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        *((T11*)itemPtr) = item11;
        Item10Ptr->PNext = itemPtr;
        Item11Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = Item10Ptr;
        var item10 = default(T10);
        item10.StructureType();
        *((T10*)Item10Ptr) = item10;
        Item10Ptr->PNext = Item11Ptr;
        var item11 = default(T11);
        item11.StructureType();
        *((T11*)Item11Ptr) = item11;
        Item11Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending <paramref name="item12"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item12">The item to append.</param>    
    /// <typeparam name="T12">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T12}(T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Add<T12>(T12 item12 = default)
        where T12 : unmanaged, IExtendsChain<TChain>
        => AddAny(item12);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by appending <paramref name="item12"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item12">The item to append.</param>
    /// <typeparam name="T12">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T12}(T12)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> AddAny<T12>(T12 item12 = default)
        where T12 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 11
        item12.StructureType();
        *((T12*)(newHeadPtr + previousSize)) = item12;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T11)" />
    /// <seealso cref="TruncateAny(out T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T11)" />
    /// <seealso cref="TruncateAny(out T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 11 items, by removing 
    /// <paramref name="item11"/> from the end of this instance.
    /// </summary>
    /// <param name="item11">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T11)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Truncate(out T11 item11)
        => TruncateAny(out item11);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10}"/> with 11 items, by removing 
    /// <paramref name="item11"/> from the end of this instance.
    /// </summary>
    /// <param name="item11">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T11)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> TruncateAny(out T11 item11)
    {
        // Retrieve last item.
        item11 = Item11;

        var newSize = MemorySize - Item11Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
    }

    /// <inheritdoc />
    public override int Count => 12;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 13 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
{
    /// <summary>
    /// Structure no. 13 in the structure chain.
    /// </summary>
    T12 Item12 { get; set; }

    /// <summary>
    /// A reference to structure no. 13 in the structure chain.
    /// </summary>
    ref T12 Item12Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
    where T10 : unmanaged,  IChainable
    where T11 : unmanaged,  IChainable
    where T12 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = sizeof(T10);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = sizeof(T11);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = sizeof(T12);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item12Offset + Item12Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            *((T10*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T10 Item10Ref => ref Unsafe.AsRef<T10>(Item10Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            *((T11*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T11 Item11Ref => ref Unsafe.AsRef<T11>(Item11Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            *((T12*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T12 Item12Ref => ref Unsafe.AsRef<T12>(Item12Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        *((T10*)itemPtr) = item10;
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        *((T11*)itemPtr) = item11;
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        *((T12*)itemPtr) = item12;
        Item11Ptr->PNext = itemPtr;
        Item12Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = Item10Ptr;
        var item10 = default(T10);
        item10.StructureType();
        *((T10*)Item10Ptr) = item10;
        Item10Ptr->PNext = Item11Ptr;
        var item11 = default(T11);
        item11.StructureType();
        *((T11*)Item11Ptr) = item11;
        Item11Ptr->PNext = Item12Ptr;
        var item12 = default(T12);
        item12.StructureType();
        *((T12*)Item12Ptr) = item12;
        Item12Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending <paramref name="item13"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item13">The item to append.</param>    
    /// <typeparam name="T13">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T13}(T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Add<T13>(T13 item13 = default)
        where T13 : unmanaged, IExtendsChain<TChain>
        => AddAny(item13);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by appending <paramref name="item13"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item13">The item to append.</param>
    /// <typeparam name="T13">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T13}(T13)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> AddAny<T13>(T13 item13 = default)
        where T13 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 12
        item13.StructureType();
        *((T13*)(newHeadPtr + previousSize)) = item13;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T12)" />
    /// <seealso cref="TruncateAny(out T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T12)" />
    /// <seealso cref="TruncateAny(out T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 12 items, by removing 
    /// <paramref name="item12"/> from the end of this instance.
    /// </summary>
    /// <param name="item12">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T12)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Truncate(out T12 item12)
        => TruncateAny(out item12);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11}"/> with 12 items, by removing 
    /// <paramref name="item12"/> from the end of this instance.
    /// </summary>
    /// <param name="item12">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T12)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> TruncateAny(out T12 item12)
    {
        // Retrieve last item.
        item12 = Item12;

        var newSize = MemorySize - Item12Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
    }

    /// <inheritdoc />
    public override int Count => 13;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 14 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
{
    /// <summary>
    /// Structure no. 14 in the structure chain.
    /// </summary>
    T13 Item13 { get; set; }

    /// <summary>
    /// A reference to structure no. 14 in the structure chain.
    /// </summary>
    ref T13 Item13Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
    where T10 : unmanaged,  IChainable
    where T11 : unmanaged,  IChainable
    where T12 : unmanaged,  IChainable
    where T13 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = sizeof(T10);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = sizeof(T11);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = sizeof(T12);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item13Offset = Item12Offset + Item12Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item13Size = sizeof(T13);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item13Offset + Item13Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            *((T10*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T10 Item10Ref => ref Unsafe.AsRef<T10>(Item10Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            *((T11*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T11 Item11Ref => ref Unsafe.AsRef<T11>(Item11Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            *((T12*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T12 Item12Ref => ref Unsafe.AsRef<T12>(Item12Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item13Ptr => (BaseInStructure*) (_headPtr + Item13Offset);

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>(Item13Ptr);
        set
        {
            value.StructureType();
            var ptr = Item13Ptr;
            var nextPtr = ptr->PNext;
            *((T13*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T13 Item13Ref => ref Unsafe.AsRef<T13>(Item13Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        *((T10*)itemPtr) = item10;
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        *((T11*)itemPtr) = item11;
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        *((T12*)itemPtr) = item12;
        Item11Ptr->PNext = itemPtr;
        itemPtr = Item13Ptr;
        item13.StructureType();
        *((T13*)itemPtr) = item13;
        Item12Ptr->PNext = itemPtr;
        Item13Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = Item10Ptr;
        var item10 = default(T10);
        item10.StructureType();
        *((T10*)Item10Ptr) = item10;
        Item10Ptr->PNext = Item11Ptr;
        var item11 = default(T11);
        item11.StructureType();
        *((T11*)Item11Ptr) = item11;
        Item11Ptr->PNext = Item12Ptr;
        var item12 = default(T12);
        item12.StructureType();
        *((T12*)Item12Ptr) = item12;
        Item12Ptr->PNext = Item13Ptr;
        var item13 = default(T13);
        item13.StructureType();
        *((T13*)Item13Ptr) = item13;
        Item13Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => AddAny<T>(item);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending <paramref name="item14"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item14">The item to append.</param>    
    /// <typeparam name="T14">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T14}(T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Add<T14>(T14 item14 = default)
        where T14 : unmanaged, IExtendsChain<TChain>
        => AddAny(item14);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by appending <paramref name="item14"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item14">The item to append.</param>
    /// <typeparam name="T14">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T14}(T14)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> AddAny<T14>(T14 item14 = default)
        where T14 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 13
        item14.StructureType();
        *((T14*)(newHeadPtr + previousSize)) = item14;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T13)" />
    /// <seealso cref="TruncateAny(out T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T13)" />
    /// <seealso cref="TruncateAny(out T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 13 items, by removing 
    /// <paramref name="item13"/> from the end of this instance.
    /// </summary>
    /// <param name="item13">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T13)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Truncate(out T13 item13)
        => TruncateAny(out item13);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12}"/> with 13 items, by removing 
    /// <paramref name="item13"/> from the end of this instance.
    /// </summary>
    /// <param name="item13">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T13)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> TruncateAny(out T13 item13)
    {
        // Retrieve last item.
        item13 = Item13;

        var newSize = MemorySize - Item13Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
        yield return Item13;
    }

    /// <inheritdoc />
    public override int Count => 14;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            13 => Item13,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(", ");
        sb.Append((object) Item13);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
            item13 = Item13;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 15 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
{
    /// <summary>
    /// Structure no. 15 in the structure chain.
    /// </summary>
    T14 Item14 { get; set; }

    /// <summary>
    /// A reference to structure no. 15 in the structure chain.
    /// </summary>
    ref T14 Item14Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
/// <typeparam name="T14">Type of Item 14.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
    where T10 : unmanaged,  IChainable
    where T11 : unmanaged,  IChainable
    where T12 : unmanaged,  IChainable
    where T13 : unmanaged,  IChainable
    where T14 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = sizeof(T10);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = sizeof(T11);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = sizeof(T12);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item13Offset = Item12Offset + Item12Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item13Size = sizeof(T13);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item14Offset = Item13Offset + Item13Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item14Size = sizeof(T14);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item14Offset + Item14Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            *((T10*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T10 Item10Ref => ref Unsafe.AsRef<T10>(Item10Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            *((T11*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T11 Item11Ref => ref Unsafe.AsRef<T11>(Item11Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            *((T12*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T12 Item12Ref => ref Unsafe.AsRef<T12>(Item12Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item13Ptr => (BaseInStructure*) (_headPtr + Item13Offset);

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>(Item13Ptr);
        set
        {
            value.StructureType();
            var ptr = Item13Ptr;
            var nextPtr = ptr->PNext;
            *((T13*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T13 Item13Ref => ref Unsafe.AsRef<T13>(Item13Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item14Ptr => (BaseInStructure*) (_headPtr + Item14Offset);

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>(Item14Ptr);
        set
        {
            value.StructureType();
            var ptr = Item14Ptr;
            var nextPtr = ptr->PNext;
            *((T14*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T14 Item14Ref => ref Unsafe.AsRef<T14>(Item14Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        *((T10*)itemPtr) = item10;
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        *((T11*)itemPtr) = item11;
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        *((T12*)itemPtr) = item12;
        Item11Ptr->PNext = itemPtr;
        itemPtr = Item13Ptr;
        item13.StructureType();
        *((T13*)itemPtr) = item13;
        Item12Ptr->PNext = itemPtr;
        itemPtr = Item14Ptr;
        item14.StructureType();
        *((T14*)itemPtr) = item14;
        Item13Ptr->PNext = itemPtr;
        Item14Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = Item10Ptr;
        var item10 = default(T10);
        item10.StructureType();
        *((T10*)Item10Ptr) = item10;
        Item10Ptr->PNext = Item11Ptr;
        var item11 = default(T11);
        item11.StructureType();
        *((T11*)Item11Ptr) = item11;
        Item11Ptr->PNext = Item12Ptr;
        var item12 = default(T12);
        item12.StructureType();
        *((T12*)Item12Ptr) = item12;
        Item12Ptr->PNext = Item13Ptr;
        var item13 = default(T13);
        item13.StructureType();
        *((T13*)Item13Ptr) = item13;
        Item13Ptr->PNext = Item14Ptr;
        var item14 = default(T14);
        item14.StructureType();
        *((T14*)Item14Ptr) = item14;
        Item14Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => throw new InvalidOperationException("Cannot add to chain of length 15.");

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending <paramref name="item15"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item15">The item to append.</param>    
    /// <typeparam name="T15">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{T15}(T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Add<T15>(T15 item15 = default)
        where T15 : unmanaged, IExtendsChain<TChain>
        => AddAny(item15);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by appending <paramref name="item15"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item15">The item to append.</param>
    /// <typeparam name="T15">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{T15}(T15)" />
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> AddAny<T15>(T15 item15 = default)
        where T15 : unmanaged, IChainable
    {
        var previousSize = MemorySize;
        var newSize = Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 14
        item15.StructureType();
        *((T15*)(newHeadPtr + previousSize)) = item15;

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + Item14Offset))->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Item15Offset); 
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T14)" />
    /// <seealso cref="TruncateAny(out T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T14)" />
    /// <seealso cref="TruncateAny(out T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 14 items, by removing 
    /// <paramref name="item14"/> from the end of this instance.
    /// </summary>
    /// <param name="item14">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T14)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Truncate(out T14 item14)
        => TruncateAny(out item14);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13}"/> with 14 items, by removing 
    /// <paramref name="item14"/> from the end of this instance.
    /// </summary>
    /// <param name="item14">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T14)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> TruncateAny(out T14 item14)
    {
        // Retrieve last item.
        item14 = Item14;

        var newSize = MemorySize - Item14Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
        yield return Item13;
        yield return Item14;
    }

    /// <inheritdoc />
    public override int Count => 15;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            13 => Item13,
            14 => Item14,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(", ");
        sb.Append((object) Item13);
        sb.Append(", ");
        sb.Append((object) Item14);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
            item13 = Item13;
            item14 = Item14;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> chain) => (TChain*)chain._headPtr;
}

/// <summary>
/// Represents a 16 element long structure chain.
/// </summary>
public interface IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
{
    /// <summary>
    /// Structure no. 16 in the structure chain.
    /// </summary>
    T15 Item15 { get; set; }

    /// <summary>
    /// A reference to structure no. 16 in the structure chain.
    /// </summary>
    ref T15 Item15Ref { get; }
}

/// <summary>
/// A <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <typeparam name="T2">Type of Item 2.</typeparam>
/// <typeparam name="T3">Type of Item 3.</typeparam>
/// <typeparam name="T4">Type of Item 4.</typeparam>
/// <typeparam name="T5">Type of Item 5.</typeparam>
/// <typeparam name="T6">Type of Item 6.</typeparam>
/// <typeparam name="T7">Type of Item 7.</typeparam>
/// <typeparam name="T8">Type of Item 8.</typeparam>
/// <typeparam name="T9">Type of Item 9.</typeparam>
/// <typeparam name="T10">Type of Item 10.</typeparam>
/// <typeparam name="T11">Type of Item 11.</typeparam>
/// <typeparam name="T12">Type of Item 12.</typeparam>
/// <typeparam name="T13">Type of Item 13.</typeparam>
/// <typeparam name="T14">Type of Item 14.</typeparam>
/// <typeparam name="T15">Type of Item 15.</typeparam>
public unsafe sealed class Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : Chain, IEquatable<Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, IChain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable
    where T3 : unmanaged,  IChainable
    where T4 : unmanaged,  IChainable
    where T5 : unmanaged,  IChainable
    where T6 : unmanaged,  IChainable
    where T7 : unmanaged,  IChainable
    where T8 : unmanaged,  IChainable
    where T9 : unmanaged,  IChainable
    where T10 : unmanaged,  IChainable
    where T11 : unmanaged,  IChainable
    where T12 : unmanaged,  IChainable
    where T13 : unmanaged,  IChainable
    where T14 : unmanaged,  IChainable
    where T15 : unmanaged,  IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = sizeof(BaseInStructure);

    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = sizeof(TChain);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = sizeof(T1);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item2Offset = Item1Offset + Item1Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item2Size = sizeof(T2);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item3Offset = Item2Offset + Item2Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item3Size = sizeof(T3);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item4Offset = Item3Offset + Item3Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item4Size = sizeof(T4);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item5Offset = Item4Offset + Item4Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item5Size = sizeof(T5);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item6Offset = Item5Offset + Item5Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item6Size = sizeof(T6);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item7Offset = Item6Offset + Item6Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item7Size = sizeof(T7);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item8Offset = Item7Offset + Item7Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item8Size = sizeof(T8);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item9Offset = Item8Offset + Item8Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item9Size = sizeof(T9);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item10Offset = Item9Offset + Item9Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item10Size = sizeof(T10);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item11Offset = Item10Offset + Item10Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item11Size = sizeof(T11);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item12Offset = Item11Offset + Item11Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item12Size = sizeof(T12);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item13Offset = Item12Offset + Item12Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item13Size = sizeof(T13);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item14Offset = Item13Offset + Item13Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item14Size = sizeof(T14);

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item15Offset = Item14Offset + Item14Size;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item15Size = sizeof(T15);

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item15Offset + Item15Size;
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            *((TChain*)_headPtr) = value;
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a reference to the head of the chain.
    /// </summary>
    public ref TChain HeadRef => ref Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            *((T1*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T1 Item1Ref => ref Unsafe.AsRef<T1>(Item1Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item2Ptr => (BaseInStructure*) (_headPtr + Item2Offset);

    /// <summary>
    /// Gets or sets item #2 in the chain.
    /// </summary>
    public T2 Item2
    {
        get => Unsafe.AsRef<T2>(Item2Ptr);
        set
        {
            value.StructureType();
            var ptr = Item2Ptr;
            var nextPtr = ptr->PNext;
            *((T2*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T2 Item2Ref => ref Unsafe.AsRef<T2>(Item2Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item3Ptr => (BaseInStructure*) (_headPtr + Item3Offset);

    /// <summary>
    /// Gets or sets item #3 in the chain.
    /// </summary>
    public T3 Item3
    {
        get => Unsafe.AsRef<T3>(Item3Ptr);
        set
        {
            value.StructureType();
            var ptr = Item3Ptr;
            var nextPtr = ptr->PNext;
            *((T3*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T3 Item3Ref => ref Unsafe.AsRef<T3>(Item3Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item4Ptr => (BaseInStructure*) (_headPtr + Item4Offset);

    /// <summary>
    /// Gets or sets item #4 in the chain.
    /// </summary>
    public T4 Item4
    {
        get => Unsafe.AsRef<T4>(Item4Ptr);
        set
        {
            value.StructureType();
            var ptr = Item4Ptr;
            var nextPtr = ptr->PNext;
            *((T4*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T4 Item4Ref => ref Unsafe.AsRef<T4>(Item4Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item5Ptr => (BaseInStructure*) (_headPtr + Item5Offset);

    /// <summary>
    /// Gets or sets item #5 in the chain.
    /// </summary>
    public T5 Item5
    {
        get => Unsafe.AsRef<T5>(Item5Ptr);
        set
        {
            value.StructureType();
            var ptr = Item5Ptr;
            var nextPtr = ptr->PNext;
            *((T5*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T5 Item5Ref => ref Unsafe.AsRef<T5>(Item5Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item6Ptr => (BaseInStructure*) (_headPtr + Item6Offset);

    /// <summary>
    /// Gets or sets item #6 in the chain.
    /// </summary>
    public T6 Item6
    {
        get => Unsafe.AsRef<T6>(Item6Ptr);
        set
        {
            value.StructureType();
            var ptr = Item6Ptr;
            var nextPtr = ptr->PNext;
            *((T6*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T6 Item6Ref => ref Unsafe.AsRef<T6>(Item6Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item7Ptr => (BaseInStructure*) (_headPtr + Item7Offset);

    /// <summary>
    /// Gets or sets item #7 in the chain.
    /// </summary>
    public T7 Item7
    {
        get => Unsafe.AsRef<T7>(Item7Ptr);
        set
        {
            value.StructureType();
            var ptr = Item7Ptr;
            var nextPtr = ptr->PNext;
            *((T7*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T7 Item7Ref => ref Unsafe.AsRef<T7>(Item7Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item8Ptr => (BaseInStructure*) (_headPtr + Item8Offset);

    /// <summary>
    /// Gets or sets item #8 in the chain.
    /// </summary>
    public T8 Item8
    {
        get => Unsafe.AsRef<T8>(Item8Ptr);
        set
        {
            value.StructureType();
            var ptr = Item8Ptr;
            var nextPtr = ptr->PNext;
            *((T8*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T8 Item8Ref => ref Unsafe.AsRef<T8>(Item8Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item9Ptr => (BaseInStructure*) (_headPtr + Item9Offset);

    /// <summary>
    /// Gets or sets item #9 in the chain.
    /// </summary>
    public T9 Item9
    {
        get => Unsafe.AsRef<T9>(Item9Ptr);
        set
        {
            value.StructureType();
            var ptr = Item9Ptr;
            var nextPtr = ptr->PNext;
            *((T9*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T9 Item9Ref => ref Unsafe.AsRef<T9>(Item9Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item10Ptr => (BaseInStructure*) (_headPtr + Item10Offset);

    /// <summary>
    /// Gets or sets item #10 in the chain.
    /// </summary>
    public T10 Item10
    {
        get => Unsafe.AsRef<T10>(Item10Ptr);
        set
        {
            value.StructureType();
            var ptr = Item10Ptr;
            var nextPtr = ptr->PNext;
            *((T10*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T10 Item10Ref => ref Unsafe.AsRef<T10>(Item10Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item11Ptr => (BaseInStructure*) (_headPtr + Item11Offset);

    /// <summary>
    /// Gets or sets item #11 in the chain.
    /// </summary>
    public T11 Item11
    {
        get => Unsafe.AsRef<T11>(Item11Ptr);
        set
        {
            value.StructureType();
            var ptr = Item11Ptr;
            var nextPtr = ptr->PNext;
            *((T11*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T11 Item11Ref => ref Unsafe.AsRef<T11>(Item11Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item12Ptr => (BaseInStructure*) (_headPtr + Item12Offset);

    /// <summary>
    /// Gets or sets item #12 in the chain.
    /// </summary>
    public T12 Item12
    {
        get => Unsafe.AsRef<T12>(Item12Ptr);
        set
        {
            value.StructureType();
            var ptr = Item12Ptr;
            var nextPtr = ptr->PNext;
            *((T12*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T12 Item12Ref => ref Unsafe.AsRef<T12>(Item12Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item13Ptr => (BaseInStructure*) (_headPtr + Item13Offset);

    /// <summary>
    /// Gets or sets item #13 in the chain.
    /// </summary>
    public T13 Item13
    {
        get => Unsafe.AsRef<T13>(Item13Ptr);
        set
        {
            value.StructureType();
            var ptr = Item13Ptr;
            var nextPtr = ptr->PNext;
            *((T13*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T13 Item13Ref => ref Unsafe.AsRef<T13>(Item13Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item14Ptr => (BaseInStructure*) (_headPtr + Item14Offset);

    /// <summary>
    /// Gets or sets item #14 in the chain.
    /// </summary>
    public T14 Item14
    {
        get => Unsafe.AsRef<T14>(Item14Ptr);
        set
        {
            value.StructureType();
            var ptr = Item14Ptr;
            var nextPtr = ptr->PNext;
            *((T14*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T14 Item14Ref => ref Unsafe.AsRef<T14>(Item14Ptr);

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item15Ptr => (BaseInStructure*) (_headPtr + Item15Offset);

    /// <summary>
    /// Gets or sets item #15 in the chain.
    /// </summary>
    public T15 Item15
    {
        get => Unsafe.AsRef<T15>(Item15Ptr);
        set
        {
            value.StructureType();
            var ptr = Item15Ptr;
            var nextPtr = ptr->PNext;
            *((T15*)ptr) = value;
            ptr->PNext = nextPtr;
        }
    }
    /// <summary>
    /// Gets a reference to the second item in the chain.
    /// </summary>
    public ref T15 Item15Ref => ref Unsafe.AsRef<T15>(Item15Ptr);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Finalizer ensures we always release the memory.
    /// </summary>
    ~Chain() => Dispose(false);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    internal Chain(TChain head = default, T1 item1 = default, T2 item2 = default, T3 item3 = default, T4 item4 = default, T5 item5 = default, T6 item6 = default, T7 item7 = default, T8 item8 = default, T9 item9 = default, T10 item10 = default, T11 item11 = default, T12 item12 = default, T13 item13 = default, T14 item14 = default, T15 item15 = default)
        : this(SilkMarshal.Allocate(MemorySize))
    {
        head.StructureType();
        *((TChain*)_headPtr) = head;
        var itemPtr = Item1Ptr;
        item1.StructureType();
        *((T1*)itemPtr) = item1;
        HeadPtr->PNext = itemPtr;
        itemPtr = Item2Ptr;
        item2.StructureType();
        *((T2*)itemPtr) = item2;
        Item1Ptr->PNext = itemPtr;
        itemPtr = Item3Ptr;
        item3.StructureType();
        *((T3*)itemPtr) = item3;
        Item2Ptr->PNext = itemPtr;
        itemPtr = Item4Ptr;
        item4.StructureType();
        *((T4*)itemPtr) = item4;
        Item3Ptr->PNext = itemPtr;
        itemPtr = Item5Ptr;
        item5.StructureType();
        *((T5*)itemPtr) = item5;
        Item4Ptr->PNext = itemPtr;
        itemPtr = Item6Ptr;
        item6.StructureType();
        *((T6*)itemPtr) = item6;
        Item5Ptr->PNext = itemPtr;
        itemPtr = Item7Ptr;
        item7.StructureType();
        *((T7*)itemPtr) = item7;
        Item6Ptr->PNext = itemPtr;
        itemPtr = Item8Ptr;
        item8.StructureType();
        *((T8*)itemPtr) = item8;
        Item7Ptr->PNext = itemPtr;
        itemPtr = Item9Ptr;
        item9.StructureType();
        *((T9*)itemPtr) = item9;
        Item8Ptr->PNext = itemPtr;
        itemPtr = Item10Ptr;
        item10.StructureType();
        *((T10*)itemPtr) = item10;
        Item9Ptr->PNext = itemPtr;
        itemPtr = Item11Ptr;
        item11.StructureType();
        *((T11*)itemPtr) = item11;
        Item10Ptr->PNext = itemPtr;
        itemPtr = Item12Ptr;
        item12.StructureType();
        *((T12*)itemPtr) = item12;
        Item11Ptr->PNext = itemPtr;
        itemPtr = Item13Ptr;
        item13.StructureType();
        *((T13*)itemPtr) = item13;
        Item12Ptr->PNext = itemPtr;
        itemPtr = Item14Ptr;
        item14.StructureType();
        *((T14*)itemPtr) = item14;
        Item13Ptr->PNext = itemPtr;
        itemPtr = Item15Ptr;
        item15.StructureType();
        *((T15*)itemPtr) = item15;
        Item14Ptr->PNext = itemPtr;
        Item15Ptr->PNext = null;
    }

    /// <inheritdoc />
    public override Chain Clear(bool includeHead = true)
    {
        if (includeHead)
        {
            var head = default(TChain);
            head.StructureType();
            *((TChain*)_headPtr) = head;
            HeadPtr->PNext = Item1Ptr;
        }
        var item1 = default(T1);
        item1.StructureType();
        *((T1*)Item1Ptr) = item1;
        Item1Ptr->PNext = Item2Ptr;
        var item2 = default(T2);
        item2.StructureType();
        *((T2*)Item2Ptr) = item2;
        Item2Ptr->PNext = Item3Ptr;
        var item3 = default(T3);
        item3.StructureType();
        *((T3*)Item3Ptr) = item3;
        Item3Ptr->PNext = Item4Ptr;
        var item4 = default(T4);
        item4.StructureType();
        *((T4*)Item4Ptr) = item4;
        Item4Ptr->PNext = Item5Ptr;
        var item5 = default(T5);
        item5.StructureType();
        *((T5*)Item5Ptr) = item5;
        Item5Ptr->PNext = Item6Ptr;
        var item6 = default(T6);
        item6.StructureType();
        *((T6*)Item6Ptr) = item6;
        Item6Ptr->PNext = Item7Ptr;
        var item7 = default(T7);
        item7.StructureType();
        *((T7*)Item7Ptr) = item7;
        Item7Ptr->PNext = Item8Ptr;
        var item8 = default(T8);
        item8.StructureType();
        *((T8*)Item8Ptr) = item8;
        Item8Ptr->PNext = Item9Ptr;
        var item9 = default(T9);
        item9.StructureType();
        *((T9*)Item9Ptr) = item9;
        Item9Ptr->PNext = Item10Ptr;
        var item10 = default(T10);
        item10.StructureType();
        *((T10*)Item10Ptr) = item10;
        Item10Ptr->PNext = Item11Ptr;
        var item11 = default(T11);
        item11.StructureType();
        *((T11*)Item11Ptr) = item11;
        Item11Ptr->PNext = Item12Ptr;
        var item12 = default(T12);
        item12.StructureType();
        *((T12*)Item12Ptr) = item12;
        Item12Ptr->PNext = Item13Ptr;
        var item13 = default(T13);
        item13.StructureType();
        *((T13*)Item13Ptr) = item13;
        Item13Ptr->PNext = Item14Ptr;
        var item14 = default(T14);
        item14.StructureType();
        *((T14*)Item14Ptr) = item14;
        Item14Ptr->PNext = Item15Ptr;
        var item15 = default(T15);
        item15.StructureType();
        *((T15*)Item15Ptr) = item15;
        Item15Ptr->PNext = null;
        return this;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoDuplicate() => Duplicate();

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 16 items, by copying this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Duplicate()
    {
        var size = MemorySize;
        var newHeadPtr = SilkMarshal.Allocate(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset); 
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + Item14Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item15Offset); 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(newHeadPtr);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoAddAny<T>(T item = default)
        => throw new InvalidOperationException("Cannot add to chain of length 16.");

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny()
        => TruncateAny(out var _);

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected override Chain DoTruncateAny(out IChainable tail)
    {
        var chain = TruncateAny(out var t);
        tail = (IChainable) t;
        return chain;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T15)" />
    /// <seealso cref="TruncateAny(out T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Truncate()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing the last item
    /// from the end of this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="Truncate(out T15)" />
    /// <seealso cref="TruncateAny(out T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> TruncateAny()
        => TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15}"/> with 15 items, by removing 
    /// <paramref name="item15"/> from the end of this instance.
    /// </summary>
    /// <param name="item15">The item removed from the end of this instance.</param>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="TruncateAny(out T15)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Truncate(out T15 item15)
        => TruncateAny(out item15);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14}"/> with 15 items, by removing 
    /// <paramref name="item15"/> from the end of this instance.
    /// </summary>
    /// <param name="item15">The item removed from the end of this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate()" />
    /// <seealso cref="TruncateAny()" />
    /// <seealso cref="Truncate(out T15)" />
    public Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> TruncateAny(out T15 item15)
    {
        // Retrieve last item.
        item15 = Item15;

        var newSize = MemorySize - Item15Size;
        var newHeadPtr = SilkMarshal.Allocate(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Item1Offset);
        ((BaseInStructure*)(newHeadPtr + Item1Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item2Offset); 
        ((BaseInStructure*)(newHeadPtr + Item2Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item3Offset); 
        ((BaseInStructure*)(newHeadPtr + Item3Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item4Offset); 
        ((BaseInStructure*)(newHeadPtr + Item4Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item5Offset); 
        ((BaseInStructure*)(newHeadPtr + Item5Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item6Offset); 
        ((BaseInStructure*)(newHeadPtr + Item6Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item7Offset); 
        ((BaseInStructure*)(newHeadPtr + Item7Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item8Offset); 
        ((BaseInStructure*)(newHeadPtr + Item8Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item9Offset); 
        ((BaseInStructure*)(newHeadPtr + Item9Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item10Offset); 
        ((BaseInStructure*)(newHeadPtr + Item10Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item11Offset); 
        ((BaseInStructure*)(newHeadPtr + Item11Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item12Offset); 
        ((BaseInStructure*)(newHeadPtr + Item12Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item13Offset); 
        ((BaseInStructure*)(newHeadPtr + Item13Offset))->PNext = (BaseInStructure*) (newHeadPtr + Item14Offset); 
        ((BaseInStructure*)(newHeadPtr + Item14Offset))->PNext = null; 
        return new Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(newHeadPtr);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
        yield return Item2;
        yield return Item3;
        yield return Item4;
        yield return Item5;
        yield return Item6;
        yield return Item7;
        yield return Item8;
        yield return Item9;
        yield return Item10;
        yield return Item11;
        yield return Item12;
        yield return Item13;
        yield return Item14;
        yield return Item15;
    }

    /// <inheritdoc />
    public override int Count => 16;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            2 => Item2,
            3 => Item3,
            4 => Item4,
            5 => Item5,
            6 => Item6,
            7 => Item7,
            8 => Item8,
            9 => Item9,
            10 => Item10,
            11 => Item11,
            12 => Item12,
            13 => Item13,
            14 => Item14,
            15 => Item15,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item15Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item2Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item3Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item4Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item5Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item6Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item7Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item8Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item9Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item10Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item11Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item12Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item13Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item14Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item15Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <summary>
    ///    Equality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are equal, otherwise <c> false </c> .
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <summary>
    ///    Inequality operator overload.
    /// </summary>
    /// <param name="left">
    ///    The left value.
    /// </param>
    /// <param name="right">
    ///    The right value.
    /// </param>
    /// <returns>
    ///    <c> true </c> when the instances are not equal, otherwise <c> false </c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(", ");
        sb.Append((object) Item2);
        sb.Append(", ");
        sb.Append((object) Item3);
        sb.Append(", ");
        sb.Append((object) Item4);
        sb.Append(", ");
        sb.Append((object) Item5);
        sb.Append(", ");
        sb.Append((object) Item6);
        sb.Append(", ");
        sb.Append((object) Item7);
        sb.Append(", ");
        sb.Append((object) Item8);
        sb.Append(", ");
        sb.Append((object) Item9);
        sb.Append(", ");
        sb.Append((object) Item10);
        sb.Append(", ");
        sb.Append((object) Item11);
        sb.Append(", ");
        sb.Append((object) Item12);
        sb.Append(", ");
        sb.Append((object) Item13);
        sb.Append(", ");
        sb.Append((object) Item14);
        sb.Append(", ");
        sb.Append((object) Item15);
        sb.Append(")");
        return sb.ToString();
    }

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <param name="item2">Item 2.</param>
    /// <param name="item3">Item 3.</param>
    /// <param name="item4">Item 4.</param>
    /// <param name="item5">Item 5.</param>
    /// <param name="item6">Item 6.</param>
    /// <param name="item7">Item 7.</param>
    /// <param name="item8">Item 8.</param>
    /// <param name="item9">Item 9.</param>
    /// <param name="item10">Item 10.</param>
    /// <param name="item11">Item 11.</param>
    /// <param name="item12">Item 12.</param>
    /// <param name="item13">Item 13.</param>
    /// <param name="item14">Item 14.</param>
    /// <param name="item15">Item 15.</param>
    public void Deconstruct(out TChain head, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15)
    {
            head = Head;
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
            item8 = Item8;
            item9 = Item9;
            item10 = Item10;
            item11 = Item11;
            item12 = Item12;
            item13 = Item13;
            item14 = Item14;
            item15 = Item15;
    }  

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Free memory block
        SilkMarshal.Free(headPtr);
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain) => (nint)chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain) => chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <typeparam ref="TChain"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator TChain*(Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> chain) => (TChain*)chain._headPtr;
}
