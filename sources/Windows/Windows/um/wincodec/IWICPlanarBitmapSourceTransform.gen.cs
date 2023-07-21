// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICPlanarBitmapSourceTransform.xml' path='doc/member[@name="IWICPlanarBitmapSourceTransform"]/*' />
[Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
[NativeTypeName("struct IWICPlanarBitmapSourceTransform : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICPlanarBitmapSourceTransform : IWICPlanarBitmapSourceTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapSourceTransform));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, uint>)(lpVtbl[1]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, uint>)(lpVtbl[2]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICPlanarBitmapSourceTransform.xml' path='doc/member[@name="IWICPlanarBitmapSourceTransform.DoesSupportTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportTransform(uint* puiWidth, uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, uint*, uint*, WICBitmapTransformOptions, WICPlanarOptions, Guid*, WICBitmapPlaneDescription*, uint, BOOL*, int>)(lpVtbl[3]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
    }

    /// <include file='IWICPlanarBitmapSourceTransform.xml' path='doc/member[@name="IWICPlanarBitmapSourceTransform.CopyPixels"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes, uint cPlanes)
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, WICRect*, uint, uint, WICBitmapTransformOptions, WICPlanarOptions, WICBitmapPlane*, uint, int>)(lpVtbl[4]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoesSupportTransform(uint* puiWidth, uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, BOOL* pfIsSupported);

        [VtblIndex(4)]
        HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes, uint cPlanes);
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

        [NativeTypeName("HRESULT (UINT *, UINT *, WICBitmapTransformOptions, WICPlanarOptions, const WICPixelFormatGUID *, WICBitmapPlaneDescription *, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, WICBitmapTransformOptions, WICPlanarOptions, Guid*, WICBitmapPlaneDescription*, uint, BOOL*, int> DoesSupportTransform;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICBitmapTransformOptions, WICPlanarOptions, const WICBitmapPlane *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, WICBitmapTransformOptions, WICPlanarOptions, WICBitmapPlane*, uint, int> CopyPixels;
    }
}
