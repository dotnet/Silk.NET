// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D11VideoContext2.xml' path='doc/member[@name="ID3D11VideoContext2"]/*' />
[Guid("C4E7374C-6243-4D1B-AE87-52B4F740E261")]
[NativeTypeName("struct ID3D11VideoContext2 : ID3D11VideoContext1")]
[NativeInheritance("ID3D11VideoContext1")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID3D11VideoContext2 : ID3D11VideoContext2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoContext2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, uint>)(lpVtbl[1]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, uint>)(lpVtbl[2]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.GetDecoderBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, uint* pBufferSize, void** ppBuffer)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, uint*, void**, int>)(lpVtbl[7]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
    }

    /// <inheritdoc cref="ID3D11VideoContext.ReleaseDecoderBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, int>)(lpVtbl[8]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, Type);
    }

    /// <inheritdoc cref="ID3D11VideoContext.DecoderBeginFrame" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)(lpVtbl[9]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
    }

    /// <inheritdoc cref="ID3D11VideoContext.DecoderEndFrame" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, int>)(lpVtbl[10]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder);
    }

    /// <inheritdoc cref="ID3D11VideoContext.SubmitDecoderBuffers" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")] D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC*, int>)(lpVtbl[11]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
    }

    /// <inheritdoc cref="ID3D11VideoContext.DecoderExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT DecoderExtension(ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")] D3D11_VIDEO_DECODER_EXTENSION* pExtensionData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_EXTENSION*, int>)(lpVtbl[12]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputTargetRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, BOOL Enable, [NativeTypeName("const RECT *")] RECT* pRect)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL, RECT*, void>)(lpVtbl[13]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputBackgroundColor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, BOOL YCbCr, [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL, D3D11_VIDEO_COLOR*, void>)(lpVtbl[14]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputColorSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[15]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputAlphaFillMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, uint StreamIndex)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, uint, void>)(lpVtbl[16]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputConstriction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, BOOL Enable, SIZE Size)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL, SIZE, void>)(lpVtbl[17]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputStereoMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, BOOL Enable)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL, void>)(lpVtbl[18]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetOutputExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[19]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputTargetRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, BOOL* Enabled, RECT* pRect)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL*, RECT*, void>)(lpVtbl[20]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputBackgroundColor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, BOOL* pYCbCr, D3D11_VIDEO_COLOR* pColor)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL*, D3D11_VIDEO_COLOR*, void>)(lpVtbl[21]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputColorSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[22]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputAlphaFillMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode, uint* pStreamIndex)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*, uint*, void>)(lpVtbl[23]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputConstriction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled, SIZE* pSize)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL*, SIZE*, void>)(lpVtbl[24]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputStereoMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, BOOL* pEnabled)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL*, void>)(lpVtbl[25]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetOutputExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[26]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamFrameFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT FrameFormat)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT, void>)(lpVtbl[27]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamColorSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")] D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[28]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamOutputRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, BOOL RepeatFrame, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, DXGI_RATIONAL*, void>)(lpVtbl[29]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamSourceRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, [NativeTypeName("const RECT *")] RECT* pRect)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, RECT*, void>)(lpVtbl[30]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamDestRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, [NativeTypeName("const RECT *")] RECT* pRect)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, RECT*, void>)(lpVtbl[31]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamAlpha" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, float Alpha)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, float, void>)(lpVtbl[32]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamPalette" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, [NativeTypeName("const UINT *")] uint* pEntries)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[33]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamPixelAspectRatio" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio, [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[34]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamLumaKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, float Lower, float Upper)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, float, float, void>)(lpVtbl[35]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamStereoFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, BOOL LeftViewFrame0, BOOL BaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, int MonoOffset)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int, void>)(lpVtbl[36]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamAutoProcessingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, void>)(lpVtbl[37]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL Enable, int Level)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int, void>)(lpVtbl[38]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[39]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamFrameFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_FRAME_FORMAT* pFrameFormat)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT*, void>)(lpVtbl[40]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamColorSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void>)(lpVtbl[41]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamOutputRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate, BOOL* pRepeatFrame, DXGI_RATIONAL* pCustomRate)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*, BOOL*, DXGI_RATIONAL*, void>)(lpVtbl[42]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamSourceRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnabled, RECT* pRect)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, RECT*, void>)(lpVtbl[43]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamDestRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnabled, RECT* pRect)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, RECT*, void>)(lpVtbl[44]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamAlpha" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnabled, float* pAlpha)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, float*, void>)(lpVtbl[45]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamPalette" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[46]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamPixelAspectRatio" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnabled, DXGI_RATIONAL* pSourceAspectRatio, DXGI_RATIONAL* pDestinationAspectRatio)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, DXGI_RATIONAL*, DXGI_RATIONAL*, void>)(lpVtbl[47]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamLumaKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnabled, float* pLower, float* pUpper)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, float*, float*, void>)(lpVtbl[48]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamStereoFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat, BOOL* pLeftViewFrame0, BOOL* pBaseViewFrame0, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode, int* MonoOffset)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*, BOOL*, BOOL*, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*, int*, void>)(lpVtbl[49]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamAutoProcessingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnabled)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, void>)(lpVtbl[50]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, D3D11_VIDEO_PROCESSOR_FILTER Filter, BOOL* pEnabled, int* pLevel)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, BOOL*, int*, void>)(lpVtbl[51]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [NativeTypeName("const GUID *")] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[52]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorBlt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")] D3D11_VIDEO_PROCESSOR_STREAM* pStreams)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, D3D11_VIDEO_PROCESSOR_STREAM*, int>)(lpVtbl[53]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
    }

    /// <inheritdoc cref="ID3D11VideoContext.NegotiateCryptoSessionKeyExchange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[54]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.EncryptionBlt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)(lpVtbl[55]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
    }

    /// <inheritdoc cref="ID3D11VideoContext.DecryptionBlt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, uint ContentKeySize, [NativeTypeName("const void *")] void* pContentKey, uint IVSize, void* pIV)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, D3D11_ENCRYPTED_BLOCK_INFO*, uint, void*, uint, void*, void>)(lpVtbl[56]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <inheritdoc cref="ID3D11VideoContext.StartSessionKeyRefresh" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, void>)(lpVtbl[57]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
    }

    /// <inheritdoc cref="ID3D11VideoContext.FinishSessionKeyRefresh" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, void>)(lpVtbl[58]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession);
    }

    /// <inheritdoc cref="ID3D11VideoContext.GetEncryptionBltKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[59]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
    }

    /// <inheritdoc cref="ID3D11VideoContext.NegotiateAuthenticatedChannelKeyExchange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, int>)(lpVtbl[60]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11VideoContext.QueryAuthenticatedChannel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [NativeTypeName("const void *")] void* pInput, uint OutputSize, void* pOutput)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)(lpVtbl[61]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
    }

    /// <inheritdoc cref="ID3D11VideoContext.ConfigureAuthenticatedChannel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [NativeTypeName("const void *")] void* pInput, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11AuthenticatedChannel*, uint, void*, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*, int>)(lpVtbl[62]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorSetStreamRotation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, D3D11_VIDEO_PROCESSOR_ROTATION Rotation)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION, void>)(lpVtbl[63]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
    }

    /// <inheritdoc cref="ID3D11VideoContext.VideoProcessorGetStreamRotation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnable, D3D11_VIDEO_PROCESSOR_ROTATION* pRotation)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, D3D11_VIDEO_PROCESSOR_ROTATION*, void>)(lpVtbl[64]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.SubmitDecoderBuffers1" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT SubmitDecoderBuffers1(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC1 *")] D3D11_VIDEO_DECODER_BUFFER_DESC1* pBufferDesc)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC1*, int>)(lpVtbl[65]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.GetDataForNewHardwareKey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT GetDataForNewHardwareKey(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, [NativeTypeName("const void *")] void* pPrivatInputData, [NativeTypeName("UINT64 *")] ulong* pPrivateOutputData)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, uint, void*, ulong*, int>)(lpVtbl[66]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.CheckCryptoSessionStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT CheckCryptoSessionStatus(ID3D11CryptoSession* pCryptoSession, D3D11_CRYPTO_SESSION_STATUS* pStatus)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_STATUS*, int>)(lpVtbl[67]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pCryptoSession, pStatus);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.DecoderEnableDownsampling" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT DecoderEnableDownsampling(ID3D11VideoDecoder* pDecoder, DXGI_COLOR_SPACE_TYPE InputColorSpace, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc, uint ReferenceFrameCount)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_SAMPLE_DESC*, uint, int>)(lpVtbl[68]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.DecoderUpdateDownsampling" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT DecoderUpdateDownsampling(ID3D11VideoDecoder* pDecoder, [NativeTypeName("const D3D11_VIDEO_SAMPLE_DESC *")] D3D11_VIDEO_SAMPLE_DESC* pOutputDesc)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoDecoder*, D3D11_VIDEO_SAMPLE_DESC*, int>)(lpVtbl[69]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pDecoder, pOutputDesc);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorSetOutputColorSpace1" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public void VideoProcessorSetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, DXGI_COLOR_SPACE_TYPE ColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE, void>)(lpVtbl[70]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, ColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorSetOutputShaderUsage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public void VideoProcessorSetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, BOOL ShaderUsage)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL, void>)(lpVtbl[71]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, ShaderUsage);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorGetOutputColorSpace1" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, DXGI_COLOR_SPACE_TYPE* pColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE*, void>)(lpVtbl[72]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorGetOutputShaderUsage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, BOOL* pShaderUsage)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, BOOL*, void>)(lpVtbl[73]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pShaderUsage);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorSetStreamColorSpace1" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public void VideoProcessorSetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, DXGI_COLOR_SPACE_TYPE ColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE, void>)(lpVtbl[74]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, ColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorSetStreamMirror" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public void VideoProcessorSetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL Enable, BOOL FlipHorizontal, BOOL FlipVertical)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL, BOOL, BOOL, void>)(lpVtbl[75]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorGetStreamColorSpace1" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, DXGI_COLOR_SPACE_TYPE* pColorSpace)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE*, void>)(lpVtbl[76]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorGetStreamMirror" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, BOOL* pEnable, BOOL* pFlipHorizontal, BOOL* pFlipVertical)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, BOOL*, BOOL*, BOOL*, void>)(lpVtbl[77]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
    }

    /// <inheritdoc cref="ID3D11VideoContext1.VideoProcessorGetBehaviorHints" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, DXGI_FORMAT OutputFormat, uint StreamCount, [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT *")] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT* pStreams, uint* pBehaviorHints)
    {
        return ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, uint, DXGI_FORMAT, uint, D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT*, uint*, int>)(lpVtbl[78]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
    }

    /// <include file='ID3D11VideoContext2.xml' path='doc/member[@name="ID3D11VideoContext2.VideoProcessorSetOutputHDRMetaData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public void VideoProcessorSetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE, uint, void*, void>)(lpVtbl[79]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, Type, Size, pHDRMetaData);
    }

    /// <include file='ID3D11VideoContext2.xml' path='doc/member[@name="ID3D11VideoContext2.VideoProcessorGetOutputHDRMetaData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public void VideoProcessorGetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE* pType, uint Size, void* pMetaData)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE*, uint, void*, void>)(lpVtbl[80]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, pType, Size, pMetaData);
    }

    /// <include file='ID3D11VideoContext2.xml' path='doc/member[@name="ID3D11VideoContext2.VideoProcessorSetStreamHDRMetaData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public void VideoProcessorSetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, DXGI_HDR_METADATA_TYPE Type, uint Size, [NativeTypeName("const void *")] void* pHDRMetaData)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE, uint, void*, void>)(lpVtbl[81]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Type, Size, pHDRMetaData);
    }

    /// <include file='ID3D11VideoContext2.xml' path='doc/member[@name="ID3D11VideoContext2.VideoProcessorGetStreamHDRMetaData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public void VideoProcessorGetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, DXGI_HDR_METADATA_TYPE* pType, uint Size, void* pMetaData)
    {
        ((delegate* unmanaged<ID3D11VideoContext2*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE*, uint, void*, void>)(lpVtbl[82]))((ID3D11VideoContext2*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pType, Size, pMetaData);
    }

    public interface Interface : ID3D11VideoContext1.Interface
    {
        [VtblIndex(79)]
        void VideoProcessorSetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE Type, uint Size, [NativeTypeName("const void *")] void* pHDRMetaData);

        [VtblIndex(80)]
        void VideoProcessorGetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, DXGI_HDR_METADATA_TYPE* pType, uint Size, void* pMetaData);

        [VtblIndex(81)]
        void VideoProcessorSetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, DXGI_HDR_METADATA_TYPE Type, uint Size, [NativeTypeName("const void *")] void* pHDRMetaData);

        [VtblIndex(82)]
        void VideoProcessorGetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, DXGI_HDR_METADATA_TYPE* pType, uint Size, void* pMetaData);
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE, UINT *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, uint*, void**, int> GetDecoderBuffer;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_BUFFER_TYPE, int> ReleaseDecoderBuffer;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, ID3D11VideoDecoderOutputView *, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int> DecoderBeginFrame;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, int> DecoderEndFrame;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, UINT, const D3D11_VIDEO_DECODER_BUFFER_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC*, int> SubmitDecoderBuffers;

        [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoDecoder *, const D3D11_VIDEO_DECODER_EXTENSION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, D3D11_VIDEO_DECODER_EXTENSION*, int> DecoderExtension;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL, RECT*, void> VideoProcessorSetOutputTargetRect;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, const D3D11_VIDEO_COLOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL, D3D11_VIDEO_COLOR*, void> VideoProcessorSetOutputBackgroundColor;

        [NativeTypeName("void (ID3D11VideoProcessor *, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorSetOutputColorSpace;

        [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, uint, void> VideoProcessorSetOutputAlphaFillMode;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, SIZE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL, SIZE, void> VideoProcessorSetOutputConstriction;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL, void> VideoProcessorSetOutputStereoMode;

        [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, Guid*, uint, void*, int> VideoProcessorSetOutputExtension;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL*, RECT*, void> VideoProcessorGetOutputTargetRect;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, D3D11_VIDEO_COLOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL*, D3D11_VIDEO_COLOR*, void> VideoProcessorGetOutputBackgroundColor;

        [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorGetOutputColorSpace;

        [NativeTypeName("void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*, uint*, void> VideoProcessorGetOutputAlphaFillMode;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL*, SIZE*, void> VideoProcessorGetOutputConstriction;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL*, void> VideoProcessorGetOutputStereoMode;

        [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, Guid*, uint, void*, int> VideoProcessorGetOutputExtension;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT, void> VideoProcessorSetStreamFrameFormat;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorSetStreamColorSpace;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, const DXGI_RATIONAL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, DXGI_RATIONAL*, void> VideoProcessorSetStreamOutputRate;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, RECT*, void> VideoProcessorSetStreamSourceRect;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, RECT*, void> VideoProcessorSetStreamDestRect;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, float, void> VideoProcessorSetStreamAlpha;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, UINT, const UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, uint, uint*, void> VideoProcessorSetStreamPalette;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, const DXGI_RATIONAL *, const DXGI_RATIONAL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, DXGI_RATIONAL*, DXGI_RATIONAL*, void> VideoProcessorSetStreamPixelAspectRatio;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, float, float, void> VideoProcessorSetStreamLumaKey;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int, void> VideoProcessorSetStreamStereoFormat;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, void> VideoProcessorSetStreamAutoProcessingMode;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int, void> VideoProcessorSetStreamFilter;

        [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int> VideoProcessorSetStreamExtension;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_FRAME_FORMAT*, void> VideoProcessorGetStreamFrameFormat;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_COLOR_SPACE*, void> VideoProcessorGetStreamColorSpace;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *, BOOL *, DXGI_RATIONAL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*, BOOL*, DXGI_RATIONAL*, void> VideoProcessorGetStreamOutputRate;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, RECT*, void> VideoProcessorGetStreamSourceRect;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, RECT*, void> VideoProcessorGetStreamDestRect;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, float*, void> VideoProcessorGetStreamAlpha;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, uint, uint*, void> VideoProcessorGetStreamPalette;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, DXGI_RATIONAL *, DXGI_RATIONAL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, DXGI_RATIONAL*, DXGI_RATIONAL*, void> VideoProcessorGetStreamPixelAspectRatio;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *, FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, float*, float*, void> VideoProcessorGetStreamLumaKey;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *, BOOL *, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*, BOOL*, BOOL*, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*, int*, void> VideoProcessorGetStreamStereoFormat;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, void> VideoProcessorGetStreamAutoProcessingMode;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, D3D11_VIDEO_PROCESSOR_FILTER, BOOL*, int*, void> VideoProcessorGetStreamFilter;

        [NativeTypeName("APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int> VideoProcessorGetStreamExtension;

        [NativeTypeName("HRESULT (ID3D11VideoProcessor *, ID3D11VideoProcessorOutputView *, UINT, UINT, const D3D11_VIDEO_PROCESSOR_STREAM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, D3D11_VIDEO_PROCESSOR_STREAM*, int> VideoProcessorBlt;

        [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, uint, void*, int> NegotiateCryptoSessionKeyExchange;

        [NativeTypeName("void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void> EncryptionBlt;

        [NativeTypeName("void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, D3D11_ENCRYPTED_BLOCK_INFO *, UINT, const void *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, D3D11_ENCRYPTED_BLOCK_INFO*, uint, void*, uint, void*, void> DecryptionBlt;

        [NativeTypeName("void (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, uint, void*, void> StartSessionKeyRefresh;

        [NativeTypeName("void (ID3D11CryptoSession *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, void> FinishSessionKeyRefresh;

        [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, uint, void*, int> GetEncryptionBltKey;

        [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11AuthenticatedChannel*, uint, void*, int> NegotiateAuthenticatedChannelKeyExchange;

        [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int> QueryAuthenticatedChannel;

        [NativeTypeName("HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11AuthenticatedChannel*, uint, void*, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*, int> ConfigureAuthenticatedChannel;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION, void> VideoProcessorSetStreamRotation;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_ROTATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, D3D11_VIDEO_PROCESSOR_ROTATION*, void> VideoProcessorGetStreamRotation;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, UINT, const D3D11_VIDEO_DECODER_BUFFER_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, uint, D3D11_VIDEO_DECODER_BUFFER_DESC1*, int> SubmitDecoderBuffers1;

        [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, const void *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, uint, void*, ulong*, int> GetDataForNewHardwareKey;

        [NativeTypeName("HRESULT (ID3D11CryptoSession *, D3D11_CRYPTO_SESSION_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession*, D3D11_CRYPTO_SESSION_STATUS*, int> CheckCryptoSessionStatus;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, DXGI_COLOR_SPACE_TYPE, const D3D11_VIDEO_SAMPLE_DESC *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, DXGI_COLOR_SPACE_TYPE, D3D11_VIDEO_SAMPLE_DESC*, uint, int> DecoderEnableDownsampling;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *, const D3D11_VIDEO_SAMPLE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder*, D3D11_VIDEO_SAMPLE_DESC*, int> DecoderUpdateDownsampling;

        [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_COLOR_SPACE_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE, void> VideoProcessorSetOutputColorSpace1;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL, void> VideoProcessorSetOutputShaderUsage;

        [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_COLOR_SPACE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, DXGI_COLOR_SPACE_TYPE*, void> VideoProcessorGetOutputColorSpace1;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, BOOL*, void> VideoProcessorGetOutputShaderUsage;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_COLOR_SPACE_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE, void> VideoProcessorSetStreamColorSpace1;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL, BOOL, BOOL, void> VideoProcessorSetStreamMirror;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_COLOR_SPACE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, DXGI_COLOR_SPACE_TYPE*, void> VideoProcessorGetStreamColorSpace1;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *, BOOL *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, BOOL*, BOOL*, BOOL*, void> VideoProcessorGetStreamMirror;

        [NativeTypeName("HRESULT (ID3D11VideoProcessor *, UINT, UINT, DXGI_FORMAT, UINT, const D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, uint, DXGI_FORMAT, uint, D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT*, uint*, int> VideoProcessorGetBehaviorHints;

        [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_HDR_METADATA_TYPE, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE, uint, void*, void> VideoProcessorSetOutputHDRMetaData;

        [NativeTypeName("void (ID3D11VideoProcessor *, DXGI_HDR_METADATA_TYPE *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, DXGI_HDR_METADATA_TYPE*, uint, void*, void> VideoProcessorGetOutputHDRMetaData;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_HDR_METADATA_TYPE, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE, uint, void*, void> VideoProcessorSetStreamHDRMetaData;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, DXGI_HDR_METADATA_TYPE *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoProcessor*, uint, DXGI_HDR_METADATA_TYPE*, uint, void*, void> VideoProcessorGetStreamHDRMetaData;
    }
}
