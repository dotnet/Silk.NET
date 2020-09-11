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
    [NativeName("Name", "ID3D12VideoProcessor1")]
    public unsafe partial struct ID3D12VideoProcessor1
    {
        public static implicit operator ID3D12VideoProcessor(ID3D12VideoProcessor1 val)
            => Unsafe.As<ID3D12VideoProcessor1, ID3D12VideoProcessor>(ref val);

        public readonly ref ID3D12VideoProcessor AsVideoProcessor()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                return ref *(ID3D12VideoProcessor*)@this;
            }
        }

        public static implicit operator ID3D12Pageable(ID3D12VideoProcessor1 val)
            => Unsafe.As<ID3D12VideoProcessor1, ID3D12Pageable>(ref val);

        public readonly ref ID3D12Pageable AsPageable()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                return ref *(ID3D12Pageable*)@this;
            }
        }

        public static implicit operator ID3D12DeviceChild(ID3D12VideoProcessor1 val)
            => Unsafe.As<ID3D12VideoProcessor1, ID3D12DeviceChild>(ref val);

        public readonly ref ID3D12DeviceChild AsDeviceChild()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                return ref *(ID3D12DeviceChild*)@this;
            }
        }

        public static implicit operator ID3D12Object(ID3D12VideoProcessor1 val)
            => Unsafe.As<ID3D12VideoProcessor1, ID3D12Object>(ref val);

        public readonly ref ID3D12Object AsObject()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                return ref *(ID3D12Object*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoProcessor1 val)
            => Unsafe.As<ID3D12VideoProcessor1, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12VideoProcessor1
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
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetNodeMask()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, uint>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetNumInputStreamDescs()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, uint>)LpVtbl[9])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetInputStreamDescs(uint NumInputStreamDescs, VideoProcessInputStreamDesc* pInputStreamDescs)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, uint, VideoProcessInputStreamDesc*, int>)LpVtbl[10])(@this, NumInputStreamDescs, pInputStreamDescs);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetInputStreamDescs(uint NumInputStreamDescs, ref VideoProcessInputStreamDesc pInputStreamDescs)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessInputStreamDesc* pInputStreamDescsPtr = &pInputStreamDescs)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, uint, VideoProcessInputStreamDesc*, int>)LpVtbl[10])(@this, NumInputStreamDescs, pInputStreamDescsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public VideoProcessOutputStreamDesc GetOutputStreamDesc()
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                VideoProcessOutputStreamDesc ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, VideoProcessOutputStreamDesc>)LpVtbl[11])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(Guid* riid, void** ppProtectedSession)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[12])(@this, riid, ppProtectedSession);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(Guid* riid, ref void* ppProtectedSession)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[12])(@this, riid, ppProtectedSessionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(ref Guid riid, void** ppProtectedSession)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[12])(@this, riidPtr, ppProtectedSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetProtectedResourceSession(ref Guid riid, ref void* ppProtectedSession)
        {
            fixed (ID3D12VideoProcessor1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppProtectedSessionPtr = &ppProtectedSession)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessor1*, Guid*, void**, int>)LpVtbl[12])(@this, riidPtr, ppProtectedSessionPtr);
                    }
                }
                return ret;
            }
        }

    }
}
