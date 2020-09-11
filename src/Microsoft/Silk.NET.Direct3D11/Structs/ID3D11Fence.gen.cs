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
    [NativeName("Name", "ID3D11Fence")]
    public unsafe partial struct ID3D11Fence
    {
        public static implicit operator ID3D11DeviceChild(ID3D11Fence val)
            => Unsafe.As<ID3D11Fence, ID3D11DeviceChild>(ref val);

        public readonly ref ID3D11DeviceChild AsDeviceChild()
        {
            fixed (ID3D11Fence* @this = &this)
            {
                return ref *(ID3D11DeviceChild*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Fence val)
            => Unsafe.As<ID3D11Fence, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11Fence* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11Fence
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
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11Fence* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11Fence* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                ((delegate* cdecl<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                fixed (ID3D11Device** ppDevicePtr = &ppDevice)
                {
                    ((delegate* cdecl<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (char* lpNamePtr = &lpName)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (char* lpNamePtr = &lpName)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, string lpName, void** pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, string lpName, ref void* pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                }
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* lpNamePtr = &lpName)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* lpNamePtr = &lpName)
                    {
                        fixed (void** pHandlePtr = &pHandle)
                        {
                            ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, string lpName, void** pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                    ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, string lpName, ref void* pHandle)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var lpNamePtr = (byte*) Marshal.StringToHGlobalAnsi(lpName);
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* cdecl<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                    }
            Marshal.FreeHGlobal((IntPtr)lpNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public ulong GetCompletedValue()
        {
            fixed (ID3D11Fence* @this = &this)
            {
                ulong ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, ulong>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetEventOnCompletion(ulong Value, void* hEvent)
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEvent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetEventOnCompletion<T0>(ulong Value, ref T0 hEvent) where T0 : unmanaged
        {
            fixed (ID3D11Fence* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    ret = ((delegate* cdecl<ID3D11Fence*, ulong, T0*, int>)LpVtbl[9])(@this, Value, hEventPtr);
                }
                return ret;
            }
        }

    }
}
