// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWICPlanarFormatConverter.xml' path='doc/member[@name="IWICPlanarFormatConverter"]/*'/>
[Guid("BEBEE9CB-83B0-4DCC-8132-B0AAA55EAC96")]
[NativeTypeName("struct IWICPlanarFormatConverter : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICPlanarFormatConverter : IWICPlanarFormatConverter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarFormatConverter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, Guid*, void**, int> )(lpVtbl[0]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, uint> )(lpVtbl[1]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, uint> )(lpVtbl[2]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, uint*, uint*, int> )(lpVtbl[3]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetPixelFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, Guid*, int> )(lpVtbl[4]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
    }

    /// <inheritdoc cref = "IWICBitmapSource.GetResolution"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResolution(double* pDpiX, double* pDpiY)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, double*, double*, int> )(lpVtbl[5]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
    }

    /// <inheritdoc cref = "IWICBitmapSource.CopyPalette"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, IWICPalette*, int> )(lpVtbl[6]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <inheritdoc cref = "IWICBitmapSource.CopyPixels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, WICRect*, uint, uint, byte*, int> )(lpVtbl[7]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
    }

    /// <include file='IWICPlanarFormatConverter.xml' path='doc/member[@name="IWICPlanarFormatConverter.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, IWICBitmapSource**, uint, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int> )(lpVtbl[8]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
    }

    /// <include file='IWICPlanarFormatConverter.xml' path='doc/member[@name="IWICPlanarFormatConverter.CanConvert"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, BOOL* pfCanConvert)
    {
        return ((delegate* unmanaged<IWICPlanarFormatConverter*, Guid*, uint, Guid*, BOOL*, int> )(lpVtbl[9]))((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
    }

    public interface Interface : IWICBitmapSource.Interface
    {
        [VtblIndex(8)]
        HRESULT Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
        [VtblIndex(9)]
        HRESULT CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, BOOL* pfCanConvert);
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
        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetSize;
        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPixelFormat;
        [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, double*, int> GetResolution;
        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette*, int> CopyPalette;
        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;
        [NativeTypeName("HRESULT (IWICBitmapSource **, UINT, REFWICPixelFormatGUID, WICBitmapDitherType, IWICPalette *, double, WICBitmapPaletteType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource**, uint, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int> Initialize;
        [NativeTypeName("HRESULT (const WICPixelFormatGUID *, UINT, REFWICPixelFormatGUID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, Guid*, BOOL*, int> CanConvert;
    }
}