// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Represents a block of global memory. That is, memory that is pinned and is valid so long as this object is alive.
    /// </summary>
    public sealed class GlobalMemory : IDisposable
    {    
        // Actual object
        private readonly object _memoryObject;
        private          int    _stringArrayCount;
        private          bool   _freed = false;

        private GlobalMemory(object memoryObject, int length, int stringArrayCount = 0)
        {
            _memoryObject = memoryObject;
            Length = length;
            _stringArrayCount = stringArrayCount;
        }

        /// <summary>
        /// Gets the length of this block of global memory.
        /// </summary>
        public int Length { get; }
        
        /// <summary>
        /// Gets a reference to a specific index of this block of global memory.
        /// </summary>
        /// <param name="index">The index.</param>
        public ref byte this[int index] => ref Unsafe.Add(ref GetPinnableReference(), index);

#if NETCOREAPP3_1 || NET5_0_OR_GREATER
        /// <summary>
        /// Gets a reference to a specific index of this block of global memory.
        /// </summary>
        /// <param name="index">The index.</param>
        public ref byte this[Index index] => ref Unsafe.Add(ref GetPinnableReference(), index.GetOffset(Length));

        /// <summary>
        /// Gets a span representing a specific area of this block of global memory.
        /// </summary>
        /// <param name="range">The range.</param>
        public Span<byte> this[Range range]
            => AsSpan().Slice(range.Start.GetOffset(Length), range.End.GetOffset(Length));
#endif

        /// <summary>
        /// Gets a handle to this block of global memory.
        /// </summary>
        public unsafe nint Handle => (nint)Unsafe.AsPointer(ref GetPinnableReference());

        /// <summary>
        /// Gets a span representing this block of global memory.
        /// </summary>
        /// <returns>A span of global memory.</returns>
        public unsafe Span<byte> AsSpan() => _memoryObject is IGlobalMemory hGlobal
            ? new Span<byte>((byte*) hGlobal.Handle, Length)
            : new Span<byte>((byte[]) _memoryObject);

        /// <summary>
        /// Gets a span of the given type representing this block of global memory.
        /// </summary>
        /// <returns>A span of global memory.</returns>
        public unsafe Span<T> AsSpan<T>() where T : unmanaged
            => new Span<T>(AsPtr<T>(), Length / sizeof(T));

        /// <summary>
        /// Gets a reference of the given type to a specific index within this block of global memory.
        /// </summary>
        /// <param name="index">
        /// The index to get a reference to. This is in terms of the destination type, and is not a byte offset (i.e.
        /// the index is multiplied by the size of the destination type to get the byte offset)
        /// </param>
        /// <typeparam name="T">The type of the reference to return.</typeparam>
        /// <returns>A reference to global memory.</returns>
        public ref T AsRef<T>(int index = 0) where T : unmanaged 
            => ref Unsafe.Add(ref Unsafe.As<byte, T>(ref GetPinnableReference()), index);
        
        /// <summary>
        /// Gets a pointer of the given type to a specific index within this block of global memory.
        /// </summary>
        /// <param name="index">
        /// The index to get a pointer to. This is in terms of the destination type, and is not a byte offset (i.e.
        /// the index is multiplied by the size of the destination type to get the byte offset)
        /// </param>
        /// <typeparam name="T">The type of the pointer to return.</typeparam>
        /// <returns>A pointer to global memory.</returns>
        public unsafe T* AsPtr<T>(int index = 0) where T : unmanaged => (T*) Unsafe.AsPointer(ref AsRef<T>(index)); 

        /// <summary>
        /// Gets a span representing this block of global memory.
        /// </summary>
        /// <returns>A span of global memory.</returns>
        public static implicit operator Span<byte>(GlobalMemory left) => left.AsSpan();

        /// <summary>
        /// Gets a handle to this block of global memory.
        /// </summary>
        /// <returns>A handle to this block of global memory.</returns>
        public static unsafe implicit operator void*(GlobalMemory left) => (void*) left.Handle;


        /// <summary>
        /// Gets a handle to this block of global memory.
        /// </summary>
        /// <returns>A handle to this block of global memory.</returns>
        public static implicit operator nint(GlobalMemory left) => left.Handle;

        /// <summary>
        /// Gets a reference to the global memory. This reference is valid until this object is disposed or finalized.
        /// </summary>
        /// <returns>A reference to the global memory.</returns>
        public unsafe ref byte GetPinnableReference()
            => ref _memoryObject is IGlobalMemory hGlobal
                ? ref *(byte*) hGlobal.Handle
                : ref ((byte[]) _memoryObject)[0];

        private unsafe void Free()
        {
            if (_stringArrayCount != 0)
            {
                var span = AsSpan<IntPtr>();
                for (var index = 0; index < _stringArrayCount; index++)
                {
                    var intPtr = span[index];
                    SilkMarshal.Free(intPtr);
                }

                _stringArrayCount = 0;
            }
            switch (_memoryObject)
            {
                case HGlobal hGlobal:
                {
                    Marshal.FreeHGlobal(hGlobal.Handle);
                    break;
                }
                case BStr bStr:
                {
                    Marshal.FreeBSTR(bStr.Handle);
                    break;
                }
                case GCHandleByteArray byteArray:
                {
                    byteArray.GCHandle.Free();
                    break;
                }
#if NET6_0_OR_GREATER
                case NativeMemoryPtr nativeMemoryPtr:
                {
                    NativeMemory.Free((void*)nativeMemoryPtr.Handle);
                    break;
                }
#endif
            }

            _freed = true;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Free();
            GC.SuppressFinalize(this);
        }

        ~GlobalMemory()
        {
            Free();
        }

        // Allocation methods
        /// <summary>
        /// Allocates a block of global memory of the given length.
        /// </summary>
        /// <param name="length">The number of bytes to allocate.</param>
        /// <returns>A block of global memory.</returns>
        public static GlobalMemory Allocate(int length) =>
#if NET6_0_OR_GREATER
            new GlobalMemory(new NativeMemoryPtr(length), length > 0 ? length : 1);
#elif NET5_0
            new GlobalMemory(GC.AllocateUninitializedArray<byte>(length > 0 ? length : 1, true), length);
#else
            new GlobalMemory(new GCHandleByteArray(length), length > 0 ? length : 1);
#endif

        internal static GlobalMemory AllocateForStringArray(int length, int count) =>
#if NET6_0_OR_GREATER
            new GlobalMemory(new NativeMemoryPtr(length), length > 0 ? length : 1, count);
#elif NET5_0
            new GlobalMemory(GC.AllocateUninitializedArray<byte>(length > 0 ? length : 1, true), length, count);
#else
            new GlobalMemory(new GCHandleByteArray(length), length > 0 ? length : 1, count);
#endif

        // Encapsulations different kinds of memory
        private interface IGlobalMemory
        {
            nint Handle { get; }
        }
        
        private struct GCHandleByteArray : IGlobalMemory
        {
            public GCHandleByteArray(int length) => GCHandle = GCHandle.Alloc(new byte[length], GCHandleType.Pinned);
            public GCHandle GCHandle { get; }
            public nint Handle => GCHandle.AddrOfPinnedObject();
        }

        private readonly struct HGlobal : IGlobalMemory
        {
            public HGlobal(int length) => Handle = Marshal.AllocHGlobal(length);
            public HGlobal(nint val) => Handle = val;
            public nint Handle { get; }
        }

        private readonly struct BStr : IGlobalMemory
        {
            public BStr(int length) => Handle = SilkMarshal.AllocBStr(length);
            public BStr(nint val) => Handle = val;
            public nint Handle { get; }
        }
        
        private readonly struct Other : IGlobalMemory
        {
            // used for "unsafe" marshalling of a pointer to our neat GlobalMemory class if that's your thing.
            public Other(nint val) => Handle = val;
            public nint Handle { get; }
        }

#if NET6_0_OR_GREATER
        private unsafe readonly struct NativeMemoryPtr : IGlobalMemory
        {
            public NativeMemoryPtr(int length) => Handle = (nint) NativeMemory.Alloc((nuint) length);
            public NativeMemoryPtr(nint val) => Handle = val;
            public nint Handle { get; }
        }
#endif

        // "Unsafe" methods
        internal static GlobalMemory FromHGlobal(nint hGlobal, int len)
            => new GlobalMemory(new HGlobal(hGlobal), len);
        
        internal static GlobalMemory FromBStr(nint bStr, int len)
            => new GlobalMemory(new BStr(bStr), len);
        
        internal static GlobalMemory FromAnyPtr(nint val, int len)
            => new GlobalMemory(new Other(val), len);
    }
}
