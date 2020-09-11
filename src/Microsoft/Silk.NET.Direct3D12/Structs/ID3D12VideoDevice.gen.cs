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
    [NativeName("Name", "ID3D12VideoDevice")]
    public unsafe partial struct ID3D12VideoDevice
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDevice val)
            => Unsafe.As<ID3D12VideoDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12VideoDevice
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
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckFeatureSupport(FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, FeatureVideo, void*, uint, int>)LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckFeatureSupport<T0>(FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (T0* pFeatureSupportDataPtr = &pFeatureSupportData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, FeatureVideo, T0*, uint, int>)LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderDesc*, Guid*, void**, int>)LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeapPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeap);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderHeap(ref VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice*, VideoDecoderHeapDesc*, Guid*, void**, int>)LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeapPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
                {
                    fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(uint NodeMask, ref VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            fixed (ID3D12VideoDevice* @this = &this)
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
                                ret = ((delegate* cdecl<ID3D12VideoDevice*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

    }
}
