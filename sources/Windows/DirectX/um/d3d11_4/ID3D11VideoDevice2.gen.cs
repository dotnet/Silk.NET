// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D11VideoDevice2.xml' path='doc/member[@name="ID3D11VideoDevice2"]/*'/>
[Guid("59C0CB01-35F0-4A70-8F67-87905C906A53")]
[NativeTypeName("struct ID3D11VideoDevice2 : ID3D11VideoDevice1")]
[NativeInheritance("ID3D11VideoDevice1")]
public unsafe partial struct ID3D11VideoDevice2 : ID3D11VideoDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDevice2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, uint> )(lpVtbl[1]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, uint> )(lpVtbl[2]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateVideoDecoder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateVideoDecoder([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pVideoDesc, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pConfig, ID3D11VideoDecoder** ppDecoder)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, ID3D11VideoDecoder**, int> )(lpVtbl[3]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateVideoProcessor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int> )(lpVtbl[4]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateAuthenticatedChannel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateAuthenticatedChannel(D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel**, int> )(lpVtbl[5]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateCryptoSession"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int> )(lpVtbl[6]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateVideoDecoderOutputView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateVideoDecoderOutputView(ID3D11Resource* pResource, [NativeTypeName("const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, ID3D11Resource*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, ID3D11VideoDecoderOutputView**, int> )(lpVtbl[7]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateVideoProcessorInputView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC*, ID3D11VideoProcessorInputView**, int> )(lpVtbl[8]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateVideoProcessorOutputView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, ID3D11VideoProcessorOutputView**, int> )(lpVtbl[9]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CreateVideoProcessorEnumerator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateVideoProcessorEnumerator([NativeTypeName("const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *")] D3D11_VIDEO_PROCESSOR_CONTENT_DESC* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, ID3D11VideoProcessorEnumerator**, int> )(lpVtbl[10]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.GetVideoDecoderProfileCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public uint GetVideoDecoderProfileCount()
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, uint> )(lpVtbl[11]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.GetVideoDecoderProfile"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, uint, Guid*, int> )(lpVtbl[12]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CheckVideoDecoderFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CheckVideoDecoderFormat([NativeTypeName("const GUID *")] Guid* pDecoderProfile, DXGI_FORMAT Format, BOOL* pSupported)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, DXGI_FORMAT, BOOL*, int> )(lpVtbl[13]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.GetVideoDecoderConfigCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetVideoDecoderConfigCount([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, uint* pCount)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_VIDEO_DECODER_DESC*, uint*, int> )(lpVtbl[14]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, pCount);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.GetVideoDecoderConfig"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetVideoDecoderConfig([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pDesc, uint Index, D3D11_VIDEO_DECODER_CONFIG* pConfig)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_VIDEO_DECODER_DESC*, uint, D3D11_VIDEO_DECODER_CONFIG*, int> )(lpVtbl[15]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.GetContentProtectionCaps"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, D3D11_VIDEO_CONTENT_PROTECTION_CAPS* pCaps)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, Guid*, D3D11_VIDEO_CONTENT_PROTECTION_CAPS*, int> )(lpVtbl[16]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.CheckCryptoKeyExchange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CheckCryptoKeyExchange([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int> )(lpVtbl[17]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, uint, void*, int> )(lpVtbl[18]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, IUnknown*, int> )(lpVtbl[19]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice1.GetCryptoSessionPrivateDataSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetCryptoSessionPrivateDataSize([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecoderProfile, [NativeTypeName("const GUID *")] Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int> )(lpVtbl[20]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice1.GetVideoDecoderCaps"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetVideoDecoderCaps([NativeTypeName("const GUID *")] Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, uint BitRate, [NativeTypeName("const GUID *")] Guid* pCryptoType, uint* pDecoderCaps)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, Guid*, uint, uint, DXGI_RATIONAL*, uint, Guid*, uint*, int> )(lpVtbl[21]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice1.CheckVideoDecoderDownsampling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CheckVideoDecoderDownsampling([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, BOOL* pSupported, BOOL* pRealTimeHint)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, BOOL*, BOOL*, int> )(lpVtbl[22]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
    }

    /// <inheritdoc cref = "ID3D11VideoDevice1.RecommendVideoDecoderDownsampleParameters"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT RecommendVideoDecoderDownsampleParameters([NativeTypeName("const D3D11_VIDEO_DECODER_DESC *")] D3D11_VIDEO_DECODER_DESC* pInputDesc, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_DECODER_CONFIG *")] D3D11_VIDEO_DECODER_CONFIG* pInputConfig, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pFrameRate, D3D11_VIDEO_SAMPLE_DESC* pRecommendedOutputDesc)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, int> )(lpVtbl[23]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
    }

    /// <include file='ID3D11VideoDevice2.xml' path='doc/member[@name="ID3D11VideoDevice2.CheckFeatureSupport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CheckFeatureSupport(D3D11_FEATURE_VIDEO Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, D3D11_FEATURE_VIDEO, void*, uint, int> )(lpVtbl[24]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
    }

    /// <include file='ID3D11VideoDevice2.xml' path='doc/member[@name="ID3D11VideoDevice2.NegotiateCryptoSessionKeyExchangeMT"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT NegotiateCryptoSessionKeyExchangeMT(ID3D11CryptoSession* pCryptoSession, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoDevice2*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS, uint, void*, int> )(lpVtbl[25]))((ID3D11VideoDevice2*)Unsafe.AsPointer(ref this), pCryptoSession, flags, DataSize, pData);
    }

    public interface Interface : ID3D11VideoDevice1.Interface
    {
        [VtblIndex(24)]
        HRESULT CheckFeatureSupport(D3D11_FEATURE_VIDEO Feature, void* pFeatureSupportData, uint FeatureSupportDataSize);
        [VtblIndex(25)]
        HRESULT NegotiateCryptoSessionKeyExchangeMT(ID3D11CryptoSession* pCryptoSession, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags, uint DataSize, void* pData);
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
        [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, const D3D11_VIDEO_DECODER_CONFIG *, ID3D11VideoDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_DECODER_DESC*, D3D11_VIDEO_DECODER_CONFIG*, ID3D11VideoDecoder**, int> CreateVideoDecoder;
        [NativeTypeName("HRESULT (ID3D11VideoProcessorEnumerator *, UINT, ID3D11VideoProcessor **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int> CreateVideoProcessor;
        [NativeTypeName("HRESULT (D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_AUTHENTICATED_CHANNEL_TYPE, ID3D11AuthenticatedChannel**, int> CreateAuthenticatedChannel;
        [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, ID3D11CryptoSession **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int> CreateCryptoSession;
        [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *, ID3D11VideoDecoderOutputView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, ID3D11VideoDecoderOutputView**, int> CreateVideoDecoderOutputView;
        [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC *, ID3D11VideoProcessorInputView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC*, ID3D11VideoProcessorInputView**, int> CreateVideoProcessorInputView;
        [NativeTypeName("HRESULT (ID3D11Resource *, ID3D11VideoProcessorEnumerator *, const D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC *, ID3D11VideoProcessorOutputView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, ID3D11VideoProcessorOutputView**, int> CreateVideoProcessorOutputView;
        [NativeTypeName("HRESULT (const D3D11_VIDEO_PROCESSOR_CONTENT_DESC *, ID3D11VideoProcessorEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_PROCESSOR_CONTENT_DESC*, ID3D11VideoProcessorEnumerator**, int> CreateVideoProcessorEnumerator;
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetVideoDecoderProfileCount;
        [NativeTypeName("HRESULT (UINT, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetVideoDecoderProfile;
        [NativeTypeName("HRESULT (const GUID *, DXGI_FORMAT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, DXGI_FORMAT, BOOL*, int> CheckVideoDecoderFormat;
        [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_DECODER_DESC*, uint*, int> GetVideoDecoderConfigCount;
        [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, UINT, D3D11_VIDEO_DECODER_CONFIG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_DECODER_DESC*, uint, D3D11_VIDEO_DECODER_CONFIG*, int> GetVideoDecoderConfig;
        [NativeTypeName("HRESULT (const GUID *, const GUID *, D3D11_VIDEO_CONTENT_PROTECTION_CAPS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, D3D11_VIDEO_CONTENT_PROTECTION_CAPS*, int> GetContentProtectionCaps;
        [NativeTypeName("HRESULT (const GUID *, const GUID *, UINT, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint, Guid*, int> CheckCryptoKeyExchange;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (const GUID *, const GUID *, const GUID *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid*, uint*, uint*, int> GetCryptoSessionPrivateDataSize;
        [NativeTypeName("HRESULT (const GUID *, UINT, UINT, const DXGI_RATIONAL *, UINT, const GUID *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, uint, DXGI_RATIONAL*, uint, Guid*, uint*, int> GetVideoDecoderCaps;
        [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_DECODER_CONFIG *, const DXGI_RATIONAL *, const D3D11_VIDEO_SAMPLE_DESC *, BOOL *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, BOOL*, BOOL*, int> CheckVideoDecoderDownsampling;
        [NativeTypeName("HRESULT (const D3D11_VIDEO_DECODER_DESC *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_DECODER_CONFIG *, const DXGI_RATIONAL *, D3D11_VIDEO_SAMPLE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_VIDEO_DECODER_DESC*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_DECODER_CONFIG*, DXGI_RATIONAL*, D3D11_VIDEO_SAMPLE_DESC*, int> RecommendVideoDecoderDownsampleParameters;
        [NativeTypeName("HRESULT (D3D11_FEATURE_VIDEO, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_FEATURE_VIDEO, void*, uint, int> CheckFeatureSupport;
        [NativeTypeName("HRESULT (ID3D11CryptoSession *, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS, uint, void*, int> NegotiateCryptoSessionKeyExchangeMT;
    }
}