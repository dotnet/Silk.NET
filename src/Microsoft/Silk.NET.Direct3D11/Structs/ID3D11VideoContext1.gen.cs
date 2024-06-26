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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
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
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
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
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
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
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
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
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    fixed (void** ppBufferPtr = &ppBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)@this->LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
                    }
                }
            }
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
        public readonly int ReleaseDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)@this->LpVtbl[8])(@this, pDecoderPtr, Type);
            }
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
        public readonly unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)@this->LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
                    }
                }
            }
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
        public readonly int DecoderEndFrame(ref ID3D11VideoDecoder pDecoder)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, int>)@this->LpVtbl[10])(@this, pDecoderPtr);
            }
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
        public readonly unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderBufferDesc pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc* pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderBufferDesc pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)@this->LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                }
            }
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
        public readonly unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderExtension pExtensionData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ref ID3D11VideoDecoder pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderExtension* pExtensionData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderExtension(ref ID3D11VideoDecoder pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderExtension pExtensionData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)@this->LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoColor pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoColor pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, VideoColor*, void>)@this->LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)@this->LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)@this->LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Vector2D<int>, void>)@this->LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, Silk.NET.Maths.Vector2D<int>, void>)@this->LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[18])(@this, pVideoProcessor, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
            }
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
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* EnabledPtr = &Enabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* EnabledPtr = &Enabled)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    fixed (VideoColor* pColorPtr = &pColor)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, VideoColor*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)@this->LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStreamIndexPtr = &pStreamIndex)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    fixed (uint* pStreamIndexPtr = &pStreamIndex)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)@this->LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessor, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
                }
            }
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
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)@this->LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)@this->LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)@this->LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, void>)@this->LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, void>)@this->LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pEntriesPtr = &pEntries)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, float, void>)@this->LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, float, float, void>)@this->LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorStereoFormat Format, Silk.NET.Core.Bool32 LeftViewFrame0, Silk.NET.Core.Bool32 BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorStereoFormat, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, VideoProcessorStereoFlipMode, int, void>)@this->LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorStereoFormat Format, Silk.NET.Core.Bool32 LeftViewFrame0, Silk.NET.Core.Bool32 BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorStereoFormat, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, VideoProcessorStereoFlipMode, int, void>)@this->LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, void>)@this->LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, void>)@this->LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Silk.NET.Core.Bool32 Enable, int Level)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, Silk.NET.Core.Bool32, int, void>)@this->LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Silk.NET.Core.Bool32 Enable, int Level)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, Silk.NET.Core.Bool32, int, void>)@this->LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
            }
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
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)@this->LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)@this->LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Box2D<int>* pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Box2D<int> pRect)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pAlphaPtr = &pAlpha)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pAlphaPtr = &pAlpha)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, void>)@this->LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pEntriesPtr = &pEntries)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, uint*, void>)@this->LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)@this->LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pUpperPtr = &pUpper)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLowerPtr = &pLower)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLowerPtr = &pLower)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        fixed (float* pUpperPtr = &pUpper)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)@this->LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                                {
                                    fixed (int* MonoOffsetPtr = &MonoOffset)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)@this->LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, void>)@this->LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLevelPtr = &pLevel)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (int* pLevelPtr = &pLevel)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)@this->LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                    }
                }
            }
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
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)@this->LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
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
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)@this->LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                    }
                }
            }
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
        public readonly unsafe int NegotiateCryptoSessionKeyExchange<T0>(ID3D11CryptoSession* pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange(ref ID3D11CryptoSession pCryptoSession, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateCryptoSessionKeyExchange<T0>(ref ID3D11CryptoSession pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)@this->LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (void* pContentKeyPtr = &pContentKey)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (void* pContentKeyPtr = &pContentKey)
                            {
                                fixed (void* pIVPtr = &pIV)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)@this->LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh<T0>(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pRandomNumberPtr = &pRandomNumber)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void StartSessionKeyRefresh<T0>(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pRandomNumberPtr = &pRandomNumber)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, void>)@this->LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, void>)@this->LpVtbl[58])(@this, pCryptoSession);
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, void>)@this->LpVtbl[58])(@this, pCryptoSessionPtr);
            }
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
        public readonly unsafe int GetEncryptionBltKey<T0>(ID3D11CryptoSession* pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReadbackKeyPtr = &pReadbackKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(ref ID3D11CryptoSession pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncryptionBltKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pReadbackKeyPtr = &pReadbackKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, int>)@this->LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
                }
            }
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
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange<T0>(ID3D11AuthenticatedChannel* pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateAuthenticatedChannelKeyExchange<T0>(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, int>)@this->LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
                }
            }
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
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0, T1>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
                fixed (void* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryAuthenticatedChannel<T0, T1>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
                    fixed (void* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)@this->LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
                    }
                }
            }
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
        public readonly unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
                    fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)@this->LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorRotation, void>)@this->LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, VideoProcessorRotation, void>)@this->LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)@this->LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
                    }
                }
            }
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
        public readonly unsafe int SubmitDecoderBuffers1(ID3D11VideoDecoder* pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderBufferDesc1 pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderBufferDesc1* pBufferDescPtr = &pBufferDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers1(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc1* pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitDecoderBuffers1(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderBufferDesc1 pBufferDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderBufferDesc1* pBufferDescPtr = &pBufferDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)@this->LpVtbl[65])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                }
            }
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
        public readonly unsafe int GetDataForNewHardwareKey(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ref ulong pPrivateOutputData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey<T0>(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey<T0>(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
            {
                fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ulong* pPrivateOutputData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ref ulong pPrivateOutputData)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputData, pPrivateOutputDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDataForNewHardwareKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pPrivatInputDataPtr = &pPrivatInputData)
                {
                    fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, uint, void*, ulong*, int>)@this->LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputDataPtr);
                    }
                }
            }
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
        public readonly unsafe int CheckCryptoSessionStatus(ID3D11CryptoSession* pCryptoSession, ref CryptoSessionStatus pStatus)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CryptoSessionStatus* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSession, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoSessionStatus(ref ID3D11CryptoSession pCryptoSession, CryptoSessionStatus* pStatus)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSessionPtr, pStatus);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCryptoSessionStatus(ref ID3D11CryptoSession pCryptoSession, ref CryptoSessionStatus pStatus)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (CryptoSessionStatus* pStatusPtr = &pStatus)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)@this->LpVtbl[67])(@this, pCryptoSessionPtr, pStatusPtr);
                }
            }
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
        public readonly unsafe int DecoderEnableDownsampling(ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, uint ReferenceFrameCount)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDescPtr, ReferenceFrameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderEnableDownsampling(ref ID3D11VideoDecoder pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoderPtr, InputColorSpace, pOutputDesc, ReferenceFrameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderEnableDownsampling(ref ID3D11VideoDecoder pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, uint ReferenceFrameCount)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)@this->LpVtbl[68])(@this, pDecoderPtr, InputColorSpace, pOutputDescPtr, ReferenceFrameCount);
                }
            }
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
        public readonly unsafe int DecoderUpdateDownsampling(ID3D11VideoDecoder* pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoder, pOutputDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderUpdateDownsampling(ref ID3D11VideoDecoder pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoderPtr, pOutputDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderUpdateDownsampling(ref ID3D11VideoDecoder pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)@this->LpVtbl[69])(@this, pDecoderPtr, pOutputDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[70])(@this, pVideoProcessor, ColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[70])(@this, pVideoProcessorPtr, ColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.Core.Bool32 ShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[71])(@this, pVideoProcessor, ShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputShaderUsage(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.Core.Bool32 ShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[71])(@this, pVideoProcessorPtr, ShaderUsage);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessor, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessorPtr, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[72])(@this, pVideoProcessorPtr, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, int* pShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessor, pShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, ref int pShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pShaderUsagePtr = &pShaderUsage)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessor, pShaderUsagePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputShaderUsage(ref ID3D11VideoProcessor pVideoProcessor, int* pShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessorPtr, pShaderUsage);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputShaderUsage(ref ID3D11VideoProcessor pVideoProcessor, ref int pShaderUsage)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pShaderUsagePtr = &pShaderUsage)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, int*, void>)@this->LpVtbl[73])(@this, pVideoProcessorPtr, pShaderUsagePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[74])(@this, pVideoProcessor, StreamIndex, ColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)@this->LpVtbl[74])(@this, pVideoProcessorPtr, StreamIndex, ColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, Silk.NET.Core.Bool32 FlipHorizontal, Silk.NET.Core.Bool32 FlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, void>)@this->LpVtbl[75])(@this, pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, Silk.NET.Core.Bool32 FlipHorizontal, Silk.NET.Core.Bool32 FlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, void>)@this->LpVtbl[75])(@this, pVideoProcessorPtr, StreamIndex, Enable, FlipHorizontal, FlipVertical);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)@this->LpVtbl[76])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pFlipVerticalPtr = &pFlipVertical)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVerticalPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVertical);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVerticalPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVertical);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVerticalPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVertical);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVerticalPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontal, pFlipVerticalPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVertical);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVerticalPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVertical);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVerticalPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVertical);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                    {
                        fixed (int* pFlipVerticalPtr = &pFlipVertical)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)@this->LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVerticalPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHintsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHints);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
            {
                fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHintsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHintsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHints);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints)
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
                {
                    fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext1*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)@this->LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHintsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer<TI0>(ComPtr<TI0> pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDecoderBuffer((ID3D11VideoDecoder*) pDecoder.Handle, Type, pBufferSize, ppBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer<TI0>(ComPtr<TI0> pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDecoderBuffer((ID3D11VideoDecoder*) pDecoder.Handle, Type, pBufferSize, ref ppBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer<TI0>(ComPtr<TI0> pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDecoderBuffer((ID3D11VideoDecoder*) pDecoder.Handle, Type, ref pBufferSize, ppBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer<TI0>(ComPtr<TI0> pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDecoderBuffer((ID3D11VideoDecoder*) pDecoder.Handle, Type, ref pBufferSize, ref ppBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseDecoderBuffer<TI0>(ComPtr<TI0> pDecoder, VideoDecoderBufferType Type) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ReleaseDecoderBuffer((ID3D11VideoDecoder*) pDecoder.Handle, Type);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<TI0, TI1>(ComPtr<TI0> pDecoder, ComPtr<TI1> pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderBeginFrame((ID3D11VideoDecoder*) pDecoder.Handle, (ID3D11VideoDecoderOutputView*) pView.Handle, ContentKeySize, pContentKey);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderBeginFrame<T0, TI0, TI1>(ComPtr<TI0> pDecoder, ComPtr<TI1> pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderBeginFrame((ID3D11VideoDecoder*) pDecoder.Handle, (ID3D11VideoDecoderOutputView*) pView.Handle, ContentKeySize, in pContentKey);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<TI0>(ComPtr<TI0> pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderBeginFrame((ID3D11VideoDecoder*) pDecoder.Handle, ref pView, ContentKeySize, pContentKey);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderBeginFrame<T0, TI0>(ComPtr<TI0> pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderBeginFrame((ID3D11VideoDecoder*) pDecoder.Handle, ref pView, ContentKeySize, in pContentKey);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<TI0>(ref ID3D11VideoDecoder pDecoder, ComPtr<TI0> pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderBeginFrame(ref pDecoder, (ID3D11VideoDecoderOutputView*) pView.Handle, ContentKeySize, pContentKey);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderBeginFrame<T0, TI0>(ref ID3D11VideoDecoder pDecoder, ComPtr<TI0> pView, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoderOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderBeginFrame(ref pDecoder, (ID3D11VideoDecoderOutputView*) pView.Handle, ContentKeySize, in pContentKey);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderEndFrame<TI0>(ComPtr<TI0> pDecoder) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderEndFrame((ID3D11VideoDecoder*) pDecoder.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers<TI0>(ComPtr<TI0> pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc* pBufferDesc) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SubmitDecoderBuffers((ID3D11VideoDecoder*) pDecoder.Handle, NumBuffers, pBufferDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitDecoderBuffers<TI0>(ComPtr<TI0> pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderBufferDesc pBufferDesc) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SubmitDecoderBuffers((ID3D11VideoDecoder*) pDecoder.Handle, NumBuffers, in pBufferDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension<TI0>(ComPtr<TI0> pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderExtension* pExtensionData) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderExtension((ID3D11VideoDecoder*) pDecoder.Handle, pExtensionData);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderExtension<TI0>(ComPtr<TI0> pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderExtension pExtensionData) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderExtension((ID3D11VideoDecoder*) pDecoder.Handle, in pExtensionData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputTargetRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputTargetRect<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputTargetRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, Enable, in pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoColor* pColor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputBackgroundColor((ID3D11VideoProcessor*) pVideoProcessor.Handle, YCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputBackgroundColor<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 YCbCr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoColor pColor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputBackgroundColor((ID3D11VideoProcessor*) pVideoProcessor.Handle, YCbCr, in pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorColorSpace pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, in pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputAlphaFillMode<TI0>(ComPtr<TI0> pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputAlphaFillMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, AlphaFillMode, StreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputConstriction<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 Enable, Silk.NET.Maths.Vector2D<int> Size) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputConstriction((ID3D11VideoProcessor*) pVideoProcessor.Handle, Enable, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputStereoMode<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 Enable) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputStereoMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, in pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetOutputExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, in pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect<TI0>(ComPtr<TI0> pVideoProcessor, int* Enabled, Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputTargetRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, Enabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect<TI0>(ComPtr<TI0> pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputTargetRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, Enabled, ref pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect<TI0>(ComPtr<TI0> pVideoProcessor, ref int Enabled, Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputTargetRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref Enabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputTargetRect<TI0>(ComPtr<TI0> pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputTargetRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref Enabled, ref pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor<TI0>(ComPtr<TI0> pVideoProcessor, int* pYCbCr, VideoColor* pColor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputBackgroundColor((ID3D11VideoProcessor*) pVideoProcessor.Handle, pYCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor<TI0>(ComPtr<TI0> pVideoProcessor, int* pYCbCr, ref VideoColor pColor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputBackgroundColor((ID3D11VideoProcessor*) pVideoProcessor.Handle, pYCbCr, ref pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor<TI0>(ComPtr<TI0> pVideoProcessor, ref int pYCbCr, VideoColor* pColor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputBackgroundColor((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pYCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputBackgroundColor<TI0>(ComPtr<TI0> pVideoProcessor, ref int pYCbCr, ref VideoColor pColor) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputBackgroundColor((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pYCbCr, ref pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, VideoProcessorColorSpace* pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, ref VideoProcessorColorSpace pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode<TI0>(ComPtr<TI0> pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputAlphaFillMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, pAlphaFillMode, pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode<TI0>(ComPtr<TI0> pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputAlphaFillMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, pAlphaFillMode, ref pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode<TI0>(ComPtr<TI0> pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputAlphaFillMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pAlphaFillMode, pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputAlphaFillMode<TI0>(ComPtr<TI0> pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputAlphaFillMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pAlphaFillMode, ref pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction<TI0>(ComPtr<TI0> pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputConstriction((ID3D11VideoProcessor*) pVideoProcessor.Handle, pEnabled, pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction<TI0>(ComPtr<TI0> pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputConstriction((ID3D11VideoProcessor*) pVideoProcessor.Handle, pEnabled, ref pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction<TI0>(ComPtr<TI0> pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputConstriction((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pEnabled, pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputConstriction<TI0>(ComPtr<TI0> pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputConstriction((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pEnabled, ref pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode<TI0>(ComPtr<TI0> pVideoProcessor, int* pEnabled) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputStereoMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputStereoMode<TI0>(ComPtr<TI0> pVideoProcessor, ref int pEnabled) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputStereoMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, in pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetOutputExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetOutputExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, in pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFrameFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamFrameFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, FrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorColorSpace* pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorColorSpace pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, in pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Silk.NET.Core.Bool32 RepeatFrame, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, OutputRate, RepeatFrame, in pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamSourceRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamSourceRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamSourceRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, in pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamDestRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamDestRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamDestRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, in pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAlpha<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Alpha) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamAlpha((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, Alpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pEntries) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamPalette((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPalette<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pEntries) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamPalette((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Count, in pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, pSourceAspectRatio, in pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, in pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pSourceAspectRatio, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.Rational pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, in pSourceAspectRatio, in pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, float Lower, float Upper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, Lower, Upper);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorStereoFormat Format, Silk.NET.Core.Bool32 LeftViewFrame0, Silk.NET.Core.Bool32 BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAutoProcessingMode<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamAutoProcessingMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFilter<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Silk.NET.Core.Bool32 Enable, int Level) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamFilter((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Filter, Enable, Level);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, in pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetStreamExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorSetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, in pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamFrameFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pFrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFrameFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamFrameFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pFrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamColorSpace<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamColorSpace((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pOutputRate, pRepeatFrame, ref pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pOutputRate, ref pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pOutputRate, ref pRepeatFrame, ref pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pOutputRate, pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pOutputRate, pRepeatFrame, ref pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pOutputRate, ref pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamOutputRate<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamOutputRate((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pOutputRate, ref pRepeatFrame, ref pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamSourceRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamSourceRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamSourceRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamSourceRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamSourceRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamDestRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamDestRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Box2D<int>* pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamDestRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamDestRect<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Box2D<int> pRect) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamDestRect((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamAlpha((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamAlpha((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamAlpha((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAlpha<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamAlpha((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPalette((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPalette<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPalette((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Count, ref pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pSourceAspectRatio, ref pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pSourceAspectRatio, ref pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pSourceAspectRatio, ref pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPixelAspectRatio<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamPixelAspectRatio((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pSourceAspectRatio, ref pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, pLower, ref pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled, ref pLower, ref pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, pLower, ref pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamLumaKey<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamLumaKey((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled, ref pLower, ref pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamStereoFormat<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamStereoFormat((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFormat, ref pLeftViewFrame0, ref pBaseViewFrame0, ref pFlipMode, ref MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnabled) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamAutoProcessingMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAutoProcessingMode<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnabled) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamAutoProcessingMode((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamFilter((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Filter, pEnabled, pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamFilter((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Filter, pEnabled, ref pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamFilter((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Filter, ref pEnabled, pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFilter<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamFilter((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Filter, ref pEnabled, ref pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, in pExtensionGuid, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetStreamExtension<T0, TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetStreamExtension((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, in pExtensionGuid, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt<TI0, TI1>(ComPtr<TI0> pVideoProcessor, ComPtr<TI1> pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorBlt((ID3D11VideoProcessor*) pVideoProcessor.Handle, (ID3D11VideoProcessorOutputView*) pView.Handle, OutputFrame, StreamCount, pStreams);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorBlt<TI0, TI1>(ComPtr<TI0> pVideoProcessor, ComPtr<TI1> pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorBlt((ID3D11VideoProcessor*) pVideoProcessor.Handle, (ID3D11VideoProcessorOutputView*) pView.Handle, OutputFrame, StreamCount, in pStreams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt<TI0>(ComPtr<TI0> pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorBlt((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pView, OutputFrame, StreamCount, pStreams);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorBlt<TI0>(ComPtr<TI0> pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorBlt((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pView, OutputFrame, StreamCount, in pStreams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt<TI0>(ref ID3D11VideoProcessor pVideoProcessor, ComPtr<TI0> pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStream* pStreams) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorBlt(ref pVideoProcessor, (ID3D11VideoProcessorOutputView*) pView.Handle, OutputFrame, StreamCount, pStreams);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorBlt<TI0>(ref ID3D11VideoProcessor pVideoProcessor, ComPtr<TI0> pView, uint OutputFrame, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStream pStreams) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessorOutputView>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorBlt(ref pVideoProcessor, (ID3D11VideoProcessorOutputView*) pView.Handle, OutputFrame, StreamCount, in pStreams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange<TI0>(ComPtr<TI0> pCryptoSession, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->NegotiateCryptoSessionKeyExchange((ID3D11CryptoSession*) pCryptoSession.Handle, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateCryptoSessionKeyExchange<T0, TI0>(ComPtr<TI0> pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->NegotiateCryptoSessionKeyExchange((ID3D11CryptoSession*) pCryptoSession.Handle, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EncryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0, TI1, TI2>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ComPtr<TI2> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI2>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0, TI1>(ComPtr<TI0> pCryptoSession, ComPtr<TI1> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0, TI1>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0>(ComPtr<TI0> pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt((ID3D11CryptoSession*) pCryptoSession.Handle, ref pSrcSurface, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0, TI1>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ComPtr<TI1> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI1>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0>(ref ID3D11CryptoSession pCryptoSession, ComPtr<TI0> pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, (ID3D11Texture2D*) pSrcSurface.Handle, ref pDstSurface, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, void* pIV) where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1, TI0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ComPtr<TI0> pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Texture2D>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DecryptionBlt(ref pCryptoSession, ref pSrcSurface, (ID3D11Texture2D*) pDstSurface.Handle, ref pEncryptedBlockInfo, ContentKeySize, in pContentKey, IVSize, ref pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh<TI0>(ComPtr<TI0> pCryptoSession, uint RandomNumberSize, void* pRandomNumber) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->StartSessionKeyRefresh((ID3D11CryptoSession*) pCryptoSession.Handle, RandomNumberSize, pRandomNumber);
        }

        /// <summary>To be documented.</summary>
        public readonly void StartSessionKeyRefresh<T0, TI0>(ComPtr<TI0> pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->StartSessionKeyRefresh((ID3D11CryptoSession*) pCryptoSession.Handle, RandomNumberSize, ref pRandomNumber);
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishSessionKeyRefresh<TI0>(ComPtr<TI0> pCryptoSession) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->FinishSessionKeyRefresh((ID3D11CryptoSession*) pCryptoSession.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey<TI0>(ComPtr<TI0> pCryptoSession, uint KeySize, void* pReadbackKey) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEncryptionBltKey((ID3D11CryptoSession*) pCryptoSession.Handle, KeySize, pReadbackKey);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncryptionBltKey<T0, TI0>(ComPtr<TI0> pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEncryptionBltKey((ID3D11CryptoSession*) pCryptoSession.Handle, KeySize, ref pReadbackKey);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange<TI0>(ComPtr<TI0> pChannel, uint DataSize, void* pData) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->NegotiateAuthenticatedChannelKeyExchange((ID3D11AuthenticatedChannel*) pChannel.Handle, DataSize, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateAuthenticatedChannelKeyExchange<T0, TI0>(ComPtr<TI0> pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->NegotiateAuthenticatedChannelKeyExchange((ID3D11AuthenticatedChannel*) pChannel.Handle, DataSize, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, void* pOutput) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, pInput, OutputSize, pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0, TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, pInput, OutputSize, ref pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0, TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, in pInput, OutputSize, pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryAuthenticatedChannel<T0, T1, TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, in pInput, OutputSize, ref pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, AuthenticatedConfigureOutput* pOutput) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConfigureAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, pInput, pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInput, ref AuthenticatedConfigureOutput pOutput) where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConfigureAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, pInput, ref pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0, TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConfigureAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, in pInput, pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly int ConfigureAuthenticatedChannel<T0, TI0>(ComPtr<TI0> pChannel, uint InputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11AuthenticatedChannel>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConfigureAuthenticatedChannel((ID3D11AuthenticatedChannel*) pChannel.Handle, InputSize, in pInput, ref pOutput);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamRotation<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, VideoProcessorRotation Rotation) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamRotation((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, Rotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamRotation((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamRotation((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamRotation((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamRotation<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamRotation((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers1<TI0>(ComPtr<TI0> pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoDecoderBufferDesc1* pBufferDesc) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SubmitDecoderBuffers1((ID3D11VideoDecoder*) pDecoder.Handle, NumBuffers, pBufferDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitDecoderBuffers1<TI0>(ComPtr<TI0> pDecoder, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoDecoderBufferDesc1 pBufferDesc) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SubmitDecoderBuffers1((ID3D11VideoDecoder*) pDecoder.Handle, NumBuffers, in pBufferDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey<TI0>(ComPtr<TI0> pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ulong* pPrivateOutputData) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDataForNewHardwareKey((ID3D11CryptoSession*) pCryptoSession.Handle, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey<TI0>(ComPtr<TI0> pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPrivatInputData, ref ulong pPrivateOutputData) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDataForNewHardwareKey((ID3D11CryptoSession*) pCryptoSession.Handle, PrivateInputSize, pPrivatInputData, ref pPrivateOutputData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataForNewHardwareKey<T0, TI0>(ComPtr<TI0> pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDataForNewHardwareKey((ID3D11CryptoSession*) pCryptoSession.Handle, PrivateInputSize, in pPrivatInputData, pPrivateOutputData);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDataForNewHardwareKey<T0, TI0>(ComPtr<TI0> pCryptoSession, uint PrivateInputSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDataForNewHardwareKey((ID3D11CryptoSession*) pCryptoSession.Handle, PrivateInputSize, in pPrivatInputData, ref pPrivateOutputData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckCryptoSessionStatus<TI0>(ComPtr<TI0> pCryptoSession, CryptoSessionStatus* pStatus) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckCryptoSessionStatus((ID3D11CryptoSession*) pCryptoSession.Handle, pStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckCryptoSessionStatus<TI0>(ComPtr<TI0> pCryptoSession, ref CryptoSessionStatus pStatus) where TI0 : unmanaged, IComVtbl<ID3D11CryptoSession>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckCryptoSessionStatus((ID3D11CryptoSession*) pCryptoSession.Handle, ref pStatus);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderEnableDownsampling<TI0>(ComPtr<TI0> pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderEnableDownsampling((ID3D11VideoDecoder*) pDecoder.Handle, InputColorSpace, pOutputDesc, ReferenceFrameCount);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderEnableDownsampling<TI0>(ComPtr<TI0> pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc, uint ReferenceFrameCount) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderEnableDownsampling((ID3D11VideoDecoder*) pDecoder.Handle, InputColorSpace, in pOutputDesc, ReferenceFrameCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderUpdateDownsampling<TI0>(ComPtr<TI0> pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoSampleDesc* pOutputDesc) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderUpdateDownsampling((ID3D11VideoDecoder*) pDecoder.Handle, pOutputDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderUpdateDownsampling<TI0>(ComPtr<TI0> pDecoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoSampleDesc pOutputDesc) where TI0 : unmanaged, IComVtbl<ID3D11VideoDecoder>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->DecoderUpdateDownsampling((ID3D11VideoDecoder*) pDecoder.Handle, in pOutputDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputColorSpace1<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputColorSpace1((ID3D11VideoProcessor*) pVideoProcessor.Handle, ColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputShaderUsage<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.Core.Bool32 ShaderUsage) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetOutputShaderUsage((ID3D11VideoProcessor*) pVideoProcessor.Handle, ShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace1<TI0>(ComPtr<TI0> pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputColorSpace1((ID3D11VideoProcessor*) pVideoProcessor.Handle, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputColorSpace1<TI0>(ComPtr<TI0> pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputColorSpace1((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputShaderUsage<TI0>(ComPtr<TI0> pVideoProcessor, int* pShaderUsage) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputShaderUsage((ID3D11VideoProcessor*) pVideoProcessor.Handle, pShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputShaderUsage<TI0>(ComPtr<TI0> pVideoProcessor, ref int pShaderUsage) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetOutputShaderUsage((ID3D11VideoProcessor*) pVideoProcessor.Handle, ref pShaderUsage);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamColorSpace1<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamColorSpace1((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.Core.Bool32 Enable, Silk.NET.Core.Bool32 FlipHorizontal, Silk.NET.Core.Bool32 FlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorSetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, Enable, FlipHorizontal, FlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace1<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamColorSpace1((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamColorSpace1<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamColorSpace1((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, pFlipHorizontal, ref pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFlipHorizontal, pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, pEnable, ref pFlipHorizontal, ref pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFlipHorizontal, pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, pFlipHorizontal, ref pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFlipHorizontal, pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamMirror<TI0>(ComPtr<TI0> pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VideoProcessorGetStreamMirror((ID3D11VideoProcessor*) pVideoProcessor.Handle, StreamIndex, ref pEnable, ref pFlipHorizontal, ref pFlipVertical);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints<TI0>(ComPtr<TI0> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetBehaviorHints((ID3D11VideoProcessor*) pVideoProcessor.Handle, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints<TI0>(ComPtr<TI0> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetBehaviorHints((ID3D11VideoProcessor*) pVideoProcessor.Handle, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, ref pBehaviorHints);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetBehaviorHints<TI0>(ComPtr<TI0> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetBehaviorHints((ID3D11VideoProcessor*) pVideoProcessor.Handle, OutputWidth, OutputHeight, OutputFormat, StreamCount, in pStreams, pBehaviorHints);
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetBehaviorHints<TI0>(ComPtr<TI0> pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints) where TI0 : unmanaged, IComVtbl<ID3D11VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->VideoProcessorGetBehaviorHints((ID3D11VideoProcessor*) pVideoProcessor.Handle, OutputWidth, OutputHeight, OutputFormat, StreamCount, in pStreams, ref pBehaviorHints);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11VideoContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
