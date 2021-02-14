// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
    [NativeName("Name", "ID3D11VideoContext")]
    public unsafe partial struct ID3D11VideoContext
    {
        public static readonly Guid Guid = new("61f21c45-3c0e-4a74-9cea-67100d9ad5e4");

        public static implicit operator ID3D11DeviceChild(ID3D11VideoContext val)
            => Unsafe.As<ID3D11VideoContext, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoContext val)
            => Unsafe.As<ID3D11VideoContext, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoContext
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    fixed (void** ppBufferPtr = &ppBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoder, Type);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoderPtr, Type);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pContentKeyPtr = &pContentKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderEndFrame(ref ID3D11VideoDecoder pDecoder)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, VideoDecoderExtension* pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, ref VideoDecoderExtension pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ref ID3D11VideoDecoder pDecoder, VideoDecoderExtension* pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderExtension(ref ID3D11VideoDecoder pDecoder, ref VideoDecoderExtension pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int YCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int YCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessor, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* EnabledPtr = &Enabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* EnabledPtr = &Enabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoColor* pColorPtr = &pColor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    fixed (VideoColor* pColorPtr = &pColor)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStreamIndexPtr = &pStreamIndex)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    fixed (uint* pStreamIndexPtr = &pStreamIndex)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pEntriesPtr = &pEntries)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pAlphaPtr = &pAlpha)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pAlphaPtr = &pAlpha)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pEntriesPtr = &pEntries)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pUpperPtr = &pUpper)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLowerPtr = &pLower)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLowerPtr = &pLower)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        fixed (float* pUpperPtr = &pUpper)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLevelPtr = &pLevel)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (int* pLevelPtr = &pLevel)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange<T0>(ID3D11CryptoSession* pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange(ref ID3D11CryptoSession pCryptoSession, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateCryptoSessionKeyExchange<T0>(ref ID3D11CryptoSession pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pIVPtr = &pIV)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pContentKeyPtr = &pContentKey)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pContentKeyPtr = &pContentKey)
            {
                fixed (T1* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (T1* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (T1* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (T1* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (T1* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pIVPtr = &pIV)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pContentKeyPtr = &pContentKey)
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pContentKeyPtr = &pContentKey)
                            {
                                fixed (T1* pIVPtr = &pIV)
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh<T0>(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pRandomNumberPtr = &pRandomNumber)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, T0*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void StartSessionKeyRefresh<T0>(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pRandomNumberPtr = &pRandomNumber)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, T0*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSession);
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSessionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey<T0>(ID3D11CryptoSession* pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pReadbackKeyPtr = &pReadbackKey)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(ref ID3D11CryptoSession pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncryptionBltKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (T0* pReadbackKeyPtr = &pReadbackKey)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange<T0>(ID3D11AuthenticatedChannel* pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, int>)LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateAuthenticatedChannelKeyExchange<T0>(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, T0*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0, T1>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                fixed (T1* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, uint, T1*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (T0* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, T0*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (T0* pInputPtr = &pInput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryAuthenticatedChannel<T0, T1>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (T0* pInputPtr = &pInput)
                {
                    fixed (T1* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, uint, T1*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pInputPtr = &pInput)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (T0* pInputPtr = &pInput)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (T0* pInputPtr = &pInput)
                {
                    fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
                    }
                }
            }
        }

    }
}
