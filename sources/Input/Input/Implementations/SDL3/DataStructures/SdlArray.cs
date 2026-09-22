// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.DataStructures;

// note - this probably doesn't need to be a ref struct, but is bc that's the extent
// of the struct's current use cases
// LONG-TERM DOM-SPECIFIC TO-DO - can this struct be represented as a NativeArray<T, TBackend> where TBackend has a
//  Free(void*) or Free(void*, int) method?
/// <summary>
/// Represents an array of values produced by SDL.
/// </summary>
/// <typeparam name="T">The type of values in the array - usually SDL struct types.</typeparam>
internal readonly unsafe ref struct SdlArray<T> : IDisposable, IEquatable<SdlArray<T>> where T : unmanaged
{
    private readonly T* _ptr;
    public int Count { get; }
    private readonly ISdl? _sdl;

    [MemberNotNullWhen(true, nameof(_sdl))]
    private bool CanDispose { get; }

    public static SdlArray<T> Null => default;

    public SdlArray(Ptr<T> ptr, int count, ISdl? sdl, bool consumerCanDispose)
    {
        if (consumerCanDispose)
        {
            ArgumentNullException.ThrowIfNull(ptr.Native);
            ArgumentNullException.ThrowIfNull(sdl);
        }

        ArgumentOutOfRangeException.ThrowIfNegative(count);

        _ptr = ptr;
        Count = count;
        _sdl = sdl;
        CanDispose = consumerCanDispose;
    }

    public void Dispose()
    {
        if (!CanDispose)
        {
            #if DEBUG
            InputLog.Error("SdlArray disposal attempt without permission");
            #endif
            return;
        }

        if (_ptr == null)
        {
            return;
        }

        _sdl.Free(_ptr);
    }

    public static implicit operator Ptr<T>(SdlArray<T> array) => array._ptr;
    public static implicit operator Span<T>(SdlArray<T> array) => array.AsSpan();
    public static implicit operator ReadOnlySpan<T>(SdlArray<T> array) => array.AsReadOnlySpan();

    // equality operators against null and other collections
    public static bool operator ==(SdlArray<T> left, SdlArray<T> right) => left._sdl == right._sdl && left._ptr == right._ptr;
    public static bool operator !=(SdlArray<T> left, SdlArray<T> right) => left._sdl == right._sdl && left._ptr != right._ptr;
    public static bool operator ==(SdlArray<T> left, NullPtr right) => left._ptr == right;
    public static bool operator !=(SdlArray<T> left, NullPtr right) => left._ptr != right;
    public static bool operator ==(NullPtr left, SdlArray<T> right) => left == right._ptr;
    public static bool operator !=(NullPtr left, SdlArray<T> right) => left != right._ptr;



    public bool IsNull => _ptr == null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<T> AsSpan() => _ptr == null ? default : new Span<T>(_ptr, Count);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ReadOnlySpan<T> AsReadOnlySpan() => _ptr == null ? default : new ReadOnlySpan<T>(_ptr, Count);

    public ref T this[int index]
    {
        get
        {
            if (_ptr == null)
            {
                throw new NullReferenceException();
            }

            if (Count <= index)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            ArgumentOutOfRangeException.ThrowIfNegative(index);

            return ref _ptr[index];
        }
    }

    public ref T this[uint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref this[(int)index];
    }

    public bool Equals(SdlArray<T> other) => this == other;

    public override bool Equals(object? obj) => obj == null && _ptr == null;
    public override int GetHashCode() => HashCode.Combine((nuint)_ptr, Count, _sdl);
}
