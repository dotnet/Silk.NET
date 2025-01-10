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

[Guid("E9550983-360B-4F53-B391-AFD695078691")]
[NativeTypeName("struct IVirtualSurfaceImageSourceNative : ISurfaceImageSourceNative")]
[NativeInheritance("ISurfaceImageSourceNative")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IVirtualSurfaceImageSourceNative
    : IVirtualSurfaceImageSourceNative.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVirtualSurfaceImageSourceNative));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVirtualSurfaceImageSourceNative, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDevice(IDXGIDevice device)
    {
        return (
            (delegate* unmanaged<IVirtualSurfaceImageSourceNative, IDXGIDevice, int>)((*lpVtbl)[3])
        )(this, device);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginDraw(RECT updateRect, IDXGISurface* surface, POINT* offset)
    {
        return (
            (delegate* unmanaged<
                IVirtualSurfaceImageSourceNative,
                RECT,
                IDXGISurface*,
                POINT*,
                int>)((*lpVtbl)[4])
        )(this, updateRect, surface, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invalidate(RECT updateRect)
    {
        return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative, RECT, int>)((*lpVtbl)[6]))(
            this,
            updateRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdateRectCount([NativeTypeName("DWORD *")] uint* count)
    {
        return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative, uint*, int>)((*lpVtbl)[7]))(
            this,
            count
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUpdateRects(RECT* updates, [NativeTypeName("DWORD")] uint count)
    {
        return (
            (delegate* unmanaged<IVirtualSurfaceImageSourceNative, RECT*, uint, int>)((*lpVtbl)[8])
        )(this, updates, count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetVisibleBounds(RECT* bounds)
    {
        return ((delegate* unmanaged<IVirtualSurfaceImageSourceNative, RECT*, int>)((*lpVtbl)[9]))(
            this,
            bounds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterForUpdatesNeeded(IVirtualSurfaceUpdatesCallbackNative callback)
    {
        return (
            (delegate* unmanaged<
                IVirtualSurfaceImageSourceNative,
                IVirtualSurfaceUpdatesCallbackNative,
                int>)((*lpVtbl)[10])
        )(this, callback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Resize(int newWidth, int newHeight)
    {
        return (
            (delegate* unmanaged<IVirtualSurfaceImageSourceNative, int, int, int>)((*lpVtbl)[11])
        )(this, newWidth, newHeight);
    }

    public interface Interface : ISurfaceImageSourceNative.Interface
    {
        [VtblIndex(6)]
        HRESULT Invalidate(RECT updateRect);

        [VtblIndex(7)]
        HRESULT GetUpdateRectCount([NativeTypeName("DWORD *")] uint* count);

        [VtblIndex(8)]
        HRESULT GetUpdateRects(RECT* updates, [NativeTypeName("DWORD")] uint count);

        [VtblIndex(9)]
        HRESULT GetVisibleBounds(RECT* bounds);

        [VtblIndex(10)]
        HRESULT RegisterForUpdatesNeeded(IVirtualSurfaceUpdatesCallbackNative callback);

        [VtblIndex(11)]
        HRESULT Resize(int newWidth, int newHeight);
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

        [NativeTypeName("HRESULT (RECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT, int> Invalidate;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUpdateRectCount;

        [NativeTypeName("HRESULT (RECT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, uint, int> GetUpdateRects;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetVisibleBounds;

        [NativeTypeName(
            "HRESULT (IVirtualSurfaceUpdatesCallbackNative *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVirtualSurfaceUpdatesCallbackNative,
            int> RegisterForUpdatesNeeded;

        [NativeTypeName("HRESULT (INT, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> Resize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVirtualSurfaceImageSourceNative"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVirtualSurfaceImageSourceNative(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.ISurfaceImageSourceNative"/> to <see cref = "IVirtualSurfaceImageSourceNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.ISurfaceImageSourceNative"/> instance to be converted </param>
    public static explicit operator IVirtualSurfaceImageSourceNative(
        Silk.NET.WinRT.ISurfaceImageSourceNative value
    )
    {
        return new IVirtualSurfaceImageSourceNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVirtualSurfaceImageSourceNative"/> to <see cref = "Silk.NET.WinRT.ISurfaceImageSourceNative"/>.</summary>
    /// <param name = "value">The <see cref = "IVirtualSurfaceImageSourceNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.ISurfaceImageSourceNative(
        IVirtualSurfaceImageSourceNative value
    )
    {
        return new Silk.NET.WinRT.ISurfaceImageSourceNative(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVirtualSurfaceImageSourceNative"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVirtualSurfaceImageSourceNative(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IVirtualSurfaceImageSourceNative(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVirtualSurfaceImageSourceNative"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVirtualSurfaceImageSourceNative"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IVirtualSurfaceImageSourceNative value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
