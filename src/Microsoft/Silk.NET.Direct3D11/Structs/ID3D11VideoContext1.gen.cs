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

namespace Silk.NET.Direct3D11
{
    [Guid("a7f026da-a5f8-4487-a564-15e34357651e")]
    [NativeName("Name", "ID3D11VideoContext1")]
    public unsafe partial struct ID3D11VideoContext1 : IComVtbl<ID3D11VideoContext1>, IComVtbl<ID3D11VideoContext>, IComVtbl<ID3D11DeviceChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a7f026da-a5f8-4487-a564-15e34357651e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11VideoContext(ID3D11VideoContext1 val)
            => Unsafe.As<ID3D11VideoContext1, ID3D11VideoContext>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11VideoContext1 val)
            => Unsafe.As<ID3D11VideoContext1, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoContext1 val)
            => Unsafe.As<ID3D11VideoContext1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoContext1
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)@this->LpVtbl[8])(@this, pDecoder, Type);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, int>)@this->LpVtbl[10])(@this, pDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc* pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderExtension* pExtensionData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoder, pExtensionData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)@this->LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Vector2D<int>, void>)@this->LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[18])(@this, pVideoProcessor, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessor, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)@this->LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, void>)@this->LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, float, void>)@this->LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorStereoFormat Format, Silk.NET.Core.Bool32 LeftViewFrame0, Silk.NET.Core.Bool32 BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorStereoFormat, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, VideoProcessorStereoFlipMode, int, void>)@this->LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, void>)@this->LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Silk.NET.Core.Bool32 Enable, int Level)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, Silk.NET.Core.Bool32, int, void>)@this->LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, void>)@this->LpVtbl[58])(@this, pCryptoSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannel, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorRotation, void>)@this->LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers1(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc1* pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ulong* pPrivateOutputData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoSessionStatus(ID3D11CryptoSession* pCryptoSession, CryptoSessionStatus* pStatus)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSession, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderEnableDownsampling(ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderUpdateDownsampling(ID3D11VideoDecoder* pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoder, pOutputDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[70])(@this, pVideoProcessor, ColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 ShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[71])(@this, pVideoProcessor, ShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, int* pShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessor, pShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[74])(@this, pVideoProcessor, StreamIndex, ColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, Silk.NET.Core.Bool32 FlipHorizontal, Silk.NET.Core.Bool32 FlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, void>)@this->LpVtbl[75])(@this, pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
            return ret;
        }

    }
}
