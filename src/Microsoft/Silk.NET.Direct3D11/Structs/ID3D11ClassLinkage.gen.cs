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
    [NativeName("Name", "ID3D11ClassLinkage")]
    public unsafe partial struct ID3D11ClassLinkage
    {
        public static implicit operator ID3D11DeviceChild(ID3D11ClassLinkage val)
            => Unsafe.As<ID3D11ClassLinkage, ID3D11DeviceChild>(ref val);

        public readonly ref ID3D11DeviceChild AsDeviceChild()
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                return ref *(ID3D11DeviceChild*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ClassLinkage val)
            => Unsafe.As<ID3D11ClassLinkage, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11ClassLinkage
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
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                ((delegate* cdecl<ID3D11ClassLinkage*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                fixed (ID3D11Device** ppDevicePtr = &ppDevice)
                {
                    ((delegate* cdecl<ID3D11ClassLinkage*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClassInstance(byte* pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceName, InstanceIndex, ppInstance);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClassInstance(byte* pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceName, InstanceIndex, ppInstancePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClassInstance(ref byte pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (byte* pClassInstanceNamePtr = &pClassInstanceName)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstance);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClassInstance(ref byte pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (byte* pClassInstanceNamePtr = &pClassInstanceName)
                {
                    fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstancePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClassInstance(string pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
            var pClassInstanceNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pClassInstanceName);
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstance);
            Marshal.FreeHGlobal((IntPtr)pClassInstanceNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClassInstance(string pClassInstanceName, uint InstanceIndex, ref ID3D11ClassInstance* ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
            var pClassInstanceNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pClassInstanceName);
                fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, ID3D11ClassInstance**, int>)LpVtbl[7])(@this, pClassInstanceNamePtr, InstanceIndex, ppInstancePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pClassInstanceNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateClassInstance(byte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateClassInstance(byte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateClassInstance(ref byte pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (byte* pClassTypeNamePtr = &pClassTypeName)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateClassInstance(ref byte pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
                fixed (byte* pClassTypeNamePtr = &pClassTypeName)
                {
                    fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                    {
                        ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateClassInstance(string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
            var pClassTypeNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pClassTypeName);
                ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
            Marshal.FreeHGlobal((IntPtr)pClassTypeNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateClassInstance(string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref ID3D11ClassInstance* ppInstance)
        {
            fixed (ID3D11ClassLinkage* @this = &this)
            {
                int ret = default;
            var pClassTypeNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pClassTypeName);
                fixed (ID3D11ClassInstance** ppInstancePtr = &ppInstance)
                {
                    ret = ((delegate* cdecl<ID3D11ClassLinkage*, byte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)LpVtbl[8])(@this, pClassTypeNamePtr, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstancePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pClassTypeNamePtr);
                return ret;
            }
        }

    }
}
