// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7D9DCD91-D277-4947-8527-07A0DAEDA94A")]
[NativeTypeName("struct IPdfRendererNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IPdfRendererNative : IPdfRendererNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPdfRendererNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPdfRendererNative, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPdfRendererNative, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPdfRendererNative, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RenderPageToSurface(
        IUnknown pdfPage,
        IDXGISurface pSurface,
        POINT offset,
        PDF_RENDER_PARAMS* pRenderParams
    )
    {
        return (
            (delegate* unmanaged<
                IPdfRendererNative,
                IUnknown,
                IDXGISurface,
                POINT,
                PDF_RENDER_PARAMS*,
                int>)((*lpVtbl)[3])
        )(this, pdfPage, pSurface, offset, pRenderParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RenderPageToDeviceContext(
        IUnknown pdfPage,
        ID2D1DeviceContext pD2DDeviceContext,
        PDF_RENDER_PARAMS* pRenderParams
    )
    {
        return (
            (delegate* unmanaged<
                IPdfRendererNative,
                IUnknown,
                ID2D1DeviceContext,
                PDF_RENDER_PARAMS*,
                int>)((*lpVtbl)[4])
        )(this, pdfPage, pD2DDeviceContext, pRenderParams);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RenderPageToSurface(
            IUnknown pdfPage,
            IDXGISurface pSurface,
            POINT offset,
            PDF_RENDER_PARAMS* pRenderParams
        );

        [VtblIndex(4)]
        HRESULT RenderPageToDeviceContext(
            IUnknown pdfPage,
            ID2D1DeviceContext pD2DDeviceContext,
            PDF_RENDER_PARAMS* pRenderParams
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
            "HRESULT (IUnknown *, IDXGISurface *, POINT, PDF_RENDER_PARAMS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IDXGISurface,
            POINT,
            PDF_RENDER_PARAMS*,
            int> RenderPageToSurface;

        [NativeTypeName(
            "HRESULT (IUnknown *, ID2D1DeviceContext *, PDF_RENDER_PARAMS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            ID2D1DeviceContext,
            PDF_RENDER_PARAMS*,
            int> RenderPageToDeviceContext;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPdfRendererNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPdfRendererNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPdfRendererNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPdfRendererNative(Silk.NET.Windows.IUnknown value)
    {
        return new IPdfRendererNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPdfRendererNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPdfRendererNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPdfRendererNative value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
