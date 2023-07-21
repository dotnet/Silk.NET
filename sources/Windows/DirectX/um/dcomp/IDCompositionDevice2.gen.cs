// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2"]/*' />
[Guid("75F6468D-1B8E-447C-9BC6-75FEA80B5B25")]
[NativeTypeName("struct IDCompositionDevice2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDCompositionDevice2 : IDCompositionDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, uint>)(lpVtbl[1]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, uint>)(lpVtbl[2]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.Commit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, int>)(lpVtbl[3]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.WaitForCommitCompletion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WaitForCommitCompletion()
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, int>)(lpVtbl[4]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.GetFrameStatistics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, DCOMPOSITION_FRAME_STATISTICS*, int>)(lpVtbl[5]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), statistics);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVisual(IDCompositionVisual2** visual)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), visual);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateSurfaceFactory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionSurface** surface)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateVirtualSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionVirtualSurface** virtualSurface)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateTranslateTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), translateTransform);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateScaleTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), scaleTransform);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateRotateTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), rotateTransform);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateSkewTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), skewTransform);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateMatrixTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), matrixTransform);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateTransformGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateTranslateTransform3D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), translateTransform3D);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateScaleTransform3D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), scaleTransform3D);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateRotateTransform3D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), rotateTransform3D);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateMatrixTransform3D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), matrixTransform3D);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateTransform3DGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateEffectGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), effectGroup);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateRectangleClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRectangleClip(IDCompositionRectangleClip** clip)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), clip);
    }

    /// <include file='IDCompositionDevice2.xml' path='doc/member[@name="IDCompositionDevice2.CreateAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateAnimation(IDCompositionAnimation** animation)
    {
        return ((delegate* unmanaged<IDCompositionDevice2*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDevice2*)Unsafe.AsPointer(ref this), animation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Commit();

        [VtblIndex(4)]
        HRESULT WaitForCommitCompletion();

        [VtblIndex(5)]
        HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics);

        [VtblIndex(6)]
        HRESULT CreateVisual(IDCompositionVisual2** visual);

        [VtblIndex(7)]
        HRESULT CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory);

        [VtblIndex(8)]
        HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionSurface** surface);

        [VtblIndex(9)]
        HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionVirtualSurface** virtualSurface);

        [VtblIndex(10)]
        HRESULT CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform);

        [VtblIndex(11)]
        HRESULT CreateScaleTransform(IDCompositionScaleTransform** scaleTransform);

        [VtblIndex(12)]
        HRESULT CreateRotateTransform(IDCompositionRotateTransform** rotateTransform);

        [VtblIndex(13)]
        HRESULT CreateSkewTransform(IDCompositionSkewTransform** skewTransform);

        [VtblIndex(14)]
        HRESULT CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform);

        [VtblIndex(15)]
        HRESULT CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup);

        [VtblIndex(16)]
        HRESULT CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D);

        [VtblIndex(17)]
        HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D);

        [VtblIndex(18)]
        HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D);

        [VtblIndex(19)]
        HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D);

        [VtblIndex(20)]
        HRESULT CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup);

        [VtblIndex(21)]
        HRESULT CreateEffectGroup(IDCompositionEffectGroup** effectGroup);

        [VtblIndex(22)]
        HRESULT CreateRectangleClip(IDCompositionRectangleClip** clip);

        [VtblIndex(23)]
        HRESULT CreateAnimation(IDCompositionAnimation** animation);
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

        [NativeTypeName("HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_FRAME_STATISTICS*, int> GetFrameStatistics;

        [NativeTypeName("HRESULT (IDCompositionVisual2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionVisual2**, int> CreateVisual;

        [NativeTypeName("HRESULT (IUnknown *, IDCompositionSurfaceFactory **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IDCompositionSurfaceFactory**, int> CreateSurfaceFactory;

        [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int> CreateSurface;

        [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int> CreateVirtualSurface;

        [NativeTypeName("HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTranslateTransform**, int> CreateTranslateTransform;

        [NativeTypeName("HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionScaleTransform**, int> CreateScaleTransform;

        [NativeTypeName("HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionRotateTransform**, int> CreateRotateTransform;

        [NativeTypeName("HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionSkewTransform**, int> CreateSkewTransform;

        [NativeTypeName("HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionMatrixTransform**, int> CreateMatrixTransform;

        [NativeTypeName("HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTransform**, uint, IDCompositionTransform**, int> CreateTransformGroup;

        [NativeTypeName("HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTranslateTransform3D**, int> CreateTranslateTransform3D;

        [NativeTypeName("HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionScaleTransform3D**, int> CreateScaleTransform3D;

        [NativeTypeName("HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionRotateTransform3D**, int> CreateRotateTransform3D;

        [NativeTypeName("HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionMatrixTransform3D**, int> CreateMatrixTransform3D;

        [NativeTypeName("HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int> CreateTransform3DGroup;

        [NativeTypeName("HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionEffectGroup**, int> CreateEffectGroup;

        [NativeTypeName("HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionRectangleClip**, int> CreateRectangleClip;

        [NativeTypeName("HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation**, int> CreateAnimation;
    }
}
