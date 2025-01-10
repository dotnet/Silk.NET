// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.26100.0
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

[Guid("F2E9EDC1-D307-4525-9886-0FAFAA44163C")]
[NativeTypeName("struct ISurfaceImageSourceNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISurfaceImageSourceNative
    : ISurfaceImageSourceNative.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurfaceImageSourceNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISurfaceImageSourceNative, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDevice(IDXGIDevice device)
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative, IDXGIDevice, int>)((*lpVtbl)[3]))(
            this,
            device
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginDraw(RECT updateRect, IDXGISurface* surface, POINT* offset)
    {
        return (
            (delegate* unmanaged<ISurfaceImageSourceNative, RECT, IDXGISurface*, POINT*, int>)(
                (*lpVtbl)[4]
            )
        )(this, updateRect, surface, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNative, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDevice(IDXGIDevice device);

        [VtblIndex(4)]
        HRESULT BeginDraw(RECT updateRect, IDXGISurface* surface, POINT* offset);

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
        public delegate* unmanaged<TSelf*, IDXGIDevice, int> SetDevice;

        [NativeTypeName("HRESULT (RECT, IDXGISurface **, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT, IDXGISurface*, POINT*, int> BeginDraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISurfaceImageSourceNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISurfaceImageSourceNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISurfaceImageSourceNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISurfaceImageSourceNative(Silk.NET.Windows.IUnknown value)
    {
        return new ISurfaceImageSourceNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISurfaceImageSourceNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISurfaceImageSourceNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISurfaceImageSourceNative value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
