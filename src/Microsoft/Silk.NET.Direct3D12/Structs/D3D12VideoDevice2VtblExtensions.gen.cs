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

public unsafe static class D3D12VideoDevice2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VideoDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VideoDevice2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID3D12VideoDevice2> thisVtbl, FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoder);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoder);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
        {
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pCreationParametersPtr = &pCreationParameters)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
        {
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pOutputDataPtr = &pOutputData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pExecutionParametersPtr = &pExecutionParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, T1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pExecutionParametersPtr = &pExecutionParameters)
        {
            fixed (void* pOutputDataPtr = &pOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pOutputDataPtr = &pOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ExecuteExtensionCommand<T0, T1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                fixed (void* pOutputDataPtr = &pOutputData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoDevice2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, FeatureVideo FeatureVideo, Span<T0> pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckFeatureSupport(FeatureVideo, ref pFeatureSupportData.GetPinnableReference(), FeatureSupportDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pDesc, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(pDesc, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder(in pDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionEstimator = default;
        return @this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionEstimator(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionEstimator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionEstimator(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionEstimator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoMotionVectorHeap = default;
        return @this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoMotionVectorHeap(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionVectorHeapDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoMotionVectorHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoMotionVectorHeap(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoMotionVectorHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoder = default;
        return @this->CreateVideoDecoder1(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoder1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderDesc> pDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoder)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoder1(in pDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoder);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderHeap1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoDecoderHeap = default;
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoDecoderHeap1(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoDecoderHeapDesc> pVideoDecoderHeapDesc, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoDecoderHeap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoDecoderHeap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoProcessor = default;
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoProcessor1(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamDesc> pInputStreamDescs, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoProcessor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc.GetPinnableReference(), NumInputStreamDescs, in pInputStreamDescs.GetPinnableReference(), ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoProcessor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoExtensionCommand<T0, TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, pProtectedResourceSession, ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppVideoExtensionCommand = default;
        return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), riid, ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, void** ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVideoExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoExtensionCommandDesc> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pCreationParameters, nuint CreationParametersDataSizeInBytes, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession, Span<Guid> riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVideoExtensionCommand(in pDesc.GetPinnableReference(), in pCreationParameters.GetPinnableReference(), CreationParametersDataSizeInBytes, ref pProtectedResourceSession.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppVideoExtensionCommand);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T0> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(pExtensionCommand, in pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0, T1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T1> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(pExtensionCommand, in pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static int ExecuteExtensionCommand<T0, T1, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand(this ComPtr<ID3D12VideoDevice2> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T0> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), in pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static int ExecuteExtensionCommand<T0, T1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes, Span<T1> pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), in pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes, ref pOutputData.GetPinnableReference(), OutputDataSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoder<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(in pDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoderHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoProcessor<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoMotionEstimator<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoDecoder1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoDecoder1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoder1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoDecoderHeap1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoDecoderHeap1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoDecoderHeap1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoProcessor1<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoExtensionCommand<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoExtensionCommand<T0, TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateVideoExtensionCommand<TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateVideoExtensionCommand<T0, TI0, TI1>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoDevice2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
