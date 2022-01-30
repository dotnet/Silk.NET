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
    [Guid("affde9d1-1df7-4bb7-8a34-0f46251dab80")]
    [NativeName("Name", "ID3D11Fence")]
    public unsafe partial struct ID3D11Fence
    {
        public static readonly Guid Guid = new("affde9d1-1df7-4bb7-8a34-0f46251dab80");

        public static implicit operator ID3D11DeviceChild(ID3D11Fence val)
            => Unsafe.As<ID3D11Fence, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Fence val)
            => Unsafe.As<ID3D11Fence, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Fence
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
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11Fence*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandlePtr = &pHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* lpNamePtr = &lpName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* lpNamePtr = &lpName)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            }
            #endif
            SilkMarshal.Free((nint)lpNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)lpNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* lpNamePtr = &lpName)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* lpNamePtr = &lpName)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                }
            #endif
            SilkMarshal.Free((nint)lpNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[7])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                    }
            #endif
                }
            SilkMarshal.Free((nint)lpNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetCompletedValue()
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnCompletion(ulong Value, void* hEvent)
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEvent);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEvent);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEvent);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEventOnCompletion<T0>(ulong Value, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D11Fence*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEventPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEventPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Fence*, ulong, void*, int>)LpVtbl[9])(@this, Value, hEventPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
