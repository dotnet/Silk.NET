// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_DATA_CHUNK
{
    public HTTP_DATA_CHUNK_TYPE DataChunkType;

    [NativeTypeName("__AnonymousRecord_http_L1292_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._FromMemory_e__Struct FromMemory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FromMemory; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._FromFileHandle_e__Struct FromFileHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FromFileHandle; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._FromFragmentCache_e__Struct FromFragmentCache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FromFragmentCache; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._FromFragmentCacheEx_e__Struct FromFragmentCacheEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FromFragmentCacheEx; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Trailers_e__Struct Trailers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Trailers; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._FromWinHttpFastForwarding_e__Struct FromWinHttpFastForwarding
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FromWinHttpFastForwarding; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1298_C9")]
        public _FromMemory_e__Struct FromMemory;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1309_C9")]
        public _FromFileHandle_e__Struct FromFileHandle;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1320_C9")]
        public _FromFragmentCache_e__Struct FromFragmentCache;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1331_C9")]
        public _FromFragmentCacheEx_e__Struct FromFragmentCacheEx;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1342_C9")]
        public _Trailers_e__Struct Trailers;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_http_L1349_C9")]
        public _FromWinHttpFastForwarding_e__Struct FromWinHttpFastForwarding;

        public unsafe partial struct _FromMemory_e__Struct
        {
            [NativeTypeName("PVOID")]
            public void* pBuffer;

            [NativeTypeName("ULONG")]
            public uint BufferLength;
        }

        public partial struct _FromFileHandle_e__Struct
        {
            public HTTP_BYTE_RANGE ByteRange;
            public HANDLE FileHandle;
        }

        public unsafe partial struct _FromFragmentCache_e__Struct
        {
            public ushort FragmentNameLength;

            [NativeTypeName("PCWSTR")]
            public ushort* pFragmentName;
        }

        public unsafe partial struct _FromFragmentCacheEx_e__Struct
        {
            public HTTP_BYTE_RANGE ByteRange;

            [NativeTypeName("PCWSTR")]
            public ushort* pFragmentName;
        }

        public unsafe partial struct _Trailers_e__Struct
        {
            public ushort TrailerCount;

            [NativeTypeName("PHTTP_UNKNOWN_HEADER")]
            public HTTP_UNKNOWN_HEADER* pTrailers;
        }

        public partial struct _FromWinHttpFastForwarding_e__Struct
        {
            public HTTP_WINHTTP_FAST_FORWARDING_DATA WhFastForwardingData;
        }
    }
}
