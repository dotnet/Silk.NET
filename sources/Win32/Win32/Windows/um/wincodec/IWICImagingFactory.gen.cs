// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EC5EC8A9-C395-4314-9C77-54D7A935FF70")]
[NativeTypeName("struct IWICImagingFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICImagingFactory : IWICImagingFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICImagingFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICImagingFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICImagingFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDecoderFromFilename(
        [NativeTypeName("LPCWSTR")] ushort* wzFilename,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        WICDecodeOptions metadataOptions,
        IWICBitmapDecoder* ppIDecoder
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                ushort*,
                Guid*,
                uint,
                WICDecodeOptions,
                IWICBitmapDecoder*,
                int>)((*lpVtbl)[3])
        )(this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDecoderFromStream(
        IStream pIStream,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        WICDecodeOptions metadataOptions,
        IWICBitmapDecoder* ppIDecoder
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                IStream,
                Guid*,
                WICDecodeOptions,
                IWICBitmapDecoder*,
                int>)((*lpVtbl)[4])
        )(this, pIStream, pguidVendor, metadataOptions, ppIDecoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDecoderFromFileHandle(
        [NativeTypeName("ULONG_PTR")] nuint hFile,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        WICDecodeOptions metadataOptions,
        IWICBitmapDecoder* ppIDecoder
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                nuint,
                Guid*,
                WICDecodeOptions,
                IWICBitmapDecoder*,
                int>)((*lpVtbl)[5])
        )(this, hFile, pguidVendor, metadataOptions, ppIDecoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateComponentInfo(
        [NativeTypeName("const IID &")] Guid* clsidComponent,
        IWICComponentInfo* ppIInfo
    )
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, Guid*, IWICComponentInfo*, int>)((*lpVtbl)[6])
        )(this, clsidComponent, ppIInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateDecoder(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        IWICBitmapDecoder* ppIDecoder
    )
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, Guid*, Guid*, IWICBitmapDecoder*, int>)(
                (*lpVtbl)[7]
            )
        )(this, guidContainerFormat, pguidVendor, ppIDecoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateEncoder(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        IWICBitmapEncoder* ppIEncoder
    )
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, Guid*, Guid*, IWICBitmapEncoder*, int>)(
                (*lpVtbl)[8]
            )
        )(this, guidContainerFormat, pguidVendor, ppIEncoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreatePalette(IWICPalette* ppIPalette)
    {
        return ((delegate* unmanaged<IWICImagingFactory, IWICPalette*, int>)((*lpVtbl)[9]))(
            this,
            ppIPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFormatConverter(IWICFormatConverter* ppIFormatConverter)
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, IWICFormatConverter*, int>)((*lpVtbl)[10])
        )(this, ppIFormatConverter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateBitmapScaler(IWICBitmapScaler* ppIBitmapScaler)
    {
        return ((delegate* unmanaged<IWICImagingFactory, IWICBitmapScaler*, int>)((*lpVtbl)[11]))(
            this,
            ppIBitmapScaler
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateBitmapClipper(IWICBitmapClipper* ppIBitmapClipper)
    {
        return ((delegate* unmanaged<IWICImagingFactory, IWICBitmapClipper*, int>)((*lpVtbl)[12]))(
            this,
            ppIBitmapClipper
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateBitmapFlipRotator(IWICBitmapFlipRotator* ppIBitmapFlipRotator)
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, IWICBitmapFlipRotator*, int>)((*lpVtbl)[13])
        )(this, ppIBitmapFlipRotator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateStream(IWICStream* ppIWICStream)
    {
        return ((delegate* unmanaged<IWICImagingFactory, IWICStream*, int>)((*lpVtbl)[14]))(
            this,
            ppIWICStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateColorContext(IWICColorContext* ppIWICColorContext)
    {
        return ((delegate* unmanaged<IWICImagingFactory, IWICColorContext*, int>)((*lpVtbl)[15]))(
            this,
            ppIWICColorContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateColorTransformer(IWICColorTransform* ppIWICColorTransform)
    {
        return ((delegate* unmanaged<IWICImagingFactory, IWICColorTransform*, int>)((*lpVtbl)[16]))(
            this,
            ppIWICColorTransform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateBitmap(
        uint uiWidth,
        uint uiHeight,
        [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
        WICBitmapCreateCacheOption option,
        IWICBitmap* ppIBitmap
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                uint,
                uint,
                Guid*,
                WICBitmapCreateCacheOption,
                IWICBitmap*,
                int>)((*lpVtbl)[17])
        )(this, uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateBitmapFromSource(
        IWICBitmapSource pIBitmapSource,
        WICBitmapCreateCacheOption option,
        IWICBitmap* ppIBitmap
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                IWICBitmapSource,
                WICBitmapCreateCacheOption,
                IWICBitmap*,
                int>)((*lpVtbl)[18])
        )(this, pIBitmapSource, option, ppIBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateBitmapFromSourceRect(
        IWICBitmapSource pIBitmapSource,
        uint x,
        uint y,
        uint width,
        uint height,
        IWICBitmap* ppIBitmap
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                IWICBitmapSource,
                uint,
                uint,
                uint,
                uint,
                IWICBitmap*,
                int>)((*lpVtbl)[19])
        )(this, pIBitmapSource, x, y, width, height, ppIBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateBitmapFromMemory(
        uint uiWidth,
        uint uiHeight,
        [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
        uint cbStride,
        uint cbBufferSize,
        byte* pbBuffer,
        IWICBitmap* ppIBitmap
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                uint,
                uint,
                Guid*,
                uint,
                uint,
                byte*,
                IWICBitmap*,
                int>)((*lpVtbl)[20])
        )(this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateBitmapFromHBITMAP(
        HBITMAP hBitmap,
        HPALETTE hPalette,
        WICBitmapAlphaChannelOption options,
        IWICBitmap* ppIBitmap
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                HBITMAP,
                HPALETTE,
                WICBitmapAlphaChannelOption,
                IWICBitmap*,
                int>)((*lpVtbl)[21])
        )(this, hBitmap, hPalette, options, ppIBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateBitmapFromHICON(HICON hIcon, IWICBitmap* ppIBitmap)
    {
        return ((delegate* unmanaged<IWICImagingFactory, HICON, IWICBitmap*, int>)((*lpVtbl)[22]))(
            this,
            hIcon,
            ppIBitmap
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateComponentEnumerator(
        [NativeTypeName("DWORD")] uint componentTypes,
        [NativeTypeName("DWORD")] uint options,
        IEnumUnknown* ppIEnumUnknown
    )
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, uint, uint, IEnumUnknown*, int>)((*lpVtbl)[23])
        )(this, componentTypes, options, ppIEnumUnknown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateFastMetadataEncoderFromDecoder(
        IWICBitmapDecoder pIDecoder,
        IWICFastMetadataEncoder* ppIFastEncoder
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                IWICBitmapDecoder,
                IWICFastMetadataEncoder*,
                int>)((*lpVtbl)[24])
        )(this, pIDecoder, ppIFastEncoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateFastMetadataEncoderFromFrameDecode(
        IWICBitmapFrameDecode pIFrameDecoder,
        IWICFastMetadataEncoder* ppIFastEncoder
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                IWICBitmapFrameDecode,
                IWICFastMetadataEncoder*,
                int>)((*lpVtbl)[25])
        )(this, pIFrameDecoder, ppIFastEncoder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateQueryWriter(
        [NativeTypeName("const GUID &")] Guid* guidMetadataFormat,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        IWICMetadataQueryWriter* ppIQueryWriter
    )
    {
        return (
            (delegate* unmanaged<IWICImagingFactory, Guid*, Guid*, IWICMetadataQueryWriter*, int>)(
                (*lpVtbl)[26]
            )
        )(this, guidMetadataFormat, pguidVendor, ppIQueryWriter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateQueryWriterFromReader(
        IWICMetadataQueryReader pIQueryReader,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        IWICMetadataQueryWriter* ppIQueryWriter
    )
    {
        return (
            (delegate* unmanaged<
                IWICImagingFactory,
                IWICMetadataQueryReader,
                Guid*,
                IWICMetadataQueryWriter*,
                int>)((*lpVtbl)[27])
        )(this, pIQueryReader, pguidVendor, ppIQueryWriter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDecoderFromFilename(
            [NativeTypeName("LPCWSTR")] ushort* wzFilename,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            [NativeTypeName("DWORD")] uint dwDesiredAccess,
            WICDecodeOptions metadataOptions,
            IWICBitmapDecoder* ppIDecoder
        );

        [VtblIndex(4)]
        HRESULT CreateDecoderFromStream(
            IStream pIStream,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            WICDecodeOptions metadataOptions,
            IWICBitmapDecoder* ppIDecoder
        );

        [VtblIndex(5)]
        HRESULT CreateDecoderFromFileHandle(
            [NativeTypeName("ULONG_PTR")] nuint hFile,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            WICDecodeOptions metadataOptions,
            IWICBitmapDecoder* ppIDecoder
        );

        [VtblIndex(6)]
        HRESULT CreateComponentInfo(
            [NativeTypeName("const IID &")] Guid* clsidComponent,
            IWICComponentInfo* ppIInfo
        );

        [VtblIndex(7)]
        HRESULT CreateDecoder(
            [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            IWICBitmapDecoder* ppIDecoder
        );

        [VtblIndex(8)]
        HRESULT CreateEncoder(
            [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            IWICBitmapEncoder* ppIEncoder
        );

        [VtblIndex(9)]
        HRESULT CreatePalette(IWICPalette* ppIPalette);

        [VtblIndex(10)]
        HRESULT CreateFormatConverter(IWICFormatConverter* ppIFormatConverter);

        [VtblIndex(11)]
        HRESULT CreateBitmapScaler(IWICBitmapScaler* ppIBitmapScaler);

        [VtblIndex(12)]
        HRESULT CreateBitmapClipper(IWICBitmapClipper* ppIBitmapClipper);

        [VtblIndex(13)]
        HRESULT CreateBitmapFlipRotator(IWICBitmapFlipRotator* ppIBitmapFlipRotator);

        [VtblIndex(14)]
        HRESULT CreateStream(IWICStream* ppIWICStream);

        [VtblIndex(15)]
        HRESULT CreateColorContext(IWICColorContext* ppIWICColorContext);

        [VtblIndex(16)]
        HRESULT CreateColorTransformer(IWICColorTransform* ppIWICColorTransform);

        [VtblIndex(17)]
        HRESULT CreateBitmap(
            uint uiWidth,
            uint uiHeight,
            [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
            WICBitmapCreateCacheOption option,
            IWICBitmap* ppIBitmap
        );

        [VtblIndex(18)]
        HRESULT CreateBitmapFromSource(
            IWICBitmapSource pIBitmapSource,
            WICBitmapCreateCacheOption option,
            IWICBitmap* ppIBitmap
        );

        [VtblIndex(19)]
        HRESULT CreateBitmapFromSourceRect(
            IWICBitmapSource pIBitmapSource,
            uint x,
            uint y,
            uint width,
            uint height,
            IWICBitmap* ppIBitmap
        );

        [VtblIndex(20)]
        HRESULT CreateBitmapFromMemory(
            uint uiWidth,
            uint uiHeight,
            [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
            uint cbStride,
            uint cbBufferSize,
            byte* pbBuffer,
            IWICBitmap* ppIBitmap
        );

        [VtblIndex(21)]
        HRESULT CreateBitmapFromHBITMAP(
            HBITMAP hBitmap,
            HPALETTE hPalette,
            WICBitmapAlphaChannelOption options,
            IWICBitmap* ppIBitmap
        );

        [VtblIndex(22)]
        HRESULT CreateBitmapFromHICON(HICON hIcon, IWICBitmap* ppIBitmap);

        [VtblIndex(23)]
        HRESULT CreateComponentEnumerator(
            [NativeTypeName("DWORD")] uint componentTypes,
            [NativeTypeName("DWORD")] uint options,
            IEnumUnknown* ppIEnumUnknown
        );

        [VtblIndex(24)]
        HRESULT CreateFastMetadataEncoderFromDecoder(
            IWICBitmapDecoder pIDecoder,
            IWICFastMetadataEncoder* ppIFastEncoder
        );

        [VtblIndex(25)]
        HRESULT CreateFastMetadataEncoderFromFrameDecode(
            IWICBitmapFrameDecode pIFrameDecoder,
            IWICFastMetadataEncoder* ppIFastEncoder
        );

        [VtblIndex(26)]
        HRESULT CreateQueryWriter(
            [NativeTypeName("const GUID &")] Guid* guidMetadataFormat,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            IWICMetadataQueryWriter* ppIQueryWriter
        );

        [VtblIndex(27)]
        HRESULT CreateQueryWriterFromReader(
            IWICMetadataQueryReader pIQueryReader,
            [NativeTypeName("const GUID *")] Guid* pguidVendor,
            IWICMetadataQueryWriter* ppIQueryWriter
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
            "HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            Guid*,
            uint,
            WICDecodeOptions,
            IWICBitmapDecoder*,
            int> CreateDecoderFromFilename;

        [NativeTypeName(
            "HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            Guid*,
            WICDecodeOptions,
            IWICBitmapDecoder*,
            int> CreateDecoderFromStream;

        [NativeTypeName(
            "HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            nuint,
            Guid*,
            WICDecodeOptions,
            IWICBitmapDecoder*,
            int> CreateDecoderFromFileHandle;

        [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IWICComponentInfo*, int> CreateComponentInfo;

        [NativeTypeName(
            "HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, IWICBitmapDecoder*, int> CreateDecoder;

        [NativeTypeName(
            "HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, IWICBitmapEncoder*, int> CreateEncoder;

        [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette*, int> CreatePalette;

        [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICFormatConverter*, int> CreateFormatConverter;

        [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapScaler*, int> CreateBitmapScaler;

        [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapClipper*, int> CreateBitmapClipper;

        [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapFlipRotator*, int> CreateBitmapFlipRotator;

        [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICStream*, int> CreateStream;

        [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorContext*, int> CreateColorContext;

        [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorTransform*, int> CreateColorTransformer;

        [NativeTypeName(
            "HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            Guid*,
            WICBitmapCreateCacheOption,
            IWICBitmap*,
            int> CreateBitmap;

        [NativeTypeName(
            "HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapSource,
            WICBitmapCreateCacheOption,
            IWICBitmap*,
            int> CreateBitmapFromSource;

        [NativeTypeName(
            "HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapSource,
            uint,
            uint,
            uint,
            uint,
            IWICBitmap*,
            int> CreateBitmapFromSourceRect;

        [NativeTypeName(
            "HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            Guid*,
            uint,
            uint,
            byte*,
            IWICBitmap*,
            int> CreateBitmapFromMemory;

        [NativeTypeName(
            "HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HBITMAP,
            HPALETTE,
            WICBitmapAlphaChannelOption,
            IWICBitmap*,
            int> CreateBitmapFromHBITMAP;

        [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HICON, IWICBitmap*, int> CreateBitmapFromHICON;

        [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            IEnumUnknown*,
            int> CreateComponentEnumerator;

        [NativeTypeName(
            "HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapDecoder,
            IWICFastMetadataEncoder*,
            int> CreateFastMetadataEncoderFromDecoder;

        [NativeTypeName(
            "HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapFrameDecode,
            IWICFastMetadataEncoder*,
            int> CreateFastMetadataEncoderFromFrameDecode;

        [NativeTypeName(
            "HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            IWICMetadataQueryWriter*,
            int> CreateQueryWriter;

        [NativeTypeName(
            "HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICMetadataQueryReader,
            Guid*,
            IWICMetadataQueryWriter*,
            int> CreateQueryWriterFromReader;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICImagingFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICImagingFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICImagingFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICImagingFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IWICImagingFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICImagingFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICImagingFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICImagingFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
