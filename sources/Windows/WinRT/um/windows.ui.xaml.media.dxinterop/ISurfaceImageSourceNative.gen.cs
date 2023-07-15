// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='ISurfaceImageSourceNative.xml' path='doc/member[@name="ISurfaceImageSourceNative"]/*'/>
[Guid("F2E9EDC1-D307-4525-9886-0FAFAA44163C")]
[NativeTypeName("struct ISurfaceImageSourceNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISurfaceImageSourceNative : ISurfaceImageSourceNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurfaceImageSourceNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative*, Guid*, void**, int> )(lpVtbl[0]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative*, uint> )(lpVtbl[1]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative*, uint> )(lpVtbl[2]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurfaceImageSourceNative.xml' path='doc/member[@name="ISurfaceImageSourceNative.SetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDevice(IDXGIDevice* device)
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative*, IDXGIDevice*, int> )(lpVtbl[3]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), device);
    }

    /// <include file='ISurfaceImageSourceNative.xml' path='doc/member[@name="ISurfaceImageSourceNative.BeginDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginDraw(RECT updateRect, IDXGISurface** surface, POINT* offset)
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative*, RECT, IDXGISurface**, POINT*, int> )(lpVtbl[4]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect, surface, offset);
    }

    /// <include file='ISurfaceImageSourceNative.xml' path='doc/member[@name="ISurfaceImageSourceNative.EndDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative*, int> )(lpVtbl[5]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDevice(IDXGIDevice* device);
        [VtblIndex(4)]
        HRESULT BeginDraw(RECT updateRect, IDXGISurface** surface, POINT* offset);
        [VtblIndex(5)]
        HRESULT EndDraw();
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
        [NativeTypeName("HRESULT (IDXGIDevice *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIDevice*, int> SetDevice;
        [NativeTypeName("HRESULT (RECT, IDXGISurface **, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT, IDXGISurface**, POINT*, int> BeginDraw;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;
    }
}