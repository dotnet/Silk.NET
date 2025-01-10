// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("5F4633FE-1E08-4CB8-8C75-CE24333F5602")]
[NativeTypeName("struct IDCompositionDesktopDevice : IDCompositionDevice2")]
[NativeInheritance("IDCompositionDevice2")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDCompositionDesktopDevice
    : IDCompositionDesktopDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDesktopDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionDesktopDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionDesktopDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IDCompositionDesktopDevice, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WaitForCommitCompletion()
    {
        return ((delegate* unmanaged<IDCompositionDesktopDevice, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, DCOMPOSITION_FRAME_STATISTICS*, int>)(
                (*lpVtbl)[5]
            )
        )(this, statistics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVisual(IDCompositionVisual2* visual)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionVisual2*, int>)(
                (*lpVtbl)[6]
            )
        )(this, visual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSurfaceFactory(
        IUnknown renderingDevice,
        IDCompositionSurfaceFactory* surfaceFactory
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                IUnknown,
                IDCompositionSurfaceFactory*,
                int>)((*lpVtbl)[7])
        )(this, renderingDevice, surfaceFactory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface(
        uint width,
        uint height,
        DXGI_FORMAT pixelFormat,
        DXGI_ALPHA_MODE alphaMode,
        IDCompositionSurface* surface
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                uint,
                uint,
                DXGI_FORMAT,
                DXGI_ALPHA_MODE,
                IDCompositionSurface*,
                int>)((*lpVtbl)[8])
        )(this, width, height, pixelFormat, alphaMode, surface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVirtualSurface(
        uint initialWidth,
        uint initialHeight,
        DXGI_FORMAT pixelFormat,
        DXGI_ALPHA_MODE alphaMode,
        IDCompositionVirtualSurface* virtualSurface
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                uint,
                uint,
                DXGI_FORMAT,
                DXGI_ALPHA_MODE,
                IDCompositionVirtualSurface*,
                int>)((*lpVtbl)[9])
        )(this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateTranslateTransform(IDCompositionTranslateTransform* translateTransform)
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                IDCompositionTranslateTransform*,
                int>)((*lpVtbl)[10])
        )(this, translateTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateScaleTransform(IDCompositionScaleTransform* scaleTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionScaleTransform*, int>)(
                (*lpVtbl)[11]
            )
        )(this, scaleTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateRotateTransform(IDCompositionRotateTransform* rotateTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionRotateTransform*, int>)(
                (*lpVtbl)[12]
            )
        )(this, rotateTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateSkewTransform(IDCompositionSkewTransform* skewTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionSkewTransform*, int>)(
                (*lpVtbl)[13]
            )
        )(this, skewTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateMatrixTransform(IDCompositionMatrixTransform* matrixTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionMatrixTransform*, int>)(
                (*lpVtbl)[14]
            )
        )(this, matrixTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateTransformGroup(
        IDCompositionTransform* transforms,
        uint elements,
        IDCompositionTransform* transformGroup
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                IDCompositionTransform*,
                uint,
                IDCompositionTransform*,
                int>)((*lpVtbl)[15])
        )(this, transforms, elements, transformGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateTranslateTransform3D(
        IDCompositionTranslateTransform3D* translateTransform3D
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                IDCompositionTranslateTransform3D*,
                int>)((*lpVtbl)[16])
        )(this, translateTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D* scaleTransform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionScaleTransform3D*, int>)(
                (*lpVtbl)[17]
            )
        )(this, scaleTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D* rotateTransform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionRotateTransform3D*, int>)(
                (*lpVtbl)[18]
            )
        )(this, rotateTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D* matrixTransform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionMatrixTransform3D*, int>)(
                (*lpVtbl)[19]
            )
        )(this, matrixTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateTransform3DGroup(
        IDCompositionTransform3D* transforms3D,
        uint elements,
        IDCompositionTransform3D* transform3DGroup
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                IDCompositionTransform3D*,
                uint,
                IDCompositionTransform3D*,
                int>)((*lpVtbl)[20])
        )(this, transforms3D, elements, transform3DGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateEffectGroup(IDCompositionEffectGroup* effectGroup)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionEffectGroup*, int>)(
                (*lpVtbl)[21]
            )
        )(this, effectGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRectangleClip(IDCompositionRectangleClip* clip)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionRectangleClip*, int>)(
                (*lpVtbl)[22]
            )
        )(this, clip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateAnimation(IDCompositionAnimation* animation)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, IDCompositionAnimation*, int>)(
                (*lpVtbl)[23]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateTargetForHwnd(HWND hwnd, BOOL topmost, IDCompositionTarget* target)
    {
        return (
            (delegate* unmanaged<
                IDCompositionDesktopDevice,
                HWND,
                BOOL,
                IDCompositionTarget*,
                int>)((*lpVtbl)[24])
        )(this, hwnd, topmost, target);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateSurfaceFromHandle(HANDLE handle, IUnknown* surface)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, HANDLE, IUnknown*, int>)((*lpVtbl)[25])
        )(this, handle, surface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateSurfaceFromHwnd(HWND hwnd, IUnknown* surface)
    {
        return (
            (delegate* unmanaged<IDCompositionDesktopDevice, HWND, IUnknown*, int>)((*lpVtbl)[26])
        )(this, hwnd, surface);
    }

    public interface Interface : IDCompositionDevice2.Interface
    {
        [VtblIndex(24)]
        HRESULT CreateTargetForHwnd(HWND hwnd, BOOL topmost, IDCompositionTarget* target);

        [VtblIndex(25)]
        HRESULT CreateSurfaceFromHandle(HANDLE handle, IUnknown* surface);

        [VtblIndex(26)]
        HRESULT CreateSurfaceFromHwnd(HWND hwnd, IUnknown* surface);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WaitForCommitCompletion;

        [NativeTypeName(
            "HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_FRAME_STATISTICS*, int> GetFrameStatistics;

        [NativeTypeName(
            "HRESULT (IDCompositionVisual2 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionVisual2*, int> CreateVisual;

        [NativeTypeName(
            "HRESULT (IUnknown *, IDCompositionSurfaceFactory **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IDCompositionSurfaceFactory*,
            int> CreateSurfaceFactory;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_FORMAT,
            DXGI_ALPHA_MODE,
            IDCompositionSurface*,
            int> CreateSurface;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_FORMAT,
            DXGI_ALPHA_MODE,
            IDCompositionVirtualSurface*,
            int> CreateVirtualSurface;

        [NativeTypeName(
            "HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTranslateTransform*,
            int> CreateTranslateTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionScaleTransform*, int> CreateScaleTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionRotateTransform*,
            int> CreateRotateTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionSkewTransform*, int> CreateSkewTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionMatrixTransform*,
            int> CreateMatrixTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTransform*,
            uint,
            IDCompositionTransform*,
            int> CreateTransformGroup;

        [NativeTypeName(
            "HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTranslateTransform3D*,
            int> CreateTranslateTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionScaleTransform3D*,
            int> CreateScaleTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionRotateTransform3D*,
            int> CreateRotateTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionMatrixTransform3D*,
            int> CreateMatrixTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTransform3D*,
            uint,
            IDCompositionTransform3D*,
            int> CreateTransform3DGroup;

        [NativeTypeName(
            "HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionEffectGroup*, int> CreateEffectGroup;

        [NativeTypeName(
            "HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionRectangleClip*, int> CreateRectangleClip;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> CreateAnimation;

        [NativeTypeName(
            "HRESULT (HWND, BOOL, IDCompositionTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            BOOL,
            IDCompositionTarget*,
            int> CreateTargetForHwnd;

        [NativeTypeName(
            "HRESULT (HANDLE, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HANDLE, IUnknown*, int> CreateSurfaceFromHandle;

        [NativeTypeName(
            "HRESULT (HWND, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HWND, IUnknown*, int> CreateSurfaceFromHwnd;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionDesktopDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionDesktopDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionDevice2"/> to <see cref = "IDCompositionDesktopDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionDevice2"/> instance to be converted </param>
    public static explicit operator IDCompositionDesktopDevice(
        Silk.NET.DirectX.IDCompositionDevice2 value
    )
    {
        return new IDCompositionDesktopDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionDesktopDevice"/> to <see cref = "Silk.NET.DirectX.IDCompositionDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionDesktopDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionDevice2(
        IDCompositionDesktopDevice value
    )
    {
        return new Silk.NET.DirectX.IDCompositionDevice2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionDesktopDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionDesktopDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionDesktopDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionDesktopDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionDesktopDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionDesktopDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
