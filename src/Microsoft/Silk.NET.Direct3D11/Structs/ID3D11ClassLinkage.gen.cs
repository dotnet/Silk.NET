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
    [Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed")]
    [NativeName("Name", "ID3D11ClassLinkage")]
    public unsafe partial struct ID3D11ClassLinkage
    {
        public static readonly Guid Guid = new("ddf57cba-9543-46e4-a12b-f207a0fe7fed");

        public static implicit operator ID3D11DeviceChild(ID3D11ClassLinkage val)
            => Unsafe.As<ID3D11ClassLinkage, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ClassLinkage val)
            => Unsafe.As<ID3D11ClassLinkage, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ClassLinkage
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
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInstance(byte* pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceName, InstanceIndex, ppInstance);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInstance(byte* pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceName, InstanceIndex, ppInstancePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInstance(ref byte pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pClassInstanceNamePtr = &pClassInstanceName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstance);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInstance(ref byte pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pClassInstanceNamePtr = &pClassInstanceName)
            {
                fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstancePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInstance([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pClassInstanceNamePtr = (byte*) SilkMarshal.StringToPtr(pClassInstanceName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstance);
            SilkMarshal.Free((nint)pClassInstanceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassInstance([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pClassInstanceNamePtr = (byte*) SilkMarshal.StringToPtr(pClassInstanceName, NativeStringEncoding.LPStr);
            fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstancePtr);
            }
            SilkMarshal.Free((nint)pClassInstanceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassInstance(byte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassInstance(byte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassInstance(ref byte pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pClassTypeNamePtr = &pClassTypeName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassInstance(ref byte pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pClassTypeNamePtr = &pClassTypeName)
            {
                fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassInstance([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pClassTypeNamePtr = (byte*) SilkMarshal.StringToPtr(pClassTypeName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
            SilkMarshal.Free((nint)pClassTypeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateClassInstance([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance)
        {
            var @this = (ID3D11ClassLinkage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pClassTypeNamePtr = (byte*) SilkMarshal.StringToPtr(pClassTypeName, NativeStringEncoding.LPStr);
            fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
            }
            SilkMarshal.Free((nint)pClassTypeNamePtr);
            return ret;
        }

    }
}
