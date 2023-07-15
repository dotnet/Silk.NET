// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IPdfRendererNative.xml' path='doc/member[@name="IPdfRendererNative"]/*'/>
[Guid("7D9DCD91-D277-4947-8527-07A0DAEDA94A")]
[NativeTypeName("struct IPdfRendererNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IPdfRendererNative : IPdfRendererNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPdfRendererNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPdfRendererNative*, Guid*, void**, int> )(lpVtbl[0]))((IPdfRendererNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPdfRendererNative*, uint> )(lpVtbl[1]))((IPdfRendererNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPdfRendererNative*, uint> )(lpVtbl[2]))((IPdfRendererNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPdfRendererNative.xml' path='doc/member[@name="IPdfRendererNative.RenderPageToSurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RenderPageToSurface(IUnknown* pdfPage, IDXGISurface* pSurface, POINT offset, PDF_RENDER_PARAMS* pRenderParams)
    {
        return ((delegate* unmanaged<IPdfRendererNative*, IUnknown*, IDXGISurface*, POINT, PDF_RENDER_PARAMS*, int> )(lpVtbl[3]))((IPdfRendererNative*)Unsafe.AsPointer(ref this), pdfPage, pSurface, offset, pRenderParams);
    }

    /// <include file='IPdfRendererNative.xml' path='doc/member[@name="IPdfRendererNative.RenderPageToDeviceContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RenderPageToDeviceContext(IUnknown* pdfPage, ID2D1DeviceContext* pD2DDeviceContext, PDF_RENDER_PARAMS* pRenderParams)
    {
        return ((delegate* unmanaged<IPdfRendererNative*, IUnknown*, ID2D1DeviceContext*, PDF_RENDER_PARAMS*, int> )(lpVtbl[4]))((IPdfRendererNative*)Unsafe.AsPointer(ref this), pdfPage, pD2DDeviceContext, pRenderParams);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RenderPageToSurface(IUnknown* pdfPage, IDXGISurface* pSurface, POINT offset, PDF_RENDER_PARAMS* pRenderParams);
        [VtblIndex(4)]
        HRESULT RenderPageToDeviceContext(IUnknown* pdfPage, ID2D1DeviceContext* pD2DDeviceContext, PDF_RENDER_PARAMS* pRenderParams);
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
        [NativeTypeName("HRESULT (IUnknown *, IDXGISurface *, POINT, PDF_RENDER_PARAMS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IDXGISurface*, POINT, PDF_RENDER_PARAMS*, int> RenderPageToSurface;
        [NativeTypeName("HRESULT (IUnknown *, ID2D1DeviceContext *, PDF_RENDER_PARAMS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, ID2D1DeviceContext*, PDF_RENDER_PARAMS*, int> RenderPageToDeviceContext;
    }
}