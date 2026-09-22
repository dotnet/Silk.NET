// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

namespace Silk.NET.Input;

/// <summary>
/// A struct that represents a native memory buffer of a given type.
/// Allows for several unsafe memory operations - use with care and do NOT expose this data structure to any APIs
/// external to your system.
/// <br/><br/>
/// Since this struct deals entirely with native memory, and it is a value type, it must be used with great care.
/// Never assign a new instance of this struct to another variable, or overwrite it with a new instance. This
/// can lead to native memory leaks. Any class consuming this struct should necessarily be considered unsafe.
/// <br/><br/>
/// Note that this struct is ONLY intended for use with memory it allocates itself. I do not recommend trying to
/// use or extend it if you are not prepared to take bullet-proof precautions.
/// </summary>
/// <typeparam name="T">
/// While perhaps this should be required to be unmanaged, for convenience sake we are allowing managed
/// objects as fields of the type.
/// </typeparam>
internal unsafe struct NativeMemory<T> : IDisposable where T : struct
{
    private T* _ptr;
    private int _capacity;
    private int _actualCount;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnsafeView AsSpan() => new(_ptr, 0, _actualCount);

    public void Add(in T value)
    {
        var index = _actualCount++;
        EnsureCapacity(_actualCount);
        _ptr[index] = value;
    }

    /// <summary>
    /// Returns a reference to our data as two spans and clears the inner count of our buffers
    /// (the functional equivalent of calling <see cref="List{T}.Clear()"/>), while still allowing you to read the data.
    /// <br/><br/>
    /// This imposes memory risks - the contents of the span may change, invisibly to you, despite having the "safety"
    /// of the span. One can write to the span, or free the inner pointer, causing memory access violations or tricky
    /// logic errors.<br/><br/>
    /// It is, however, a very fast means of reading the data. Just use this method with caution.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnsafeView ConsumeWithoutClearing()
    {
        var count = _actualCount;
        _actualCount = 0;
        return _ptr == null ? default : new UnsafeView(_ptr, 0, count);
    }

    /// <summary>
    /// Disposes of the native memory buffers, freeing the underlying pointer.
    /// </summary>
    public void Dispose()
    {
        if (_ptr != null)
        {
            NativeMemory.Free(_ptr);
            _actualCount = 0;
            _capacity = 0;
            _ptr = null;
        }
    }

    private void EnsureCapacity(int desiredCount)
    {
        if (_capacity >= desiredCount)
        {
            return;
        }

        var newSize = Math.Max(_capacity * 2, desiredCount);

        if (_ptr != null)
        {
            _ptr = (T*)NativeMemory.Realloc(_ptr, (uint)(Unsafe.SizeOf<T>() * newSize));
        }
        else
        {
            _ptr = (T*)NativeMemory.Alloc((uint)(Unsafe.SizeOf<T>() * newSize));
        }

        _capacity = newSize;
    }

    /* Commenting out as it is unused

       public int Count
       {
           [MethodImpl(MethodImplOptions.AggressiveInlining)]
           get => _actualCount;
       }

       public ref T this[int index]
       {
           get
           {
               if(index >= _actualCount)
               {
                   throw new IndexOutOfRangeException();
               }

               return ref _ptr[index];
           }
       }

    /// <summary>
    /// Clears the values in the buffer, optionally clearing the entire capacity of the buffer.
    /// </summary>
    /// <param name="entireCapacity">Whether to clear the entire capacity of the buffer, or just the effective count.</param>
    /// <param name="startIndex">The index to start clearing from.</param>
    public void ClearValues(bool entireCapacity, uint startIndex = 0)
    {
        if (_ptr == null)
        {
            return;
        }

        var max = entireCapacity ? _capacity : _actualCount;

        if(startIndex >= max)
        {
            return;
        }

        _actualCount = 0;
        NativeMemory.Fill(
            ptr: _ptr + startIndex,
            byteCount: (nuint)(max * Unsafe.SizeOf<T>()),
            value: 0);
    }
    */

    /// <summary>
    /// Our version of <see cref="Span{T}"/>. This is only necessary because managed structs in a span throw runtime
    /// exceptions so users don't shoot themselves in the foot with memory access violations.
    /// Since this is an internal data structure, we risk it for the biscuit.
    /// </summary>
    /// <param name="ptr">The pointer to the data</param>
    /// <param name="start">The start index, added to the given pointer</param>
    /// <param name="length">The length of the desired view</param>
    public readonly unsafe ref struct UnsafeView(T* ptr, int start, int length)
    {
        public readonly T* Ptr = ptr + start;
        public readonly int Length = length;

        public ref T this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Ptr[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public nint PointerAt(int index) => (nint)(Ptr + index);
    }
}
