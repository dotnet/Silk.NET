// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable CS0659, CS0660, CS0661
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

/// <summary>
/// Base class for all <see cref="Chain{T}">Managed Chains</see>.
/// </summary>
public abstract unsafe partial class Chain : IReadOnlyList<IChainable>, IEquatable<Chain>, IDisposable
{ 
    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public abstract BaseInStructure* HeadPtr { get; }

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public abstract int Size { get; }

    /// <summary>
    /// Clears this instance by setting each element of the chain to <c>default</c>, whilst maintaining the
    /// <see cref="BaseInStructure.SType"/> and <see cref="BaseInStructure.PNext"/>. 
    /// </summary>
    /// <param name="includeHead">If <c>true</c> will also clear the head of the chain; otherwise, will not touch the
    /// head if <c>false</c></param>
    /// <returns>This instance.</returns>
    /// <remarks>
    /// <para>Note, unlike many of the other length modifying methods, this does not return a new instance, if you wish
    /// to create a cleared instance with the same types, first use <see cref="Duplicate"/>.</para>
    /// </remarks>
    public abstract Chain Clear(bool includeHead = true);

    /// <summary>
    /// Creates a new <see cref="Chain"/> by copying this instance.
    /// </summary>
    /// <returns>A duplicate of this instance.</returns>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain Duplicate() => DoDuplicate();

    /// <summary>
    /// Creates a new <see cref="Chain"/> by copying this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para>
    /// </remarks>
    protected abstract Chain DoDuplicate();

    /// <summary>
    /// Creates a new <see cref="Chain"/> with 2 items, by appending <paramref name="item"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item">The item to append.</param>
    /// <typeparam name="T">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain AddAny<T>(T item = default)
        where T : unmanaged, IChainable
        => DoAddAny(item);

    /// <summary>
    /// Creates a new <see cref="Chain"/> with 2 items, by appending <paramref name="item"/> to
    /// the end of this instance.
    /// </summary>
    /// <param name="item">The item to append.</param>
    /// <typeparam name="T">Type of the item.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    protected abstract Chain DoAddAny<T>(T item = default)
        where T : unmanaged, IChainable;

    /// <summary>
    /// Creates a new <see cref="Chain"/>by removing the last item from this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain TruncateAny() => DoTruncateAny();

    /// <summary>
    /// Creates a new <see cref="Chain"/>by removing the last item from this instance.
    /// </summary>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    protected abstract Chain DoTruncateAny();

    /// <summary>
    /// Creates a new <see cref="Chain"/>by removing the last item from this instance.
    /// </summary>
    /// <param name="tail">The item removed from this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Chain TruncateAny(out IChainable tail)
        => DoTruncateAny(out tail);

    /// <summary>
    /// Creates a new <see cref="Chain"/>by removing the last item from this instance.
    /// </summary>
    /// <param name="tail">The item removed from this instance.</param>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    protected abstract Chain DoTruncateAny(out IChainable tail);

    /// <inheritdoc />
    public abstract IEnumerator<IChainable> GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc />
    public abstract int Count { get; }

    /// <inheritdoc />
    public abstract IChainable this[int index] { get; }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Chain other)
    {
        return !ReferenceEquals(null, other) &&
               (ReferenceEquals(this, other) || other.GetType() == this.GetType() && MemoryEquals(other));
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object obj)
    {
        return !ReferenceEquals(null, obj) &&
               (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && MemoryEquals((Chain) obj));
    }

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
    public static bool operator ==(Chain left, Chain right)
    {
        return left?.Equals(right) ?? ReferenceEquals(null, right);
    }

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
    public static bool operator !=(Chain left, Chain right)
    {
        return !(left?.Equals(right) ?? ReferenceEquals(null, right));
    }

    /// <summary>
    /// Compares the supplied memory block with this one.
    /// </summary>  
    protected abstract bool MemoryEquals(Chain other);

    /// <inheritdoc />
    public void Dispose()
    {
        // Dispose of unmanaged resources.
        Dispose(true);
        // Suppress finalization.
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Protected implementation of the dispose pattern
    /// </summary>
    /// <param name="disposing"></param>
    protected abstract void Dispose(bool disposing);

    /// <summary>
    /// Combines a hashcode with the contents of a slice.
    /// </summary>
    /// <param name="hashCode"></param>
    /// <param name="slice"></param>
    /// <returns></returns>
    protected static void CombineHash(ref int hashCode, ReadOnlySpan<byte> slice)
    {
        if (slice.Length >= 8)
        {
            // Process slice in 8 byte chunks
            var s8 = MemoryMarshal.Cast<byte, ulong>(slice);
            foreach (var l in s8)
            {
                hashCode = HashCode.Combine(hashCode, l);
            }

            slice = slice.Slice(s8.Length * 8);
        }

        // Process remainder of slice
        if (slice.Length >= 4)
        {
            var s4 = MemoryMarshal.Cast<byte, uint>(slice);
            hashCode = HashCode.Combine(hashCode, s4[0]);
            slice = slice.Slice(s4.Length * 4);
        }

        if (slice.Length >= 2)
        {
            var s2 = MemoryMarshal.Cast<byte, ushort>(slice);
            hashCode = HashCode.Combine(hashCode, s2[0]);
            slice = slice.Slice(s2.Length * 2);
        }

        if (slice.Length > 0)
        {
            hashCode = HashCode.Combine(hashCode, slice[0]);
        }
    }

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>nint</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator nint(Chain chain) => (nint) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <c>void*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator void*(Chain chain) => (void*) chain.HeadPtr;

    /// <summary>
    ///   Defines an implicit conversion of a given <see cref="Chain"/> to a pointer to the <see cref="HeadPtr">head</see>.
    /// </summary>
    /// <param name="chain">A <see cref="Chain"/> to implicitly convert.</param>
    /// <returns>A <see cref="BaseInStructure"/><c>*</c> pointer to the head of the <paramref name="chain"/>.</returns>
    public static implicit operator BaseInStructure*(Chain chain) => chain.HeadPtr;
}
