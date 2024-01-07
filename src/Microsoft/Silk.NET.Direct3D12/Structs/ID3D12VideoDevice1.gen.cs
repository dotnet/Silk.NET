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

namespace Silk.NET.Direct3D12
{
    [Guid("981611ad-a144-4c83-9890-f30e26d658ab")]
    [NativeName("Name", "ID3D12VideoDevice1")]
    public unsafe partial struct ID3D12VideoDevice1 : IComVtbl<ID3D12VideoDevice1>, IComVtbl<ID3D12VideoDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("981611ad-a144-4c83-9890-f30e26d658ab");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12VideoDevice(ID3D12VideoDevice1 val)
            => Unsafe.As<ID3D12VideoDevice1, ID3D12VideoDevice>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDevice1 val)
            => Unsafe.As<ID3D12VideoDevice1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoDevice1
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
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riidPtr, ppVideoDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
            {
                fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riidPtr, ppVideoDecoderHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessor);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescsPtr, riidPtr, ppVideoProcessorPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionEstimatorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimatorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimator);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionEstimatorPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeap);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice1*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSessionPtr, riidPtr, ppVideoMotionVectorHeapPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
