// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
[NativeTypeName("struct IWICPlanarBitmapSourceTransform : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICPlanarBitmapSourceTransform
    : IWICPlanarBitmapSourceTransform.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapSourceTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWICPlanarBitmapSourceTransform, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportTransform(
        uint* puiWidth,
        uint* puiHeight,
        WICBitmapTransformOptions dstTransform,
        WICPlanarOptions dstPlanarOptions,
        [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats,
        WICBitmapPlaneDescription* pPlaneDescriptions,
        uint cPlanes,
        BOOL* pfIsSupported
    )
    {
        return (
            (delegate* unmanaged<
                IWICPlanarBitmapSourceTransform,
                uint*,
                uint*,
                WICBitmapTransformOptions,
                WICPlanarOptions,
                Guid*,
                WICBitmapPlaneDescription*,
                uint,
                BOOL*,
                int>)((*lpVtbl)[3])
        )(
            this,
            puiWidth,
            puiHeight,
            dstTransform,
            dstPlanarOptions,
            pguidDstFormats,
            pPlaneDescriptions,
            cPlanes,
            pfIsSupported
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CopyPixels(
        [NativeTypeName("const WICRect *")] WICRect* prcSource,
        uint uiWidth,
        uint uiHeight,
        WICBitmapTransformOptions dstTransform,
        WICPlanarOptions dstPlanarOptions,
        [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes,
        uint cPlanes
    )
    {
        return (
            (delegate* unmanaged<
                IWICPlanarBitmapSourceTransform,
                WICRect*,
                uint,
                uint,
                WICBitmapTransformOptions,
                WICPlanarOptions,
                WICBitmapPlane*,
                uint,
                int>)((*lpVtbl)[4])
        )(this, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoesSupportTransform(
            uint* puiWidth,
            uint* puiHeight,
            WICBitmapTransformOptions dstTransform,
            WICPlanarOptions dstPlanarOptions,
            [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats,
            WICBitmapPlaneDescription* pPlaneDescriptions,
            uint cPlanes,
            BOOL* pfIsSupported
        );

        [VtblIndex(4)]
        HRESULT CopyPixels(
            [NativeTypeName("const WICRect *")] WICRect* prcSource,
            uint uiWidth,
            uint uiHeight,
            WICBitmapTransformOptions dstTransform,
            WICPlanarOptions dstPlanarOptions,
            [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes,
            uint cPlanes
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
            "HRESULT (UINT *, UINT *, WICBitmapTransformOptions, WICPlanarOptions, const WICPixelFormatGUID *, WICBitmapPlaneDescription *, UINT, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint*,
            uint*,
            WICBitmapTransformOptions,
            WICPlanarOptions,
            Guid*,
            WICBitmapPlaneDescription*,
            uint,
            BOOL*,
            int> DoesSupportTransform;

        [NativeTypeName(
            "HRESULT (const WICRect *, UINT, UINT, WICBitmapTransformOptions, WICPlanarOptions, const WICBitmapPlane *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WICRect*,
            uint,
            uint,
            WICBitmapTransformOptions,
            WICPlanarOptions,
            WICBitmapPlane*,
            uint,
            int> CopyPixels;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICPlanarBitmapSourceTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICPlanarBitmapSourceTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICPlanarBitmapSourceTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICPlanarBitmapSourceTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IWICPlanarBitmapSourceTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPlanarBitmapSourceTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPlanarBitmapSourceTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICPlanarBitmapSourceTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
