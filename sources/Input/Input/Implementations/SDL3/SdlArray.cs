// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

// note - this probably doesn't need to be a ref struct, but is bc that's the extents
// of the struct's current use cases
// todo - can this struct be represented as a NativeArray<T, TBackend> where TBackend has a
//  Free(void*) or Free(void*, int) method?
internal readonly unsafe ref struct SdlArray<T> : IDisposable, IEquatable<SdlArray<T>>, IReadOnlyList<T> where T : unmanaged
{
    private readonly Ptr<T> _ptr;
    public int Count { get; }
    private readonly ISdl? _sdl;

    [MemberNotNullWhen(true, nameof(_sdl))]
    private bool CanDispose { get; }

    public static SdlArray<T> Null => default;

    public SdlArray(Ptr<T> ptr, int count, ISdl? sdl, bool consumerCanDispose = true)
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
            return;
        }

        if (_ptr.Native == null)
        {
            return;
        }

        _sdl.Free(_ptr.Native);
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



    public bool IsNull => _ptr.Native == null;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<T> AsSpan() => _ptr.Native == null ? default : new Span<T>(_ptr.Native, Count);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ReadOnlySpan<T> AsReadOnlySpan() => _ptr.Native == null ? default : new ReadOnlySpan<T>(_ptr.Native, Count);

    T IReadOnlyList<T>.this[int index] => this[index];

    public ref T this[int index]
    {
        get
        {
            if (_ptr.Native == null)
            {
                throw new NullReferenceException();
            }

            if (Count <= index)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            ArgumentOutOfRangeException.ThrowIfNegative(index);

            return ref _ptr.Native[index];
        }
    }

    public ref T this[uint index]
    {
        get
        {
            if (_ptr.Native == null)
            {
                throw new NullReferenceException();
            }

            if (Count <= index)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            return ref _ptr.Native[index];
        }
    }

    public bool Equals(SdlArray<T> other) => this == other;

    public IEnumerator<T> GetEnumerator()
    {
        if (_ptr == nullptr)
        {
            throw new NullReferenceException();
        }

        return (IEnumerator<T>)AsReadOnlySpan().ToArray().GetEnumerator();
    }

    public override bool Equals(object? obj) => obj == null && _ptr.Native == null;
    public override int GetHashCode() => HashCode.Combine(_ptr, Count, _sdl);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
