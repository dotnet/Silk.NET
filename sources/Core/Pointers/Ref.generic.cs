// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace Silk.NET.Core;

/// <summary>
/// A single dimension managed reference wrapper
/// </summary>
public readonly ref struct Ref<T>
    where T : unmanaged
{
    /// <summary>
    /// Creates a reference with the given underlying ref.
    /// </summary>
    /// <param name="Ref">The underlying ref.</param>
    public Ref(ref T @Ref)
    {
        this.Handle = ref @Ref;
    }

    /// <summary>
    /// The underlying reference.
    /// </summary>
    public readonly ref T Handle;

    /// <summary>
    /// Gets the item at the given offset from this reference.
    /// </summary>
    /// <param name="index">The index.</param>
    public ref T this[nuint index]
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
    /// This function allows a <see cref="Ref{T}"/> to be used in a <c>fixed</c> statement.
    /// </remarks>
    public ref T GetPinnableReference() => ref Handle;

    /// <summary>
    /// Creates a span with the given length from this reference.
    /// </summary>
    /// <param name="length">the span length</param>
    /// <returns>the span</returns>
    public Span<T> AsSpan(int length) => MemoryMarshal.CreateSpan(ref Handle, length);

    /// <summary>
    /// Determines if this <see cref="Ref{T}"/> equals another object
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
    /// Determines if two <see cref="Ref{T}"/> objects are equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe bool operator ==(Ref<T> lh, Ref<T> rh) => (void*)lh == (void*)rh;

    /// <summary>
    /// Determines if two <see cref="Ref{T}"/> objects are not equivalent
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the references are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe bool operator !=(Ref<T> lh, Ref<T> rh) => (void*)lh != (void*)rh;

    /// <summary>
    /// Creates a <see cref="Ref{T}"/> from a Nullptr
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe implicit operator Ref<T>(NullPtr ptr) => (void*)ptr;

    /// <summary>
    /// Determines whether a <see cref="Ref{T}"/> and a NullPtr are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Ref{T}"/> and NullPtr are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(Ref<T> lh, NullPtr rh) => lh == (Ref<T>)rh;

    /// <summary>
    /// Determines whether a <see cref="Ref{T}"/> and a NullPtr are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the <see cref="Ref{T}"/> and NullPtr are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(Ref<T> lh, NullPtr rh) => lh != (Ref<T>)rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Ref{T}"/> are equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Ref{T}"/> are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator ==(NullPtr lh, Ref<T> rh) => (Ref<T>)lh == rh;

    /// <summary>
    /// Determines whether a NullPtr and a <see cref="Ref{T}"/> are not equal
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns>Whether the NullPtr and <see cref="Ref{T}"/> are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool operator !=(NullPtr lh, Ref<T> rh) => (Ref<T>)lh != rh;

    /// <summary>
    /// Creates a <see cref="Ref{T}"/> from a span
    /// </summary>
    /// <param name="span"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref<T>(Span<T> span) => new(ref span.GetPinnableReference());

    /// <summary>
    /// Creates a <see cref="Ref{T}"/> from a byte reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe implicit operator Ref<T>(T* ptr) => new(ref Unsafe.AsRef<T>(ptr));

    /// <summary>
    /// Creates a <see cref="Ref{T}"/> from a void reference
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe implicit operator Ref<T>(void* ptr) => new(ref Unsafe.AsRef<T>(ptr));

    /// <summary>
    /// Creates a byte reference from a <see cref="Ref{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe explicit operator T*(Ref<T> ptr) => (T*)Unsafe.AsPointer(ref ptr.Handle);

    /// <summary>
    /// Creates a void reference from a <see cref="Ref{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe explicit operator void*(Ref<T> ptr) => Unsafe.AsPointer(ref ptr.Handle);

    /// <summary>
    /// creates a <see cref="Ref{T}"/> from an array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref<T>(T[] array) => array.AsSpan();

    /// <summary>
    /// creates a <see cref="Ref{T}"/> from a 2D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref<T>(T[,] array) =>
        MemoryMarshal.CreateSpan(ref array[0, 0], array.Length);

    /// <summary>
    /// creates a <see cref="Ref{T}"/> from a 3D array
    /// </summary>
    /// <param name="array"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator Ref<T>(T[,,] array) =>
        MemoryMarshal.CreateSpan(ref array[0, 0, 0], array.Length);

    /// <summary>
    /// Creates a string from a <see cref="Ref{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe explicit operator string(Ref<T> ptr)
    {
        if (typeof(T) == typeof(char) || typeof(T) == typeof(short) || typeof(T) == typeof(ushort))
        {
            fixed (void* raw = ptr)
            {
                return new string((char*)raw);
            }
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            fixed (void* raw = ptr)
            {
                return Encoding.UTF8.GetString(
                    MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                );
            }
        }

        if (typeof(T) == typeof(int) || typeof(T) == typeof(uint))
        {
            fixed (void* raw = ptr)
            {
                int words;
                for (words = 0; ((uint*)raw)[words] != 0; words++)
                {
                    // do nothing
                }

                return Encoding.UTF32.GetString((byte*)raw, words * 4);
            }
        }

        throw new InvalidCastException();
    }

    /// <summary>
    /// Creates a <see cref="Ref{T}"/> from a string
    /// </summary>
    /// <param name="str"></param>
    public static implicit operator Ref<T>(string str)
    {
        if (typeof(T) == typeof(char) || typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
        {
            return new(ref Unsafe.As<char, T>(ref Unsafe.AsRef(in str.GetPinnableReference())));
        }

        if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
        {
            return new(
                ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str)))
            );
        }

        if (typeof(T) == typeof(uint) || typeof(T) == typeof(int))
        {
            return new(
                ref Unsafe.As<byte, T>(ref Unsafe.AsRef(in SilkMarshal.StringToNative(str, 4)))
            );
        }

        throw new InvalidCastException();
    }

    /// <summary>
    /// Create a non-generic version of <see cref="Ref{T}"/>
    /// </summary>
    /// <param name="ptr"></param>
    public static implicit operator Ref(Ref<T> ptr) => new(ref Unsafe.As<T, byte>(ref ptr.Handle));
}
