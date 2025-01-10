// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
[NativeTypeName("struct IWICBitmapDecoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapDecoder : IWICBitmapDecoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICBitmapDecoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryCapability(
        IStream pIStream,
        [NativeTypeName("DWORD *")] uint* pdwCapability
    )
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, IStream, uint*, int>)((*lpVtbl)[3]))(
            this,
            pIStream,
            pdwCapability
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Initialize(IStream pIStream, WICDecodeOptions cacheOptions)
    {
        return (
            (delegate* unmanaged<IWICBitmapDecoder, IStream, WICDecodeOptions, int>)((*lpVtbl)[4])
        )(this, pIStream, cacheOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, Guid*, int>)((*lpVtbl)[5]))(
            this,
            pguidContainerFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDecoderInfo(IWICBitmapDecoderInfo* ppIDecoderInfo)
    {
        return (
            (delegate* unmanaged<IWICBitmapDecoder, IWICBitmapDecoderInfo*, int>)((*lpVtbl)[6])
        )(this, ppIDecoderInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPalette(IWICPalette pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, IWICPalette, int>)((*lpVtbl)[7]))(
            this,
            pIPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMetadataQueryReader(IWICMetadataQueryReader* ppIMetadataQueryReader)
    {
        return (
            (delegate* unmanaged<IWICBitmapDecoder, IWICMetadataQueryReader*, int>)((*lpVtbl)[8])
        )(this, ppIMetadataQueryReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPreview(IWICBitmapSource* ppIBitmapSource)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, IWICBitmapSource*, int>)((*lpVtbl)[9]))(
            this,
            ppIBitmapSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetColorContexts(
        uint cCount,
        IWICColorContext* ppIColorContexts,
        uint* pcActualCount
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapDecoder, uint, IWICColorContext*, uint*, int>)(
                (*lpVtbl)[10]
            )
        )(this, cCount, ppIColorContexts, pcActualCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetThumbnail(IWICBitmapSource* ppIThumbnail)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, IWICBitmapSource*, int>)((*lpVtbl)[11]))(
            this,
            ppIThumbnail
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFrameCount(uint* pCount)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder, uint*, int>)((*lpVtbl)[12]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFrame(uint index, IWICBitmapFrameDecode* ppIBitmapFrame)
    {
        return (
            (delegate* unmanaged<IWICBitmapDecoder, uint, IWICBitmapFrameDecode*, int>)(
                (*lpVtbl)[13]
            )
        )(this, index, ppIBitmapFrame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryCapability(IStream pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability);

        [VtblIndex(4)]
        HRESULT Initialize(IStream pIStream, WICDecodeOptions cacheOptions);

        [VtblIndex(5)]
        HRESULT GetContainerFormat(Guid* pguidContainerFormat);

        [VtblIndex(6)]
        HRESULT GetDecoderInfo(IWICBitmapDecoderInfo* ppIDecoderInfo);

        [VtblIndex(7)]
        HRESULT CopyPalette(IWICPalette pIPalette);

        [VtblIndex(8)]
        HRESULT GetMetadataQueryReader(IWICMetadataQueryReader* ppIMetadataQueryReader);

        [VtblIndex(9)]
        HRESULT GetPreview(IWICBitmapSource* ppIBitmapSource);

        [VtblIndex(10)]
        HRESULT GetColorContexts(
            uint cCount,
            IWICColorContext* ppIColorContexts,
            uint* pcActualCount
        );

        [VtblIndex(11)]
        HRESULT GetThumbnail(IWICBitmapSource* ppIThumbnail);

        [VtblIndex(12)]
        HRESULT GetFrameCount(uint* pCount);

        [VtblIndex(13)]
        HRESULT GetFrame(uint index, IWICBitmapFrameDecode* ppIBitmapFrame);
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

        [NativeTypeName("HRESULT (IStream *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, uint*, int> QueryCapability;

        [NativeTypeName("HRESULT (IStream *, WICDecodeOptions) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, WICDecodeOptions, int> Initialize;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerFormat;

        [NativeTypeName("HRESULT (IWICBitmapDecoderInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapDecoderInfo*, int> GetDecoderInfo;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette, int> CopyPalette;

        [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryReader*, int> GetMetadataQueryReader;

        [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, int> GetPreview;

        [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICColorContext*, uint*, int> GetColorContexts;

        [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource*, int> GetThumbnail;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFrameCount;

        [NativeTypeName("HRESULT (UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICBitmapFrameDecode*, int> GetFrame;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICBitmapDecoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICBitmapDecoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICBitmapDecoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICBitmapDecoder(Silk.NET.Windows.IUnknown value)
    {
        return new IWICBitmapDecoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapDecoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapDecoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICBitmapDecoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
