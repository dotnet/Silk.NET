// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11VideoContext3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11VideoContext3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11VideoContext3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11VideoContext3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11Device** ppDevice)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11VideoContext3> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11VideoContext3> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11VideoContext3> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDecoderBuffer(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseDecoderBuffer(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)@this->LpVtbl[8])(@this, pDecoder, Type);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEndFrame(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, int>)@this->LpVtbl[10])(@this, pDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc* pBufferDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderExtension(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderExtension* pExtensionData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoder, pExtensionData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputTargetRect(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputBackgroundColor(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoColor* pColor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputAlphaFillMode(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)@this->LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputConstriction(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, Silk.NET.Maths.Vector2D<int> Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Vector2D<int>, void>)@this->LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputStereoMode(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[18])(@this, pVideoProcessor, Enable);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetOutputExtension(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputTargetRect(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputBackgroundColor(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputAlphaFillMode(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputConstriction(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputStereoMode(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pEnabled)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessor, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetOutputExtension(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamFrameFormat(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)@this->LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamOutputRate(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pCustomRate)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamSourceRect(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamDestRect(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamAlpha(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Alpha)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, void>)@this->LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPalette(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pEntries)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamPixelAspectRatio(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamLumaKey(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Lower, float Upper)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, float, void>)@this->LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamStereoFormat(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorStereoFormat Format, Silk.NET.Core.Bool32 LeftViewFrame0, Silk.NET.Core.Bool32 BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorStereoFormat, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, VideoProcessorStereoFlipMode, int, void>)@this->LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamAutoProcessingMode(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, void>)@this->LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamFilter(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Silk.NET.Core.Bool32 Enable, int Level)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, Silk.NET.Core.Bool32, int, void>)@this->LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorSetStreamExtension(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFrameFormat(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamOutputRate(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamSourceRect(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamDestRect(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAlpha(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPalette(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamPixelAspectRatio(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamLumaKey(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamStereoFormat(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamAutoProcessingMode(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamFilter(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetStreamExtension(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorBlt(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateCryptoSessionKeyExchange(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncryptionBlt(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DecryptionBlt(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void StartSessionKeyRefresh(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FinishSessionKeyRefresh(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, void>)@this->LpVtbl[58])(@this, pCryptoSession);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncryptionBltKey(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int NegotiateAuthenticatedChannelKeyExchange(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannel, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryAuthenticatedChannel(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, void* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConfigureAuthenticatedChannel(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, AuthenticatedConfigureOutput* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamRotation(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorRotation Rotation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorRotation, void>)@this->LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamRotation(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers1(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc1* pBufferDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataForNewHardwareKey(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ulong* pPrivateOutputData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckCryptoSessionStatus(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11CryptoSession* pCryptoSession, CryptoSessionStatus* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSession, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderEnableDownsampling(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderUpdateDownsampling(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoder, pOutputDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputColorSpace1(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[70])(@this, pVideoProcessor, ColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputShaderUsage(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 ShaderUsage)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[71])(@this, pVideoProcessor, ShaderUsage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputColorSpace1(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessor, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputShaderUsage(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, int* pShaderUsage)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessor, pShaderUsage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamColorSpace1(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[74])(@this, pVideoProcessor, StreamIndex, ColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamMirror(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, Silk.NET.Core.Bool32 FlipHorizontal, Silk.NET.Core.Bool32 FlipVertical)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, void>)@this->LpVtbl[75])(@this, pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamColorSpace1(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamMirror(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int VideoProcessorGetBehaviorHints(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetOutputHDRMetaData(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.HdrMetadataType Type, uint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pHDRMetaData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType, uint, void*, void>)@this->LpVtbl[79])(@this, pVideoProcessor, Type, Size, pHDRMetaData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetOutputHDRMetaData(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, void* pMetaData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)@this->LpVtbl[80])(@this, pVideoProcessor, pType, Size, pMetaData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorSetStreamHDRMetaData(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType Type, uint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pHDRMetaData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType, uint, void*, void>)@this->LpVtbl[81])(@this, pVideoProcessor, StreamIndex, Type, Size, pHDRMetaData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VideoProcessorGetStreamHDRMetaData(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, void* pMetaData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)@this->LpVtbl[82])(@this, pVideoProcessor, StreamIndex, pType, Size, pMetaData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DecoderBeginFrame1(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint NumComponentHistograms, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHistogramOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppHistogramBuffers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)@this->LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitDecoderBuffers2(this ComPtr<ID3D11VideoContext3> thisVtbl, ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc2* pBufferDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc2*, int>)@this->LpVtbl[84])(@this, pDecoder, NumBuffers, pBufferDesc);
        return ret;
    }

}
