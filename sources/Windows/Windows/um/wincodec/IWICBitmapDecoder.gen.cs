// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder"]/*'/>
[Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
[NativeTypeName("struct IWICBitmapDecoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapDecoder : IWICBitmapDecoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, Guid*, void**, int> )(lpVtbl[0]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, uint> )(lpVtbl[1]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, uint> )(lpVtbl[2]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.QueryCapability"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IStream*, uint*, int> )(lpVtbl[3]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, pdwCapability);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Initialize(IStream* pIStream, WICDecodeOptions cacheOptions)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IStream*, WICDecodeOptions, int> )(lpVtbl[4]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, cacheOptions);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetContainerFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, Guid*, int> )(lpVtbl[5]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetDecoderInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int> )(lpVtbl[6]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIDecoderInfo);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.CopyPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyPalette(IWICPalette* pIPalette)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IWICPalette*, int> )(lpVtbl[7]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIPalette);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetMetadataQueryReader"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IWICMetadataQueryReader**, int> )(lpVtbl[8]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetPreview"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPreview(IWICBitmapSource** ppIBitmapSource)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IWICBitmapSource**, int> )(lpVtbl[9]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIBitmapSource);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetColorContexts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int> )(lpVtbl[10]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetThumbnail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetThumbnail(IWICBitmapSource** ppIThumbnail)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, IWICBitmapSource**, int> )(lpVtbl[11]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIThumbnail);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetFrameCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFrameCount(uint* pCount)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, uint*, int> )(lpVtbl[12]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IWICBitmapDecoder.xml' path='doc/member[@name="IWICBitmapDecoder.GetFrame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
    {
        return ((delegate* unmanaged<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int> )(lpVtbl[13]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), index, ppIBitmapFrame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability);
        [VtblIndex(4)]
        HRESULT Initialize(IStream* pIStream, WICDecodeOptions cacheOptions);
        [VtblIndex(5)]
        HRESULT GetContainerFormat(Guid* pguidContainerFormat);
        [VtblIndex(6)]
        HRESULT GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo);
        [VtblIndex(7)]
        HRESULT CopyPalette(IWICPalette* pIPalette);
        [VtblIndex(8)]
        HRESULT GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);
        [VtblIndex(9)]
        HRESULT GetPreview(IWICBitmapSource** ppIBitmapSource);
        [VtblIndex(10)]
        HRESULT GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);
        [VtblIndex(11)]
        HRESULT GetThumbnail(IWICBitmapSource** ppIThumbnail);
        [VtblIndex(12)]
        HRESULT GetFrameCount(uint* pCount);
        [VtblIndex(13)]
        HRESULT GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame);
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
        public delegate* unmanaged<TSelf*, IStream*, uint*, int> QueryCapability;
        [NativeTypeName("HRESULT (IStream *, WICDecodeOptions) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, WICDecodeOptions, int> Initialize;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerFormat;
        [NativeTypeName("HRESULT (IWICBitmapDecoderInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapDecoderInfo**, int> GetDecoderInfo;
        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette*, int> CopyPalette;
        [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;
        [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource**, int> GetPreview;
        [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICColorContext**, uint*, int> GetColorContexts;
        [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource**, int> GetThumbnail;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFrameCount;
        [NativeTypeName("HRESULT (UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICBitmapFrameDecode**, int> GetFrame;
    }
}