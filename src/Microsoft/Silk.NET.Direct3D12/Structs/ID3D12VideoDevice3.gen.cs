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
    [Guid("4243adb4-3a32-4666-973c-0ccc5625dc44")]
    [NativeName("Name", "ID3D12VideoDevice3")]
    public unsafe partial struct ID3D12VideoDevice3 : IComVtbl<ID3D12VideoDevice3>, IComVtbl<ID3D12VideoDevice2>, IComVtbl<ID3D12VideoDevice1>, IComVtbl<ID3D12VideoDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4243adb4-3a32-4666-973c-0ccc5625dc44");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12VideoDevice2(ID3D12VideoDevice3 val)
            => Unsafe.As<ID3D12VideoDevice3, ID3D12VideoDevice2>(ref val);

        public static implicit operator ID3D12VideoDevice1(ID3D12VideoDevice3 val)
            => Unsafe.As<ID3D12VideoDevice3, ID3D12VideoDevice1>(ref val);

        public static implicit operator ID3D12VideoDevice(ID3D12VideoDevice3 val)
            => Unsafe.As<ID3D12VideoDevice3, ID3D12VideoDevice>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDevice3 val)
            => Unsafe.As<ID3D12VideoDevice3, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoDevice3
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
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(FeatureVideo FeatureVideo, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, FeatureVideo, void*, uint, int>)@this->LpVtbl[3])(@this, FeatureVideo, pFeatureSupportDataPtr, FeatureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riid, ppVideoDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDesc, riidPtr, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pDescPtr, riid, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riid, ppVideoDecoderHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDesc, riidPtr, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pVideoDecoderHeapDescPtr, riid, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riidPtr, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, Guid*, void**, int>)@this->LpVtbl[6])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoMotionEstimatorPtr = &ppVideoMotionEstimator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionEstimator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionEstimator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionEstimatorDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionEstimator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionEstimator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoMotionVectorHeapPtr = &ppVideoMotionVectorHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoMotionVectorHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoMotionVectorHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoMotionVectorHeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoMotionVectorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoDecoderPtr = &ppVideoDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riid, ppVideoDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSession, riidPtr, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pDescPtr, pProtectedResourceSession, riid, ppVideoDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoder1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoDecoderHeapPtr = &ppVideoDecoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSession, riidPtr, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDesc, pProtectedResourceSessionPtr, riid, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderHeapDesc* pVideoDecoderHeapDescPtr = &pVideoDecoderHeapDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pVideoDecoderHeapDescPtr, pProtectedResourceSession, riid, ppVideoDecoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoDecoderHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoProcessorPtr = &ppVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riidPtr, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSessionPtr, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescsPtr, pProtectedResourceSession, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessOutputStreamDesc* pOutputStreamDescPtr = &pOutputStreamDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, uint, VideoProcessOutputStreamDesc*, uint, VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[11])(@this, NodeMask, pOutputStreamDescPtr, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoProcessor1(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoExtensionCommandPtr = &ppVideoExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommandPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riidPtr, ppVideoExtensionCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSessionPtr, riid, ppVideoExtensionCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersPtr = &pCreationParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDesc, pCreationParametersPtr, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoExtensionCommandDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[12])(@this, pDescPtr, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession* pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoExtensionCommand<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pOutputDataPtr = &pOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputDataPtr, OutputDataSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<T0, T1>(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int ExecuteExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, ID3D12VideoExtensionCommand*, void*, nuint, void*, nuint, int>)@this->LpVtbl[13])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int ExecuteExtensionCommand<T0, T1>(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderDesc* pDesc, Guid* riid, void** ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riid, ppVideoEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderDesc* pDesc, Guid* riid, ref void* ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoEncoderPtr = &ppVideoEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riid, ppVideoEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderDesc* pDesc, ref Guid riid, void** ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDesc, riidPtr, ppVideoEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderDesc* pDesc, ref Guid riid, ref void* ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderDesc pDesc, Guid* riid, void** ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoEncoderDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescPtr, riid, ppVideoEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderDesc pDesc, Guid* riid, ref void* ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderDesc pDesc, ref Guid riid, void** ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoder([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderDesc pDesc, ref Guid riid, ref void* ppVideoEncoder)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderHeapDesc* pDesc, Guid* riid, void** ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riid, ppVideoEncoderHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderHeapDesc* pDesc, Guid* riid, ref void* ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppVideoEncoderHeapPtr = &ppVideoEncoderHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riid, ppVideoEncoderHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderHeapDesc* pDesc, ref Guid riid, void** ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDesc, riidPtr, ppVideoEncoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderHeapDesc* pDesc, ref Guid riid, ref void* ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderHeapDesc pDesc, Guid* riid, void** ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoEncoderHeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDevice3*, VideoEncoderHeapDesc*, Guid*, void**, int>)@this->LpVtbl[15])(@this, pDescPtr, riid, ppVideoEncoderHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderHeapDesc pDesc, Guid* riid, ref void* ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderHeapDesc pDesc, ref Guid riid, void** ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CreateVideoEncoderHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderHeapDesc pDesc, ref Guid riid, ref void* ppVideoEncoderHeap)
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionEstimator(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionEstimator);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionEstimator) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionEstimator = default;
            return @this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionEstimator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoMotionVectorHeap(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoMotionVectorHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoMotionVectorHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoMotionVectorHeap = default;
            return @this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoMotionVectorHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoder1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoder) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoder1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoder = default;
            return @this->CreateVideoDecoder1(in pDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoderHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoderHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoderHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoDecoderHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoDecoderHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoDecoderHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoDecoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoDecoderHeap = default;
            return @this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoDecoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoProcessor) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoProcessor);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoProcessor) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoProcessor = default;
            return @this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoProcessor.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoExtensionCommand<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, out ComPtr<TI1> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, Guid* riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, void** ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession, ref Guid riid, ref void* ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, (ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle, ref riid, ref ppVideoExtensionCommand);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession, out ComPtr<TI0> ppVideoExtensionCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoExtensionCommand = default;
            return @this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoExtensionCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<T0, TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T0 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData, OutputDataSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExecuteExtensionCommand<T0, TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, void* pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly int ExecuteExtensionCommand<T0, T1, TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes, ref T1 pOutputData, nuint OutputDataSizeInBytes) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pExecutionParameters, ExecutionParametersSizeInBytes, ref pOutputData, OutputDataSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderDesc* pDesc, out ComPtr<TI0> ppVideoEncoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoEncoder = default;
            return @this->CreateVideoEncoder(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoEncoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderDesc pDesc, out ComPtr<TI0> ppVideoEncoder) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoEncoder = default;
            return @this->CreateVideoEncoder(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoEncoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderHeapDesc* pDesc, out ComPtr<TI0> ppVideoEncoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoEncoderHeap = default;
            return @this->CreateVideoEncoderHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVideoEncoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderHeapDesc pDesc, out ComPtr<TI0> ppVideoEncoderHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppVideoEncoderHeap = default;
            return @this->CreateVideoEncoderHeap(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppVideoEncoderHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoDecoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoDecoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap(in pVideoDecoderHeapDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoProcessor<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoMotionEstimator<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoMotionEstimator<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionEstimatorDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionEstimator(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionVectorHeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoMotionVectorHeap<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoMotionVectorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoMotionVectorHeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoMotionVectorHeap(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoDecoder1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoDecoder1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(in pDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoDecoder1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoder1(in pDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoDecoderHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoDecoderHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoDecoderHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderHeapDesc pVideoDecoderHeapDesc, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoDecoderHeap1(in pVideoDecoderHeapDesc, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamDesc* pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoProcessor1<TI0, TI1>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoProcessor1<TI0>(uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamDesc pOutputStreamDesc, uint NumInputStreamDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamDesc pInputStreamDescs, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoProcessor1(NodeMask, in pOutputStreamDesc, NumInputStreamDescs, in pInputStreamDescs, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoExtensionCommand<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoExtensionCommand<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoExtensionCommandDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateVideoExtensionCommand<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoExtensionCommand<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateVideoExtensionCommand<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ComPtr<TI0> pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoExtensionCommand<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoExtensionCommandDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParameters, nuint CreationParametersDataSizeInBytes, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoExtensionCommand(in pDesc, in pCreationParameters, CreationParametersDataSizeInBytes, ref pProtectedResourceSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoEncoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoEncoder(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoEncoder<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoEncoder(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVideoEncoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderHeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoEncoderHeap(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVideoEncoderHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoEncoderHeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDevice3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVideoEncoderHeap(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
