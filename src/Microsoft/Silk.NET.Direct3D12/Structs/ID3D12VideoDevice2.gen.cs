// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12VideoDevice2")]
    public unsafe partial struct ID3D12VideoDevice2
    {
        public static implicit operator ID3D12VideoDevice1(ID3D12VideoDevice2 val)
            => Unsafe.As<ID3D12VideoDevice2, ID3D12VideoDevice1>(ref val);

        public readonly ref ID3D12VideoDevice1 AsVideoDevice1()
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                return ref *(ID3D12VideoDevice1*)@this;
            }
        }

        public static implicit operator ID3D12VideoDevice(ID3D12VideoDevice2 val)
            => Unsafe.As<ID3D12VideoDevice2, ID3D12VideoDevice>(ref val);

        public readonly ref ID3D12VideoDevice AsVideoDevice()
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                return ref *(ID3D12VideoDevice*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDevice2 val)
            => Unsafe.As<ID3D12VideoDevice2, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12VideoDevice2
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckFeatureSupport(FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, FeatureVideo, void*, uint, int>)LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckFeatureSupport<T0>(FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pFeatureSupportDataPtr = &pFeatureSupportData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, FeatureVideo, T0*, uint, int>)LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimator);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionEstimator(ref VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoMotionVectorHeap(ref VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoder);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder1(ref VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[9])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riidPtr, ppVideoDecoderHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeap);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap1(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoDecoderHeapPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessor);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riidPtr, ppVideoProcessorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riid, ppVideoProcessorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessor);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor1(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
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
                                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoProcessorPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(VideoExtensionCommandDesc* pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(VideoExtensionCommandDesc* pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pCreationParametersPtr = &pCreationParameters)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand(ref VideoExtensionCommandDesc pDesc, void* pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, void*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommandPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommandPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommand);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoExtensionCommand<T0>(ref VideoExtensionCommandDesc pDesc, ref T0 pCreationParameters, uint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
                {
                    fixed (T0* pCreationParametersPtr = &pCreationParameters)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
                                {
                                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, VideoExtensionCommandDesc*, T0*, uint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)LpVtbl[12])(@this, pDescPtr, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riidPtr, ppVideoExtensionCommandPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, uint ExecutionParametersSizeInBytes, void* pOutputData, uint OutputDataSizeInBytes)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, uint, void*, uint, int>)LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, uint ExecutionParametersSizeInBytes, ref T0 pOutputData, uint OutputDataSizeInBytes) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pOutputDataPtr = &pOutputData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, uint, T0*, uint, int>)LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, uint ExecutionParametersSizeInBytes, void* pOutputData, uint OutputDataSizeInBytes) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pExecutionParametersPtr = &pExecutionParameters)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, T0*, uint, void*, uint, int>)LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand<T0, T1>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, uint ExecutionParametersSizeInBytes, ref T1 pOutputData, uint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pExecutionParametersPtr = &pExecutionParameters)
                {
                    fixed (T1* pOutputDataPtr = &pOutputData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, T0*, uint, T1*, uint, int>)LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, uint ExecutionParametersSizeInBytes, void* pOutputData, uint OutputDataSizeInBytes)
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, uint, void*, uint, int>)LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, uint ExecutionParametersSizeInBytes, ref T0 pOutputData, uint OutputDataSizeInBytes) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
                {
                    fixed (T0* pOutputDataPtr = &pOutputData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, void*, uint, T0*, uint, int>)LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, uint ExecutionParametersSizeInBytes, void* pOutputData, uint OutputDataSizeInBytes) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
                {
                    fixed (T0* pExecutionParametersPtr = &pExecutionParameters)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, T0*, uint, void*, uint, int>)LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ExecuteExtensionCommand<T0, T1>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, uint ExecutionParametersSizeInBytes, ref T1 pOutputData, uint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D12VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
                {
                    fixed (T0* pExecutionParametersPtr = &pExecutionParameters)
                    {
                        fixed (T1* pOutputDataPtr = &pOutputData)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice2*, ID3D12VideoExtensionCommand*, T0*, uint, T1*, uint, int>)LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
                        }
                    }
                }
                return ret;
            }
        }

    }
}
