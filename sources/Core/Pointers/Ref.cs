// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A single dimension managed reference wrapper
/// </summary>
public readonly ref struct Ref
{
    /// <summary>
    /// Creates a reference with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public Ref(ref byte @Ref)
    {
        this.Handle = ref @Ref;
    }

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref byte Handle;

    /// <summary>
    /// Gets the item at the given offset from this reference.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref byte this[nuint index]
    {
        [MethodImpl(
        MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
    )]
        get => ref Unsafe.Add(ref Handle, index);
    }

    /// <summary>
    /// Gets the underlying reference.
    /// </summary>
    /// <returns>The underlying reference.</returns>
    /// <remarks>
    /// This function allows a <see cref="Core.Ref"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref byte GetPinnableReference() => ref Handle;

    /// <summary>
    /// Creates a span with the given length from this reference.
    /// </summary>
    /// <param name="length">the span length</param>
    /// <returns>the span</returns>
    public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref Handle, length);

    /// <summary>
    /// Determines if this <see cref="Core.Ref"/> equals another object
    /// Always returns false as ref structs cannot be passed in, meaning this will never be true
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Whether this object is the same as </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override bool Equals([NotNullWhen(true)] object? obj) => false;

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public override int GetHashCode() => Handle.GetHashCode();

    /// <summary>
    /// Determines if two <see cref="Core.Ref"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static bool operator ==(Ref lh, Ref rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="Core.Ref"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static bool operator !=(Ref lh, Ref rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="Core.Ref"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator Ref(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="Core.Ref"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Core.Ref"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ref lh, NullPtr rh) => lh == (Ref)rh;

    /// <summary>
    /// Determines whether a <see cref="Core.Ref"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Core.Ref"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ref lh, NullPtr rh) => lh != (Ref)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Core.Ref"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Core.Ref"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, Ref rh) => (Ref)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Core.Ref"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Core.Ref"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, Ref rh) => (Ref)lh != rh;

    /// <summary>
    /// Creates a <see cref="Core.Ref"/> from a span
    /// </summary>
    /// <param name="span"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref(Span<byte> span) => new(ref span.GetPinnableReference());

    /// <summary>
    /// Creates a <see cref="Core.Ref"/> from a byte reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator Ref(byte* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a <see cref="Core.Ref"/> from a void reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static implicit operator Ref(void* ptr) => new(ref Unsafe.AsRef<byte>(ptr));

    /// <summary>
    /// Creates a byte reference from a <see cref="Core.Ref"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator byte*(Ref ptr) => (byte*)Unsafe.AsPointer(ref ptr.Handle);

    /// <summary>
    /// Creates a void reference from a <see cref="Core.Ref"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe static explicit operator void*(Ref ptr) => Unsafe.AsPointer(ref ptr.Handle);

    /// <summary>
    /// creates a <see cref="Core.Ref"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref(byte[] array) => array.AsSpan();

    /// <summary>
    /// creates a <see cref="Core.Ref"/> from a 2D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref(byte[,] array) => MemoryMarshal.CreateSpan(ref array[0, 0], array.Length);

    /// <summary>
    /// creates a <see cref="Core.Ref"/> from a 3D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref(byte[,,] array) => MemoryMarshal.CreateSpan(ref array[0, 0, 0], array.Length);

    /// <summary>
    /// Creates a string from this <see cref="Core.Ref"/> with the given length
    /// </summary>
    /// <param name="length">length of the string</param>
    /// <returns>the string</returns>
    public unsafe string ReadToString(int length) => Encoding.UTF8.GetString(AsSpan(length));

    /// <summary>
    /// Creates a string from this <see cref="Core.Ref"/> as a c-style string
    /// </summary>
    /// <returns>the string</returns>
    public unsafe string ReadToString()
    {
        return Encoding.UTF8.GetString(
            MemoryMarshal.CreateReadOnlySpanFromNullTerminated(
                (byte*)Unsafe.AsPointer(ref Handle)));
    }

    /// <summary>
    /// Creates a string from a <see cref="Core.Ref"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static explicit operator string(Ref ptr) => ptr.ReadToString();

    /// <summary>
    /// Creates a <see cref="Ref"/> from a string
    /// </summary>
    /// <param name="str"></param>
    public static implicit operator Ref(string str) => new (ref Unsafe.AsRef(in SilkMarshal.StringToNative(str)));
}
