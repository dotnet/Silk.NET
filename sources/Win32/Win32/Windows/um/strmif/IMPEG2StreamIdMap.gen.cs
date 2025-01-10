// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D0E04C47-25B8-4369-925A-362A01D95444")]
[NativeTypeName("struct IMPEG2StreamIdMap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMPEG2StreamIdMap : IMPEG2StreamIdMap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMPEG2StreamIdMap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMPEG2StreamIdMap, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMPEG2StreamIdMap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMPEG2StreamIdMap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MapStreamId(
        [NativeTypeName("ULONG")] uint ulStreamId,
        [NativeTypeName("DWORD")] uint MediaSampleContent,
        [NativeTypeName("ULONG")] uint ulSubstreamFilterValue,
        int iDataOffset
    )
    {
        return ((delegate* unmanaged<IMPEG2StreamIdMap, uint, uint, uint, int, int>)((*lpVtbl)[3]))(
            this,
            ulStreamId,
            MediaSampleContent,
            ulSubstreamFilterValue,
            iDataOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnmapStreamId(
        [NativeTypeName("ULONG")] uint culStreamId,
        [NativeTypeName("ULONG *")] uint* pulStreamId
    )
    {
        return ((delegate* unmanaged<IMPEG2StreamIdMap, uint, uint*, int>)((*lpVtbl)[4]))(
            this,
            culStreamId,
            pulStreamId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumStreamIdMap(IEnumStreamIdMap* ppIEnumStreamIdMap)
    {
        return ((delegate* unmanaged<IMPEG2StreamIdMap, IEnumStreamIdMap*, int>)((*lpVtbl)[5]))(
            this,
            ppIEnumStreamIdMap
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MapStreamId(
            [NativeTypeName("ULONG")] uint ulStreamId,
            [NativeTypeName("DWORD")] uint MediaSampleContent,
            [NativeTypeName("ULONG")] uint ulSubstreamFilterValue,
            int iDataOffset
        );

        [VtblIndex(4)]
        HRESULT UnmapStreamId(
            [NativeTypeName("ULONG")] uint culStreamId,
            [NativeTypeName("ULONG *")] uint* pulStreamId
        );

        [VtblIndex(5)]
        HRESULT EnumStreamIdMap(IEnumStreamIdMap* ppIEnumStreamIdMap);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, DWORD, ULONG, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int, int> MapStreamId;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> UnmapStreamId;

        [NativeTypeName("HRESULT (IEnumStreamIdMap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumStreamIdMap*, int> EnumStreamIdMap;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMPEG2StreamIdMap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMPEG2StreamIdMap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMPEG2StreamIdMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMPEG2StreamIdMap(Silk.NET.Windows.IUnknown value)
    {
        return new IMPEG2StreamIdMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMPEG2StreamIdMap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMPEG2StreamIdMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMPEG2StreamIdMap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
