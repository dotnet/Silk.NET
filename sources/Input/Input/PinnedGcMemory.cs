// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// A simple wrapper struct to house a pinned array
/// </summary>
/// <typeparam name="T">The type of elements in the array</typeparam>
internal struct PinnedGcMemory<T> : IDisposable where T : struct
{
    private T[] _array;
    private int _capacity;
    private int _actualCount;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<T> AsSpan() => new(_array, 0, _actualCount);

    /// <summary>
    /// Returns a reference to the given element in our array, <b>without</b> respecting our actual count.
    /// Callers must be absolutely sure that this collection has been populated up to this point - otherwise,
    /// you may be accessing uninitialized or stale memory, or exceeding the bounds of the array
    /// </summary>
    public ref readonly T UnsafeGetRef(int index) => ref _array[index];

    public int Count => _actualCount;

    public void Add(in T value)
    {
        var index = _actualCount++;
        EnsureCapacity(_actualCount);
        _array[index] = value;
    }

    /// <summary>
    /// Disposes of the native memory buffers, freeing the underlying pointer.
    /// </summary>
    public void Dispose()
    {
        if (_array != null)
        {
            _actualCount = 0;
            _capacity = 0;
            _array = null!;
        }
    }

    private void EnsureCapacity(int desiredCount)
    {
        if (_capacity >= desiredCount)
        {
            return;
        }

        var newSize = Math.Max(_capacity * 2, desiredCount);

        var newArray = GC.AllocateUninitializedArray<T>(newSize, pinned: true);
        _array?.CopyTo(newArray.AsSpan(0, _array.Length));

        _array = newArray;
        _capacity = newSize;
    }

    /// <summary>
    /// Resets the count of our data without actually clearing the memory
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void ResetCount() => _actualCount = 0;
}
