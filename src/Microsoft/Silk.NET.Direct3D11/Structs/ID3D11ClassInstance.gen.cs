// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb")]
    [NativeName("Name", "ID3D11ClassInstance")]
    public unsafe partial struct ID3D11ClassInstance
    {
        public static implicit operator ID3D11DeviceChild(ID3D11ClassInstance val)
            => Unsafe.As<ID3D11ClassInstance, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ClassInstance val)
            => Unsafe.As<ID3D11ClassInstance, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ClassInstance
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetClassLinkage(ID3D11ClassLinkage** ppLinkage)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)LpVtbl[7])(@this, ppLinkage);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetClassLinkage(ref ID3D11ClassLinkage* ppLinkage)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassLinkage** ppLinkagePtr = &ppLinkage)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)LpVtbl[7])(@this, ppLinkagePtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetDesc(ClassInstanceDesc* pDesc)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, ClassInstanceDesc*, void>)LpVtbl[8])(@this, pDesc);
        }

        /// <summary>To be added.</summary>
        public readonly void GetDesc(ref ClassInstanceDesc pDesc)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ClassInstanceDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, ClassInstanceDesc*, void>)LpVtbl[8])(@this, pDescPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetInstanceName(byte* pInstanceName, uint* pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[9])(@this, pInstanceName, pBufferLength);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetInstanceName(byte* pInstanceName, ref uint pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pBufferLengthPtr = &pBufferLength)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[9])(@this, pInstanceName, pBufferLengthPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetInstanceName(ref byte pInstanceName, uint* pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pInstanceNamePtr = &pInstanceName)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[9])(@this, pInstanceNamePtr, pBufferLength);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void GetInstanceName(ref byte pInstanceName, ref uint pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pInstanceNamePtr = &pInstanceName)
            {
                fixed (uint* pBufferLengthPtr = &pBufferLength)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[9])(@this, pInstanceNamePtr, pBufferLengthPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetInstanceName(string pInstanceName, uint* pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pInstanceNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pInstanceName);
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[9])(@this, pInstanceNamePtr, pBufferLength);
            Marshal.FreeHGlobal((IntPtr)pInstanceNamePtr);
        }

        /// <summary>To be added.</summary>
        public readonly void GetInstanceName(string pInstanceName, ref uint pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pInstanceNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pInstanceName);
            fixed (uint* pBufferLengthPtr = &pBufferLength)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[9])(@this, pInstanceNamePtr, pBufferLengthPtr);
            }
            Marshal.FreeHGlobal((IntPtr)pInstanceNamePtr);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetTypeName(byte* pTypeName, uint* pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[10])(@this, pTypeName, pBufferLength);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetTypeName(byte* pTypeName, ref uint pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pBufferLengthPtr = &pBufferLength)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[10])(@this, pTypeName, pBufferLengthPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetTypeName(ref byte pTypeName, uint* pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pTypeNamePtr = &pTypeName)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[10])(@this, pTypeNamePtr, pBufferLength);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void GetTypeName(ref byte pTypeName, ref uint pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pTypeNamePtr = &pTypeName)
            {
                fixed (uint* pBufferLengthPtr = &pBufferLength)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[10])(@this, pTypeNamePtr, pBufferLengthPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetTypeName(string pTypeName, uint* pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pTypeNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTypeName);
            ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[10])(@this, pTypeNamePtr, pBufferLength);
            Marshal.FreeHGlobal((IntPtr)pTypeNamePtr);
        }

        /// <summary>To be added.</summary>
        public readonly void GetTypeName(string pTypeName, ref uint pBufferLength)
        {
            var @this = (ID3D11ClassInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pTypeNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTypeName);
            fixed (uint* pBufferLengthPtr = &pBufferLength)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassInstance*, byte*, uint*, void>)LpVtbl[10])(@this, pTypeNamePtr, pBufferLengthPtr);
            }
            Marshal.FreeHGlobal((IntPtr)pTypeNamePtr);
        }

    }
}
