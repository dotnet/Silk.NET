// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
[NativeTypeName("struct ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink")]
[NativeInheritance("ID2D1GdiMetafileSink")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafileSink1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProcessRecord(
        [NativeTypeName("DWORD")] uint recordType,
        [NativeTypeName("const void *")] void* recordData,
        [NativeTypeName("DWORD")] uint recordDataSize
    )
    {
        return ((delegate* unmanaged<ID2D1GdiMetafileSink1, uint, void*, uint, int>)((*lpVtbl)[3]))(
            this,
            recordType,
            recordData,
            recordDataSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ProcessRecord(
        [NativeTypeName("DWORD")] uint recordType,
        [NativeTypeName("const void *")] void* recordData,
        [NativeTypeName("DWORD")] uint recordDataSize,
        [NativeTypeName("UINT32")] uint flags
    )
    {
        return (
            (delegate* unmanaged<ID2D1GdiMetafileSink1, uint, void*, uint, uint, int>)((*lpVtbl)[4])
        )(this, recordType, recordData, recordDataSize, flags);
    }

    public interface Interface : ID2D1GdiMetafileSink.Interface
    {
        [VtblIndex(4)]
        HRESULT ProcessRecord(
            [NativeTypeName("DWORD")] uint recordType,
            [NativeTypeName("const void *")] void* recordData,
            [NativeTypeName("DWORD")] uint recordDataSize,
            [NativeTypeName("UINT32")] uint flags
        );
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

        [NativeTypeName(
            "HRESULT (DWORD, const void *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void*, uint, int> ProcessRecord;

        [NativeTypeName(
            "HRESULT (DWORD, const void *, DWORD, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void*, uint, uint, int> ProcessRecord1;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1GdiMetafileSink1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1GdiMetafileSink1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1GdiMetafileSink"/> to <see cref = "ID2D1GdiMetafileSink1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1GdiMetafileSink"/> instance to be converted </param>
    public static explicit operator ID2D1GdiMetafileSink1(
        Silk.NET.DirectX.ID2D1GdiMetafileSink value
    )
    {
        return new ID2D1GdiMetafileSink1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GdiMetafileSink1"/> to <see cref = "Silk.NET.DirectX.ID2D1GdiMetafileSink"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GdiMetafileSink1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1GdiMetafileSink(
        ID2D1GdiMetafileSink1 value
    )
    {
        return new Silk.NET.DirectX.ID2D1GdiMetafileSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1GdiMetafileSink1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1GdiMetafileSink1(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1GdiMetafileSink1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GdiMetafileSink1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GdiMetafileSink1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1GdiMetafileSink1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
