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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11VideoContext3")]
    public unsafe partial struct ID3D11VideoContext3
    {
        public static implicit operator ID3D11VideoContext2(ID3D11VideoContext3 val)
            => Unsafe.As<ID3D11VideoContext3, ID3D11VideoContext2>(ref val);

        public readonly ref ID3D11VideoContext2 AsVideoContext2()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                return ref *(ID3D11VideoContext2*)@this;
            }
        }

        public static implicit operator ID3D11VideoContext1(ID3D11VideoContext3 val)
            => Unsafe.As<ID3D11VideoContext3, ID3D11VideoContext1>(ref val);

        public readonly ref ID3D11VideoContext1 AsVideoContext1()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                return ref *(ID3D11VideoContext1*)@this;
            }
        }

        public static implicit operator ID3D11VideoContext(ID3D11VideoContext3 val)
            => Unsafe.As<ID3D11VideoContext3, ID3D11VideoContext>(ref val);

        public readonly ref ID3D11VideoContext AsVideoContext()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                return ref *(ID3D11VideoContext*)@this;
            }
        }

        public static implicit operator ID3D11DeviceChild(ID3D11VideoContext3 val)
            => Unsafe.As<ID3D11VideoContext3, ID3D11DeviceChild>(ref val);

        public readonly ref ID3D11DeviceChild AsDeviceChild()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                return ref *(ID3D11DeviceChild*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoContext3 val)
            => Unsafe.As<ID3D11VideoContext3, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11VideoContext3
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
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Device** ppDevicePtr = &ppDevice)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (void** ppBufferPtr = &ppBuffer)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    fixed (void** ppBufferPtr = &ppBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (void** ppBufferPtr = &ppBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (uint* pBufferSizePtr = &pBufferSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (uint* pBufferSizePtr = &pBufferSize)
                    {
                        fixed (void** ppBufferPtr = &ppBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoder, Type);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReleaseDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoderPtr, Type);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoder);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DecoderEndFrame(ref ID3D11VideoDecoder pDecoder)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, VideoDecoderExtension* pExtensionData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, ref VideoDecoderExtension pExtensionData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderExtension(ref ID3D11VideoDecoder pDecoder, VideoDecoderExtension* pExtensionData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DecoderExtension(ref ID3D11VideoDecoder pDecoder, ref VideoDecoderExtension pExtensionData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int Enable, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int Enable, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int YCbCr, VideoColor* pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int YCbCr, ref VideoColor pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, VideoColor* pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, ref VideoColor pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoColor* pColorPtr = &pColor)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Core.Native.TagSize Size)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, Silk.NET.Core.Native.TagSize, void>)LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Core.Native.TagSize Size)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, Silk.NET.Core.Native.TagSize, void>)LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int Enable)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessor, Enable);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int Enable)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* EnabledPtr = &Enabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* EnabledPtr = &Enabled)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    fixed (VideoColor* pColorPtr = &pColor)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoColor* pColorPtr = &pColor)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pYCbCrPtr = &pYCbCr)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pYCbCrPtr = &pYCbCr)
                    {
                        fixed (VideoColor* pColorPtr = &pColor)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    fixed (uint* pStreamIndexPtr = &pStreamIndex)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (uint* pStreamIndexPtr = &pStreamIndex)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                    {
                        fixed (uint* pStreamIndexPtr = &pStreamIndex)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Core.Native.TagSize* pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, ref Silk.NET.Core.Native.TagSize pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagSize* pSizePtr = &pSize)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, Silk.NET.Core.Native.TagSize* pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, ref Silk.NET.Core.Native.TagSize pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Core.Native.TagSize* pSizePtr = &pSize)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, Silk.NET.Core.Native.TagSize* pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, ref Silk.NET.Core.Native.TagSize pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagSize* pSizePtr = &pSize)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, Silk.NET.Core.Native.TagSize* pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, ref Silk.NET.Core.Native.TagSize pSize)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (Silk.NET.Core.Native.TagSize* pSizePtr = &pSize)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, Silk.NET.Core.Native.TagSize*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabled);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Guid*, uint, T0*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Alpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Alpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (uint* pEntriesPtr = &pEntries)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                    {
                        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                    {
                        fixed (int* pRepeatFramePtr = &pRepeatFrame)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                    {
                        fixed (int* pRepeatFramePtr = &pRepeatFrame)
                        {
                            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pAlphaPtr = &pAlpha)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (float* pAlphaPtr = &pAlpha)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (float* pAlphaPtr = &pAlpha)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (uint* pEntriesPtr = &pEntries)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                        {
                            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        fixed (float* pUpperPtr = &pUpper)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        fixed (float* pUpperPtr = &pUpper)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (float* pUpperPtr = &pUpper)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (float* pLowerPtr = &pLower)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (float* pLowerPtr = &pLower)
                        {
                            fixed (float* pUpperPtr = &pUpper)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                        {
                            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (int* pLevelPtr = &pLevel)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pLevelPtr = &pLevel)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnabledPtr = &pEnabled)
                    {
                        fixed (int* pLevelPtr = &pLevel)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Guid*, uint, T0*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                    {
                        fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateCryptoSessionKeyExchange<T0>(ID3D11CryptoSession* pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateCryptoSessionKeyExchange(ref ID3D11CryptoSession pCryptoSession, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int NegotiateCryptoSessionKeyExchange<T0>(ref ID3D11CryptoSession pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                        {
                            fixed (T0* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, T0*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pIVPtr = &pIV)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (T1* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pContentKeyPtr = &pContentKey)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pIVPtr = &pIV)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (T1* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pContentKeyPtr = &pContentKey)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (T0* pIVPtr = &pIV)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (T1* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (T0* pContentKeyPtr = &pContentKey)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                        {
                            fixed (T0* pIVPtr = &pIV)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                        {
                            fixed (T0* pContentKeyPtr = &pContentKey)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                    {
                        fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                        {
                            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, T0*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, T0*, uint, T1*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void StartSessionKeyRefresh<T0>(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pRandomNumberPtr = &pRandomNumber)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void StartSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void StartSessionKeyRefresh<T0>(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pRandomNumberPtr = &pRandomNumber)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSession);
            }
        }

        /// <summary>To be added.</summary>
        public void FinishSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSessionPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEncryptionBltKey<T0>(ID3D11CryptoSession* pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pReadbackKeyPtr = &pReadbackKey)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetEncryptionBltKey(ref ID3D11CryptoSession pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetEncryptionBltKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pReadbackKeyPtr = &pReadbackKey)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateAuthenticatedChannelKeyExchange<T0>(ID3D11AuthenticatedChannel* pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, int>)LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateAuthenticatedChannelKeyExchange(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int NegotiateAuthenticatedChannelKeyExchange<T0>(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, uint, T0*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pInputPtr = &pInput)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel<T0, T1>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pInputPtr = &pInput)
                {
                    fixed (T1* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, uint, T1*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (T0* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, uint, T0*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (T0* pInputPtr = &pInput)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int QueryAuthenticatedChannel<T0, T1>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (T0* pInputPtr = &pInput)
                    {
                        fixed (T1* pOutputPtr = &pOutput)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, uint, T1*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pInputPtr = &pInput)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pInputPtr = &pInput)
                {
                    fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (T0* pInputPtr = &pInput)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
                {
                    fixed (T0* pInputPtr = &pInput)
                    {
                        fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11AuthenticatedChannel*, uint, T0*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers1(ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc1* pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers1(ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc1 pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderBufferDesc1* pBufferDescPtr = &pBufferDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)LpVtbl[65])(@this, pDecoder, NumBuffers, pBufferDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers1(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc1* pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)LpVtbl[65])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SubmitDecoderBuffers1(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc1 pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecoderBufferDesc1* pBufferDescPtr = &pBufferDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc1*, int>)LpVtbl[65])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ulong* pPrivateOutputData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, ulong*, int>)LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ref ulong pPrivateOutputData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, ulong*, int>)LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputData, pPrivateOutputDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey<T0>(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pPrivatInputDataPtr = &pPrivatInputData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, ulong*, int>)LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey<T0>(ID3D11CryptoSession* pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pPrivatInputDataPtr = &pPrivatInputData)
                {
                    fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, ulong*, int>)LpVtbl[66])(@this, pCryptoSession, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ulong* pPrivateOutputData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, ulong*, int>)LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputData, pPrivateOutputData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, void* pPrivatInputData, ref ulong pPrivateOutputData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, void*, ulong*, int>)LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputData, pPrivateOutputDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDataForNewHardwareKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ulong* pPrivateOutputData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pPrivatInputDataPtr = &pPrivatInputData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, ulong*, int>)LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDataForNewHardwareKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint PrivateInputSize, ref T0 pPrivatInputData, ref ulong pPrivateOutputData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pPrivatInputDataPtr = &pPrivatInputData)
                    {
                        fixed (ulong* pPrivateOutputDataPtr = &pPrivateOutputData)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, uint, T0*, ulong*, int>)LpVtbl[66])(@this, pCryptoSessionPtr, PrivateInputSize, pPrivatInputDataPtr, pPrivateOutputDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoSessionStatus(ID3D11CryptoSession* pCryptoSession, CryptoSessionStatus* pStatus)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)LpVtbl[67])(@this, pCryptoSession, pStatus);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoSessionStatus(ID3D11CryptoSession* pCryptoSession, ref CryptoSessionStatus pStatus)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (CryptoSessionStatus* pStatusPtr = &pStatus)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)LpVtbl[67])(@this, pCryptoSession, pStatusPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoSessionStatus(ref ID3D11CryptoSession pCryptoSession, CryptoSessionStatus* pStatus)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)LpVtbl[67])(@this, pCryptoSessionPtr, pStatus);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckCryptoSessionStatus(ref ID3D11CryptoSession pCryptoSession, ref CryptoSessionStatus pStatus)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (CryptoSessionStatus* pStatusPtr = &pStatus)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11CryptoSession*, CryptoSessionStatus*, int>)LpVtbl[67])(@this, pCryptoSessionPtr, pStatusPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderEnableDownsampling(ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDesc, ReferenceFrameCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderEnableDownsampling(ID3D11VideoDecoder* pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoSampleDesc pOutputDesc, uint ReferenceFrameCount)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)LpVtbl[68])(@this, pDecoder, InputColorSpace, pOutputDescPtr, ReferenceFrameCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderEnableDownsampling(ref ID3D11VideoDecoder pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoSampleDesc* pOutputDesc, uint ReferenceFrameCount)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)LpVtbl[68])(@this, pDecoderPtr, InputColorSpace, pOutputDesc, ReferenceFrameCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DecoderEnableDownsampling(ref ID3D11VideoDecoder pDecoder, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoSampleDesc pOutputDesc, uint ReferenceFrameCount)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, Silk.NET.DXGI.ColorSpaceType, VideoSampleDesc*, uint, int>)LpVtbl[68])(@this, pDecoderPtr, InputColorSpace, pOutputDescPtr, ReferenceFrameCount);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderUpdateDownsampling(ID3D11VideoDecoder* pDecoder, VideoSampleDesc* pOutputDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)LpVtbl[69])(@this, pDecoder, pOutputDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderUpdateDownsampling(ID3D11VideoDecoder* pDecoder, ref VideoSampleDesc pOutputDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)LpVtbl[69])(@this, pDecoder, pOutputDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderUpdateDownsampling(ref ID3D11VideoDecoder pDecoder, VideoSampleDesc* pOutputDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)LpVtbl[69])(@this, pDecoderPtr, pOutputDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DecoderUpdateDownsampling(ref ID3D11VideoDecoder pDecoder, ref VideoSampleDesc pOutputDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, VideoSampleDesc*, int>)LpVtbl[69])(@this, pDecoderPtr, pOutputDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)LpVtbl[70])(@this, pVideoProcessor, ColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType, void>)LpVtbl[70])(@this, pVideoProcessorPtr, ColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, int ShaderUsage)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, void>)LpVtbl[71])(@this, pVideoProcessor, ShaderUsage);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputShaderUsage(ref ID3D11VideoProcessor pVideoProcessor, int ShaderUsage)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int, void>)LpVtbl[71])(@this, pVideoProcessorPtr, ShaderUsage);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[72])(@this, pVideoProcessor, pColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputColorSpace1(ID3D11VideoProcessor* pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[72])(@this, pVideoProcessor, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[72])(@this, pVideoProcessorPtr, pColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[72])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, int* pShaderUsage)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[73])(@this, pVideoProcessor, pShaderUsage);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputShaderUsage(ID3D11VideoProcessor* pVideoProcessor, ref int pShaderUsage)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pShaderUsagePtr = &pShaderUsage)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[73])(@this, pVideoProcessor, pShaderUsagePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputShaderUsage(ref ID3D11VideoProcessor pVideoProcessor, int* pShaderUsage)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[73])(@this, pVideoProcessorPtr, pShaderUsage);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputShaderUsage(ref ID3D11VideoProcessor pVideoProcessor, ref int pShaderUsage)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pShaderUsagePtr = &pShaderUsage)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, int*, void>)LpVtbl[73])(@this, pVideoProcessorPtr, pShaderUsagePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)LpVtbl[74])(@this, pVideoProcessor, StreamIndex, ColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType ColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType, void>)LpVtbl[74])(@this, pVideoProcessorPtr, StreamIndex, ColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, int FlipHorizontal, int FlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, int, int, void>)LpVtbl[75])(@this, pVideoProcessor, StreamIndex, Enable, FlipHorizontal, FlipVertical);
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, int FlipHorizontal, int FlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int, int, int, void>)LpVtbl[75])(@this, pVideoProcessorPtr, StreamIndex, Enable, FlipHorizontal, FlipVertical);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamColorSpace1(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[76])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.ColorSpaceType* pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[76])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamColorSpace1(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.ColorSpaceType pColorSpace)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.ColorSpaceType* pColorSpacePtr = &pColorSpace)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.ColorSpaceType*, void>)LpVtbl[76])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pFlipVerticalPtr = &pFlipVertical)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontal, pFlipVerticalPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVertical);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVerticalPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVertical);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVerticalPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVertical);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                    {
                        fixed (int* pFlipVerticalPtr = &pFlipVertical)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVerticalPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontal, pFlipVertical);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pFlipVerticalPtr = &pFlipVertical)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontal, pFlipVerticalPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVertical);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                    {
                        fixed (int* pFlipVerticalPtr = &pFlipVertical)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFlipHorizontalPtr, pFlipVerticalPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVertical);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, int* pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pFlipVerticalPtr = &pFlipVertical)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontal, pFlipVerticalPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, int* pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVertical);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamMirror(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref int pFlipHorizontal, ref int pFlipVertical)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (int* pEnablePtr = &pEnable)
                    {
                        fixed (int* pFlipHorizontalPtr = &pFlipHorizontal)
                        {
                            fixed (int* pFlipVerticalPtr = &pFlipVertical)
                            {
                                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, int*, int*, int*, void>)LpVtbl[77])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFlipHorizontalPtr, pFlipVerticalPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHintsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHints);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ID3D11VideoProcessor* pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
                {
                    fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessor, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHintsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, uint* pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHints);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, VideoProcessorStreamBehaviorHint* pStreams, ref uint pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreams, pBehaviorHintsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, uint* pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHints);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int VideoProcessorGetBehaviorHints(ref ID3D11VideoProcessor pVideoProcessor, uint OutputWidth, uint OutputHeight, Silk.NET.DXGI.Format OutputFormat, uint StreamCount, ref VideoProcessorStreamBehaviorHint pStreams, ref uint pBehaviorHints)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessorStreamBehaviorHint* pStreamsPtr = &pStreams)
                    {
                        fixed (uint* pBehaviorHintsPtr = &pBehaviorHints)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, uint, Silk.NET.DXGI.Format, uint, VideoProcessorStreamBehaviorHint*, uint*, int>)LpVtbl[78])(@this, pVideoProcessorPtr, OutputWidth, OutputHeight, OutputFormat, StreamCount, pStreamsPtr, pBehaviorHintsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.HdrMetadataType Type, uint Size, void* pHDRMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType, uint, void*, void>)LpVtbl[79])(@this, pVideoProcessor, Type, Size, pHDRMetaData);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputHDRMetaData<T0>(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.HdrMetadataType Type, uint Size, ref T0 pHDRMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pHDRMetaDataPtr = &pHDRMetaData)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType, uint, T0*, void>)LpVtbl[79])(@this, pVideoProcessor, Type, Size, pHDRMetaDataPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetOutputHDRMetaData(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.HdrMetadataType Type, uint Size, void* pHDRMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType, uint, void*, void>)LpVtbl[79])(@this, pVideoProcessorPtr, Type, Size, pHDRMetaData);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetOutputHDRMetaData<T0>(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.HdrMetadataType Type, uint Size, ref T0 pHDRMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pHDRMetaDataPtr = &pHDRMetaData)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType, uint, T0*, void>)LpVtbl[79])(@this, pVideoProcessorPtr, Type, Size, pHDRMetaDataPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[80])(@this, pVideoProcessor, pType, Size, pMetaData);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData<T0>(ID3D11VideoProcessor* pVideoProcessor, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pMetaDataPtr = &pMetaData)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[80])(@this, pVideoProcessor, pType, Size, pMetaDataPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[80])(@this, pVideoProcessor, pTypePtr, Size, pMetaData);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                {
                    fixed (T0* pMetaDataPtr = &pMetaData)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[80])(@this, pVideoProcessor, pTypePtr, Size, pMetaDataPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[80])(@this, pVideoProcessorPtr, pType, Size, pMetaData);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData<T0>(ref ID3D11VideoProcessor pVideoProcessor, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pMetaDataPtr = &pMetaData)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[80])(@this, pVideoProcessorPtr, pType, Size, pMetaDataPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetOutputHDRMetaData(ref ID3D11VideoProcessor pVideoProcessor, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[80])(@this, pVideoProcessorPtr, pTypePtr, Size, pMetaData);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetOutputHDRMetaData<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                    {
                        fixed (T0* pMetaDataPtr = &pMetaData)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[80])(@this, pVideoProcessorPtr, pTypePtr, Size, pMetaDataPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType Type, uint Size, void* pHDRMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType, uint, void*, void>)LpVtbl[81])(@this, pVideoProcessor, StreamIndex, Type, Size, pHDRMetaData);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamHDRMetaData<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType Type, uint Size, ref T0 pHDRMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pHDRMetaDataPtr = &pHDRMetaData)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType, uint, T0*, void>)LpVtbl[81])(@this, pVideoProcessor, StreamIndex, Type, Size, pHDRMetaDataPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorSetStreamHDRMetaData(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType Type, uint Size, void* pHDRMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType, uint, void*, void>)LpVtbl[81])(@this, pVideoProcessorPtr, StreamIndex, Type, Size, pHDRMetaData);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorSetStreamHDRMetaData<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType Type, uint Size, ref T0 pHDRMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pHDRMetaDataPtr = &pHDRMetaData)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType, uint, T0*, void>)LpVtbl[81])(@this, pVideoProcessorPtr, StreamIndex, Type, Size, pHDRMetaDataPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[82])(@this, pVideoProcessor, StreamIndex, pType, Size, pMetaData);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (T0* pMetaDataPtr = &pMetaData)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[82])(@this, pVideoProcessor, StreamIndex, pType, Size, pMetaDataPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[82])(@this, pVideoProcessor, StreamIndex, pTypePtr, Size, pMetaData);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                {
                    fixed (T0* pMetaDataPtr = &pMetaData)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[82])(@this, pVideoProcessor, StreamIndex, pTypePtr, Size, pMetaDataPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[82])(@this, pVideoProcessorPtr, StreamIndex, pType, Size, pMetaData);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Silk.NET.DXGI.HdrMetadataType* pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (T0* pMetaDataPtr = &pMetaData)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[82])(@this, pVideoProcessorPtr, StreamIndex, pType, Size, pMetaDataPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VideoProcessorGetStreamHDRMetaData(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, void* pMetaData)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                    {
                        ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, void*, void>)LpVtbl[82])(@this, pVideoProcessorPtr, StreamIndex, pTypePtr, Size, pMetaData);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void VideoProcessorGetStreamHDRMetaData<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Silk.NET.DXGI.HdrMetadataType pType, uint Size, ref T0 pMetaData) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (Silk.NET.DXGI.HdrMetadataType* pTypePtr = &pType)
                    {
                        fixed (T0* pMetaDataPtr = &pMetaData)
                        {
                            ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoProcessor*, uint, Silk.NET.DXGI.HdrMetadataType*, uint, T0*, void>)LpVtbl[82])(@this, pVideoProcessorPtr, StreamIndex, pTypePtr, Size, pMetaDataPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                {
                    fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (T0* pContentKeyPtr = &pContentKey)
                {
                    fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                    {
                        fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                    {
                        fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                        {
                            fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                    {
                        fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (T0* pContentKeyPtr = &pContentKey)
                    {
                        fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                        {
                            fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                        {
                            fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffers);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, uint* pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsets, ppHistogramBuffersPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ID3D11Buffer** ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffers);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DecoderBeginFrame1<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey, uint NumComponentHistograms, ref uint pHistogramOffsets, ref ID3D11Buffer* ppHistogramBuffers) where T0 : unmanaged
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                    {
                        fixed (T0* pContentKeyPtr = &pContentKey)
                        {
                            fixed (uint* pHistogramOffsetsPtr = &pHistogramOffsets)
                            {
                                fixed (ID3D11Buffer** ppHistogramBuffersPtr = &ppHistogramBuffers)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, T0*, uint, uint*, ID3D11Buffer**, int>)LpVtbl[83])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr, NumComponentHistograms, pHistogramOffsetsPtr, ppHistogramBuffersPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers2(ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc2* pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc2*, int>)LpVtbl[84])(@this, pDecoder, NumBuffers, pBufferDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers2(ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc2 pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderBufferDesc2* pBufferDescPtr = &pBufferDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc2*, int>)LpVtbl[84])(@this, pDecoder, NumBuffers, pBufferDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SubmitDecoderBuffers2(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc2* pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc2*, int>)LpVtbl[84])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SubmitDecoderBuffers2(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc2 pBufferDesc)
        {
            fixed (ID3D11VideoContext3* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
                {
                    fixed (VideoDecoderBufferDesc2* pBufferDescPtr = &pBufferDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoContext3*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc2*, int>)LpVtbl[84])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                    }
                }
                return ret;
            }
        }

    }
}
