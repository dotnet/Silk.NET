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
/// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3"]/*'/>
[Guid("0987CB06-F916-48BF-8D35-CE7641781BD9")]
[NativeTypeName("struct IDCompositionDevice3 : IDCompositionDevice2")]
[NativeInheritance("IDCompositionDevice2")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDCompositionDevice3 : IDCompositionDevice3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, uint> )(lpVtbl[1]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, uint> )(lpVtbl[2]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionDevice2.Commit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, int> )(lpVtbl[3]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionDevice2.WaitForCommitCompletion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WaitForCommitCompletion()
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, int> )(lpVtbl[4]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionDevice2.GetFrameStatistics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, DCOMPOSITION_FRAME_STATISTICS*, int> )(lpVtbl[5]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), statistics);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateVisual"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVisual(IDCompositionVisual2** visual)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionVisual2**, int> )(lpVtbl[6]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), visual);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateSurfaceFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IUnknown*, IDCompositionSurfaceFactory**, int> )(lpVtbl[7]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface(uint width, uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionSurface** surface)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface**, int> )(lpVtbl[8]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateVirtualSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVirtualSurface(uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, IDCompositionVirtualSurface** virtualSurface)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, uint, uint, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface**, int> )(lpVtbl[9]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateTranslateTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTranslateTransform**, int> )(lpVtbl[10]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateScaleTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionScaleTransform**, int> )(lpVtbl[11]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateRotateTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRotateTransform**, int> )(lpVtbl[12]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateSkewTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionSkewTransform**, int> )(lpVtbl[13]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), skewTransform);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateMatrixTransform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionMatrixTransform**, int> )(lpVtbl[14]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateTransformGroup"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int> )(lpVtbl[15]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateTranslateTransform3D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int> )(lpVtbl[16]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), translateTransform3D);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateScaleTransform3D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int> )(lpVtbl[17]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), scaleTransform3D);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateRotateTransform3D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int> )(lpVtbl[18]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), rotateTransform3D);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateMatrixTransform3D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int> )(lpVtbl[19]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), matrixTransform3D);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateTransform3DGroup"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int> )(lpVtbl[20]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateEffectGroup"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionEffectGroup**, int> )(lpVtbl[21]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), effectGroup);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateRectangleClip"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRectangleClip(IDCompositionRectangleClip** clip)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionRectangleClip**, int> )(lpVtbl[22]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), clip);
    }

    /// <inheritdoc cref = "IDCompositionDevice2.CreateAnimation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateAnimation(IDCompositionAnimation** animation)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionAnimation**, int> )(lpVtbl[23]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateGaussianBlurEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateGaussianBlurEffect(IDCompositionGaussianBlurEffect** gaussianBlurEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int> )(lpVtbl[24]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), gaussianBlurEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateBrightnessEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateBrightnessEffect(IDCompositionBrightnessEffect** brightnessEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int> )(lpVtbl[25]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), brightnessEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateColorMatrixEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateColorMatrixEffect(IDCompositionColorMatrixEffect** colorMatrixEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int> )(lpVtbl[26]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), colorMatrixEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateShadowEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateShadowEffect(IDCompositionShadowEffect** shadowEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionShadowEffect**, int> )(lpVtbl[27]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), shadowEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateHueRotationEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateHueRotationEffect(IDCompositionHueRotationEffect** hueRotationEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int> )(lpVtbl[28]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), hueRotationEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateSaturationEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateSaturationEffect(IDCompositionSaturationEffect** saturationEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionSaturationEffect**, int> )(lpVtbl[29]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), saturationEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateTurbulenceEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateTurbulenceEffect(IDCompositionTurbulenceEffect** turbulenceEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int> )(lpVtbl[30]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), turbulenceEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateLinearTransferEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateLinearTransferEffect(IDCompositionLinearTransferEffect** linearTransferEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int> )(lpVtbl[31]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), linearTransferEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateTableTransferEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CreateTableTransferEffect(IDCompositionTableTransferEffect** tableTransferEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int> )(lpVtbl[32]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), tableTransferEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateCompositeEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CreateCompositeEffect(IDCompositionCompositeEffect** compositeEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionCompositeEffect**, int> )(lpVtbl[33]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), compositeEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateBlendEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT CreateBlendEffect(IDCompositionBlendEffect** blendEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionBlendEffect**, int> )(lpVtbl[34]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), blendEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateArithmeticCompositeEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT CreateArithmeticCompositeEffect(IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int> )(lpVtbl[35]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), arithmeticCompositeEffect);
    }

    /// <include file='IDCompositionDevice3.xml' path='doc/member[@name="IDCompositionDevice3.CreateAffineTransform2DEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateAffineTransform2DEffect(IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
    {
        return ((delegate* unmanaged<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int> )(lpVtbl[36]))((IDCompositionDevice3*)Unsafe.AsPointer(ref this), affineTransform2dEffect);
    }

    public interface Interface : IDCompositionDevice2.Interface
    {
        [VtblIndex(24)]
        HRESULT CreateGaussianBlurEffect(IDCompositionGaussianBlurEffect** gaussianBlurEffect);
        [VtblIndex(25)]
        HRESULT CreateBrightnessEffect(IDCompositionBrightnessEffect** brightnessEffect);
        [VtblIndex(26)]
        HRESULT CreateColorMatrixEffect(IDCompositionColorMatrixEffect** colorMatrixEffect);
        [VtblIndex(27)]
        HRESULT CreateShadowEffect(IDCompositionShadowEffect** shadowEffect);
        [VtblIndex(28)]
        HRESULT CreateHueRotationEffect(IDCompositionHueRotationEffect** hueRotationEffect);
        [VtblIndex(29)]
        HRESULT CreateSaturationEffect(IDCompositionSaturationEffect** saturationEffect);
        [VtblIndex(30)]
        HRESULT CreateTurbulenceEffect(IDCompositionTurbulenceEffect** turbulenceEffect);
        [VtblIndex(31)]
        HRESULT CreateLinearTransferEffect(IDCompositionLinearTransferEffect** linearTransferEffect);
        [VtblIndex(32)]
        HRESULT CreateTableTransferEffect(IDCompositionTableTransferEffect** tableTransferEffect);
        [VtblIndex(33)]
        HRESULT CreateCompositeEffect(IDCompositionCompositeEffect** compositeEffect);
        [VtblIndex(34)]
        HRESULT CreateBlendEffect(IDCompositionBlendEffect** blendEffect);
        [VtblIndex(35)]
        HRESULT CreateArithmeticCompositeEffect(IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect);
        [VtblIndex(36)]
        HRESULT CreateAffineTransform2DEffect(IDCompositionAffineTransform2DEffect** affineTransform2dEffect);
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
        [NativeTypeName("HRESULT (IDCompositionGaussianBlurEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionGaussianBlurEffect**, int> CreateGaussianBlurEffect;
        [NativeTypeName("HRESULT (IDCompositionBrightnessEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionBrightnessEffect**, int> CreateBrightnessEffect;
        [NativeTypeName("HRESULT (IDCompositionColorMatrixEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionColorMatrixEffect**, int> CreateColorMatrixEffect;
        [NativeTypeName("HRESULT (IDCompositionShadowEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionShadowEffect**, int> CreateShadowEffect;
        [NativeTypeName("HRESULT (IDCompositionHueRotationEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionHueRotationEffect**, int> CreateHueRotationEffect;
        [NativeTypeName("HRESULT (IDCompositionSaturationEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionSaturationEffect**, int> CreateSaturationEffect;
        [NativeTypeName("HRESULT (IDCompositionTurbulenceEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTurbulenceEffect**, int> CreateTurbulenceEffect;
        [NativeTypeName("HRESULT (IDCompositionLinearTransferEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionLinearTransferEffect**, int> CreateLinearTransferEffect;
        [NativeTypeName("HRESULT (IDCompositionTableTransferEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionTableTransferEffect**, int> CreateTableTransferEffect;
        [NativeTypeName("HRESULT (IDCompositionCompositeEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionCompositeEffect**, int> CreateCompositeEffect;
        [NativeTypeName("HRESULT (IDCompositionBlendEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionBlendEffect**, int> CreateBlendEffect;
        [NativeTypeName("HRESULT (IDCompositionArithmeticCompositeEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionArithmeticCompositeEffect**, int> CreateArithmeticCompositeEffect;
        [NativeTypeName("HRESULT (IDCompositionAffineTransform2DEffect **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAffineTransform2DEffect**, int> CreateAffineTransform2DEffect;
    }
}