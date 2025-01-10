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

[Guid("2E69F9E8-DD3F-4BF9-95BA-C04F49D788DF")]
[NativeTypeName("struct ID2D1GdiMetafile1 : ID2D1GdiMetafile")]
[NativeInheritance("ID2D1GdiMetafile")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID2D1GdiMetafile1 : ID2D1GdiMetafile1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GdiMetafile1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1GdiMetafile1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1GdiMetafile1, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stream(ID2D1GdiMetafileSink sink)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1, ID2D1GdiMetafileSink, int>)((*lpVtbl)[4]))(
            this,
            sink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1, D2D_RECT_F*, int>)((*lpVtbl)[5]))(
            this,
            bounds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDpi(float* dpiX, float* dpiY)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1, float*, float*, int>)((*lpVtbl)[6]))(
            this,
            dpiX,
            dpiY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSourceBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
    {
        return ((delegate* unmanaged<ID2D1GdiMetafile1, D2D_RECT_F*, int>)((*lpVtbl)[7]))(
            this,
            bounds
        );
    }

    public interface Interface : ID2D1GdiMetafile.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDpi(float* dpiX, float* dpiY);

        [VtblIndex(7)]
        HRESULT GetSourceBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);
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
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName(
            "HRESULT (ID2D1GdiMetafileSink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1GdiMetafileSink, int> Stream;

        [NativeTypeName(
            "HRESULT (D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, int> GetBounds;

        [NativeTypeName(
            "HRESULT (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, float*, int> GetDpi;

        [NativeTypeName(
            "HRESULT (D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, int> GetSourceBounds;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1GdiMetafile1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1GdiMetafile1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1GdiMetafile"/> to <see cref = "ID2D1GdiMetafile1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1GdiMetafile"/> instance to be converted </param>
    public static explicit operator ID2D1GdiMetafile1(Silk.NET.DirectX.ID2D1GdiMetafile value)
    {
        return new ID2D1GdiMetafile1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GdiMetafile1"/> to <see cref = "Silk.NET.DirectX.ID2D1GdiMetafile"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GdiMetafile1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1GdiMetafile(ID2D1GdiMetafile1 value)
    {
        return new Silk.NET.DirectX.ID2D1GdiMetafile(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1GdiMetafile1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1GdiMetafile1(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1GdiMetafile1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GdiMetafile1"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GdiMetafile1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1GdiMetafile1 value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1GdiMetafile1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1GdiMetafile1(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1GdiMetafile1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1GdiMetafile1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1GdiMetafile1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1GdiMetafile1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
