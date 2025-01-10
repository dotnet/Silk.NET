// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
[NativeTypeName("struct ID2D1ImageSourceFromWic : ID2D1ImageSource")]
[NativeInheritance("ID2D1ImageSource")]
public unsafe partial struct ID2D1ImageSourceFromWic
    : ID2D1ImageSourceFromWic.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSourceFromWic));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1ImageSourceFromWic, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OfferResources()
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TryReclaimResources(BOOL* resourcesDiscarded)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            resourcesDiscarded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, D2D_RECT_U*, int>)((*lpVtbl)[6]))(
            this,
            rectangleToFill
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TrimCache(
        [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve
    )
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic, D2D_RECT_U*, int>)((*lpVtbl)[7]))(
            this,
            rectangleToPreserve
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetSource(IWICBitmapSource* wicBitmapSource)
    {
        ((delegate* unmanaged<ID2D1ImageSourceFromWic, IWICBitmapSource*, void>)((*lpVtbl)[8]))(
            this,
            wicBitmapSource
        );
    }

    public interface Interface : ID2D1ImageSource.Interface
    {
        [VtblIndex(6)]
        HRESULT EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill);

        [VtblIndex(7)]
        HRESULT TrimCache([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve);

        [VtblIndex(8)]
        void GetSource(IWICBitmapSource* wicBitmapSource);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OfferResources;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> TryReclaimResources;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, int> EnsureCached;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, int> TrimCache;

        [NativeTypeName(
            "void (IWICBitmapSource **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, void> GetSource;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1ImageSourceFromWic"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1ImageSourceFromWic(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1ImageSource"/> to <see cref = "ID2D1ImageSourceFromWic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1ImageSource"/> instance to be converted </param>
    public static explicit operator ID2D1ImageSourceFromWic(Silk.NET.DirectX.ID2D1ImageSource value)
    {
        return new ID2D1ImageSourceFromWic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ImageSourceFromWic"/> to <see cref = "Silk.NET.DirectX.ID2D1ImageSource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ImageSourceFromWic"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1ImageSource(ID2D1ImageSourceFromWic value)
    {
        return new Silk.NET.DirectX.ID2D1ImageSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Image"/> to <see cref = "ID2D1ImageSourceFromWic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Image"/> instance to be converted </param>
    public static explicit operator ID2D1ImageSourceFromWic(Silk.NET.DirectX.ID2D1Image value)
    {
        return new ID2D1ImageSourceFromWic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ImageSourceFromWic"/> to <see cref = "Silk.NET.DirectX.ID2D1Image"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ImageSourceFromWic"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Image(ID2D1ImageSourceFromWic value)
    {
        return new Silk.NET.DirectX.ID2D1Image(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1ImageSourceFromWic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1ImageSourceFromWic(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1ImageSourceFromWic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ImageSourceFromWic"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ImageSourceFromWic"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1ImageSourceFromWic value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1ImageSourceFromWic"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1ImageSourceFromWic(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1ImageSourceFromWic(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ImageSourceFromWic"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ImageSourceFromWic"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1ImageSourceFromWic value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
