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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12VideoDevice3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport<TThis>(this TThis thisVtbl, FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoder);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pOutputDataPtr = &pOutputData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pExecutionParametersPtr = &pExecutionParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, T1, TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pExecutionParametersPtr = &pExecutionParameters)
        {
            fixed (void* pOutputDataPtr = &pOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<TThis>(this TThis thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pOutputDataPtr = &pOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ExecuteExtensionCommand<T0, T1, TThis>(this TThis thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                fixed (void* pOutputDataPtr = &pOutputData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, Guid* riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riid, ppVideoEncoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, Guid* riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoEncoderPtr = &ppVideoEncoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riid, ppVideoEncoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, ref Guid riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riidPtr, ppVideoEncoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, ref Guid riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoEncoderPtr = &ppVideoEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riidPtr, ppVideoEncoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, ref VideoEncoderDesc pDesc, Guid* riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescPtr, riid, ppVideoEncoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, ref VideoEncoderDesc pDesc, Guid* riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoEncoderPtr = &ppVideoEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescPtr, riid, ppVideoEncoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, ref VideoEncoderDesc pDesc, ref Guid riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescPtr, riidPtr, ppVideoEncoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, ref VideoEncoderDesc pDesc, ref Guid riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoEncoderPtr = &ppVideoEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescPtr, riidPtr, ppVideoEncoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, Guid* riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riid, ppVideoEncoderHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, Guid* riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppVideoEncoderHeapPtr = &ppVideoEncoderHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riid, ppVideoEncoderHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, ref Guid riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riidPtr, ppVideoEncoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, ref Guid riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoEncoderHeapPtr = &ppVideoEncoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riidPtr, ppVideoEncoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, ref VideoEncoderHeapDesc pDesc, Guid* riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDescPtr, riid, ppVideoEncoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, ref VideoEncoderHeapDesc pDesc, Guid* riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoEncoderHeapPtr = &ppVideoEncoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDescPtr, riid, ppVideoEncoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, ref VideoEncoderHeapDesc pDesc, ref Guid riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDescPtr, riidPtr, ppVideoEncoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, ref VideoEncoderHeapDesc pDesc, ref Guid riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VideoEncoderHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoEncoderHeapPtr = &ppVideoEncoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDescPtr, riidPtr, ppVideoEncoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, FeatureVideo FeatureVideo, Span<T0> pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckFeatureSupport(FeatureVideo, ref pFeatureSupportData.GetPinnableReference(), FeatureSupportDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0, TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Span<Guid> riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(pDesc, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Span<Guid> riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(pDesc, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pDesc.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pDesc.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Span<Guid> riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Span<Guid> riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TI0, TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<Guid> riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<Guid> riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(ref pVideoDecoderHeapDesc.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderHeap<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap(ref pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(ref pVideoDecoderHeapDesc.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<Guid> riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(ref pVideoDecoderHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<Guid> riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(ref pVideoDecoderHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(ref pDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(ref pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TThis>(this TThis thisVtbl, Span<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(ref pDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(ref pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TThis>(this TThis thisVtbl, Span<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(ref pDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(ref pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TThis>(this TThis thisVtbl, Span<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoder1(ref pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TThis>(this TThis thisVtbl, Span<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TThis>(this TThis thisVtbl, uint NodeMask, Span<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, Span<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, ref pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(ref pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(ref pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(ref pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(ref pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<VideoExtensionCommandDesc> pDesc, Span<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(ref pDesc.GetPinnableReference(), ref pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T0> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, Span<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(pExtensionCommand, ref pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, T1, TThis>(this TThis thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, Span<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T1> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(pExtensionCommand, ref pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<TThis>(this TThis thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T0> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TThis>(this TThis thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, Span<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), ref pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static int ExecuteExtensionCommand<T0, T1, TThis>(this TThis thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, Span<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T1> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), ref pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TI0, TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, out ComPtr<TI0> ppVideoEncoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoEncoder = default;
        return @this->CreateVideoEncoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, Span<Guid> riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoder(pDesc, ref riid.GetPinnableReference(), ppVideoEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc, Span<Guid> riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoder(pDesc, ref riid.GetPinnableReference(), ref ppVideoEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, Span<VideoEncoderDesc> pDesc, Guid* riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoder(ref pDesc.GetPinnableReference(), riid, ppVideoEncoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoEncoder<TI0, TThis>(this TThis thisVtbl, ref VideoEncoderDesc pDesc, out ComPtr<TI0> ppVideoEncoder) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoEncoder = default;
        return @this->CreateVideoEncoder(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, Span<VideoEncoderDesc> pDesc, Guid* riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoder(ref pDesc.GetPinnableReference(), riid, ref ppVideoEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, Span<VideoEncoderDesc> pDesc, Span<Guid> riid, void** ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoder(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoder<TThis>(this TThis thisVtbl, Span<VideoEncoderDesc> pDesc, Span<Guid> riid, ref void* ppVideoEncoder) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoder(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoEncoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TI0, TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, out ComPtr<TI0> ppVideoEncoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoEncoderHeap = default;
        return @this->CreateVideoEncoderHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, Span<Guid> riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoderHeap(pDesc, ref riid.GetPinnableReference(), ppVideoEncoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc, Span<Guid> riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoderHeap(pDesc, ref riid.GetPinnableReference(), ref ppVideoEncoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, Span<VideoEncoderHeapDesc> pDesc, Guid* riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoderHeap(ref pDesc.GetPinnableReference(), riid, ppVideoEncoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoEncoderHeap<TI0, TThis>(this TThis thisVtbl, ref VideoEncoderHeapDesc pDesc, out ComPtr<TI0> ppVideoEncoderHeap) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppVideoEncoderHeap = default;
        return @this->CreateVideoEncoderHeap(ref pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, Span<VideoEncoderHeapDesc> pDesc, Guid* riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoderHeap(ref pDesc.GetPinnableReference(), riid, ref ppVideoEncoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, Span<VideoEncoderHeapDesc> pDesc, Span<Guid> riid, void** ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoderHeap(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoEncoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoEncoderHeap<TThis>(this TThis thisVtbl, Span<VideoEncoderHeapDesc> pDesc, Span<Guid> riid, ref void* ppVideoEncoderHeap) where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVideoEncoderHeap(ref pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoEncoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder<TI0, TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoder<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap<TI0, TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoderHeap<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(ref pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoProcessor<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(ref pDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoMotionEstimator<TI0, TThis>(this TThis thisVtbl, ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(ref pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(ref pDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoMotionVectorHeap<TI0, TThis>(this TThis thisVtbl, ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(ref pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(ref pDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoder1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(ref pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoderHeap1<TI0, TThis>(this TThis thisVtbl, ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(ref pVideoDecoderHeapDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoProcessor1<TI0, TThis>(this TThis thisVtbl, uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, ref pOutputStreamDesc, NumInputStreamDescs, ref pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(ref pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(ref pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(ref pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0, TThis>(this TThis thisVtbl, ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(ref pDesc, ref pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoEncoder<TI0, TThis>(this TThis thisVtbl, VideoEncoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoEncoder(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoEncoder<TI0, TThis>(this TThis thisVtbl, ref VideoEncoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoEncoder(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoEncoderHeap<TI0, TThis>(this TThis thisVtbl, VideoEncoderHeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoEncoderHeap(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoEncoderHeap<TI0, TThis>(this TThis thisVtbl, ref VideoEncoderHeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoDevice3>
    {
        var @this = (ID3D12VideoDevice3*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoEncoderHeap(ref pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
