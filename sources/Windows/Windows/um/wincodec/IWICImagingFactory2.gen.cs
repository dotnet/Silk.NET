// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICImagingFactory2.xml' path='doc/member[@name="IWICImagingFactory2"]/*' />
[Guid("7B816B45-1996-4476-B132-DE9E247C8AF0")]
[NativeTypeName("struct IWICImagingFactory2 : IWICImagingFactory")]
[NativeInheritance("IWICImagingFactory")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IWICImagingFactory2 : IWICImagingFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, uint>)(lpVtbl[1]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, uint>)(lpVtbl[2]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFilename" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFileHandle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateComponentInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, IWICComponentInfo**, int>)(lpVtbl[6]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateDecoder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Guid*, IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateEncoder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Guid*, IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreatePalette" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreatePalette(IWICPalette** ppIPalette)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICPalette**, int>)(lpVtbl[9]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIPalette);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateFormatConverter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICFormatConverter**, int>)(lpVtbl[10]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIFormatConverter);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapScaler" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapClipper" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapFlipRotator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateStream(IWICStream** ppIWICStream)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICStream**, int>)(lpVtbl[14]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICStream);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateColorContext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateColorContext(IWICColorContext** ppIWICColorContext)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICColorContext**, int>)(lpVtbl[15]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorContext);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateColorTransformer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICColorTransform**, int>)(lpVtbl[16]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmap" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[17]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[18]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSourceRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)(lpVtbl[19]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromMemory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)(lpVtbl[20]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHBITMAP" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateBitmapFromHBITMAP(HBITMAP hBitmap, HPALETTE hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap**, int>)(lpVtbl[21]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHICON" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateBitmapFromHICON(HICON hIcon, IWICBitmap** ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, HICON, IWICBitmap**, int>)(lpVtbl[22]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateComponentEnumerator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, uint, uint, IEnumUnknown**, int>)(lpVtbl[23]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromDecoder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromFrameDecode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateQueryWriter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
    }

    /// <inheritdoc cref="IWICImagingFactory.CreateQueryWriterFromReader" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
    }

    /// <include file='IWICImagingFactory2.xml' path='doc/member[@name="IWICImagingFactory2.CreateImageEncoder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateImageEncoder(ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder)
    {
        return ((delegate* unmanaged<IWICImagingFactory2*, ID2D1Device*, IWICImageEncoder**, int>)(lpVtbl[28]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pD2DDevice, ppWICImageEncoder);
    }

    public interface Interface : IWICImagingFactory.Interface
    {
        [VtblIndex(28)]
        HRESULT CreateImageEncoder(ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder);
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

        [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

        [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

        [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

        [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

        [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

        [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

        [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette**, int> CreatePalette;

        [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICFormatConverter**, int> CreateFormatConverter;

        [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapScaler**, int> CreateBitmapScaler;

        [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapClipper**, int> CreateBitmapClipper;

        [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

        [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICStream**, int> CreateStream;

        [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorContext**, int> CreateColorContext;

        [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorTransform**, int> CreateColorTransformer;

        [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

        [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

        [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

        [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

        [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

        [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HICON, IWICBitmap**, int> CreateBitmapFromHICON;

        [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

        [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

        [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

        [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

        [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;

        [NativeTypeName("HRESULT (ID2D1Device *, IWICImageEncoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Device*, IWICImageEncoder**, int> CreateImageEncoder;
    }
}
