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
    [NativeName("Name", "ID3D11DeviceContext4")]
    public unsafe partial struct ID3D11DeviceContext4
    {
        public static implicit operator ID3D11DeviceContext3(ID3D11DeviceContext4 val)
            => Unsafe.As<ID3D11DeviceContext4, ID3D11DeviceContext3>(ref val);

        public readonly ref ID3D11DeviceContext3 AsDeviceContext3()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                return ref *(ID3D11DeviceContext3*)@this;
            }
        }

        public static implicit operator ID3D11DeviceContext2(ID3D11DeviceContext4 val)
            => Unsafe.As<ID3D11DeviceContext4, ID3D11DeviceContext2>(ref val);

        public readonly ref ID3D11DeviceContext2 AsDeviceContext2()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                return ref *(ID3D11DeviceContext2*)@this;
            }
        }

        public static implicit operator ID3D11DeviceContext1(ID3D11DeviceContext4 val)
            => Unsafe.As<ID3D11DeviceContext4, ID3D11DeviceContext1>(ref val);

        public readonly ref ID3D11DeviceContext1 AsDeviceContext1()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                return ref *(ID3D11DeviceContext1*)@this;
            }
        }

        public static implicit operator ID3D11DeviceContext(ID3D11DeviceContext4 val)
            => Unsafe.As<ID3D11DeviceContext4, ID3D11DeviceContext>(ref val);

        public readonly ref ID3D11DeviceContext AsDeviceContext()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                return ref *(ID3D11DeviceContext*)@this;
            }
        }

        public static implicit operator ID3D11DeviceChild(ID3D11DeviceContext4 val)
            => Unsafe.As<ID3D11DeviceContext4, ID3D11DeviceChild>(ref val);

        public readonly ref ID3D11DeviceChild AsDeviceChild()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                return ref *(ID3D11DeviceChild*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11DeviceContext4 val)
            => Unsafe.As<ID3D11DeviceContext4, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11DeviceContext4
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
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Device** ppDevicePtr = &ppDevice)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint*, T0*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, uint, T0*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetShader(ref ID3D11PixelShader pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetShader(ref ID3D11PixelShader pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetShader(ref ID3D11VertexShader pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetShader(ref ID3D11VertexShader pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, int, void>)LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void Draw(uint VertexCount, uint StartVertexLocation)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, void>)LpVtbl[13])(@this, VertexCount, StartVertexLocation);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Map(ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void Unmap(ID3D11Resource* pResource, uint Subresource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResource, Subresource);
            }
        }

        /// <summary>To be added.</summary>
        public void Unmap(ref ID3D11Resource pResource, uint Subresource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResourcePtr, Subresource);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayout);
            }
        }

        /// <summary>To be added.</summary>
        public void IASetInputLayout(ref ID3D11InputLayout pInputLayout)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11InputLayout* pInputLayoutPtr = &pInputLayout)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayoutPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    fixed (uint* pStridesPtr = &pStrides)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    fixed (uint* pStridesPtr = &pStrides)
                    {
                        fixed (uint* pOffsetsPtr = &pOffsets)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
            }
        }

        /// <summary>To be added.</summary>
        public void IASetIndexBuffer(ref ID3D11Buffer pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pIndexBufferPtr = &pIndexBuffer)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, uint, int, uint, void>)LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
        }

        /// <summary>To be added.</summary>
        public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, uint, uint, void>)LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetShader(ID3D11GeometryShader* pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetShader(ID3D11GeometryShader* pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetShader(ref ID3D11GeometryShader pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetShader(ref ID3D11GeometryShader pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology Topology)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[24])(@this, Topology);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void Begin(ID3D11Asynchronous* pAsync)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsync);
            }
        }

        /// <summary>To be added.</summary>
        public void Begin(ref ID3D11Asynchronous pAsync)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsyncPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void End(ID3D11Asynchronous* pAsync)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsync);
            }
        }

        /// <summary>To be added.</summary>
        public void End(ref ID3D11Asynchronous pAsync)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsyncPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetData<T0>(ID3D11Asynchronous* pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, T0*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetData(ref ID3D11Asynchronous pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetData<T0>(ref ID3D11Asynchronous pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Asynchronous*, T0*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetPredication(ID3D11Predicate* pPredicate, int PredicateValue)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicate, PredicateValue);
            }
        }

        /// <summary>To be added.</summary>
        public void SetPredication(ref ID3D11Predicate pPredicate, int PredicateValue)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Predicate* pPredicatePtr = &pPredicate)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                    {
                        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                    {
                        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                    {
                        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                        {
                            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                            {
                                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetBlendState(ref ID3D11BlendState pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void OMSetBlendState(ref ID3D11BlendState pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
                {
                    fixed (float* BlendFactorPtr = &BlendFactor)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilState, StencilRef);
            }
        }

        /// <summary>To be added.</summary>
        public void OMSetDepthStencilState(ref ID3D11DepthStencilState pDepthStencilState, uint StencilRef)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilState* pDepthStencilStatePtr = &pDepthStencilState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOSetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOSetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOSetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOSetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DrawAuto()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, void>)LpVtbl[38])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
        }

        /// <summary>To be added.</summary>
        public void DrawIndexedInstancedIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
        }

        /// <summary>To be added.</summary>
        public void DrawInstancedIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, uint, void>)LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
        }

        /// <summary>To be added.</summary>
        public void DispatchIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerState);
            }
        }

        /// <summary>To be added.</summary>
        public void RSSetState(ref ID3D11RasterizerState pRasterizerState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RasterizerState* pRasterizerStatePtr = &pRasterizerState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerStatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSSetViewports(uint NumViewports, Viewport* pViewports)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewports);
            }
        }

        /// <summary>To be added.</summary>
        public void RSSetViewports(uint NumViewports, ref Viewport pViewports)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Viewport* pViewportsPtr = &pViewports)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewportsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSSetScissorRects(uint NumRects, Silk.NET.Core.Native.TagRect* pRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[45])(@this, NumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public void RSSetScissorRects(uint NumRects, ref Silk.NET.Core.Native.TagRect pRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[45])(@this, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (Box* pSrcBoxPtr = &pSrcBox)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResource);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyResource(ID3D11Resource* pDstResource, ref ID3D11Resource pSrcResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyResource(ref ID3D11Resource pDstResource, ID3D11Resource* pSrcResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyResource(ref ID3D11Resource pDstResource, ref ID3D11Resource pSrcResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource<T0>(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (T0* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource<T0>(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (T0* pSrcDataPtr = &pSrcData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (T0* pSrcDataPtr = &pSrcData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (Box* pDstBoxPtr = &pDstBox)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void UpdateSubresource<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (Box* pDstBoxPtr = &pDstBox)
                    {
                        fixed (T0* pSrcDataPtr = &pSrcData)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyStructureCount(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyStructureCount(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
                {
                    fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* ColorRGBAPtr = &ColorRGBA)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearRenderTargetView(ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearRenderTargetView(ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
                {
                    fixed (float* ColorRGBAPtr = &ColorRGBA)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, Values);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewUint(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearUnorderedAccessViewUint(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
                {
                    fixed (uint* ValuesPtr = &Values)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, Values);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref float Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearUnorderedAccessViewFloat(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearUnorderedAccessViewFloat(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref float Values)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
                {
                    fixed (float* ValuesPtr = &Values)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
            }
        }

        /// <summary>To be added.</summary>
        public void ClearDepthStencilView(ref ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceView);
            }
        }

        /// <summary>To be added.</summary>
        public void GenerateMips(ref ID3D11ShaderResourceView pShaderResourceView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView* pShaderResourceViewPtr = &pShaderResourceView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceViewPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResource, MinLOD);
            }
        }

        /// <summary>To be added.</summary>
        public void SetResourceMinLOD(ref ID3D11Resource pResource, float MinLOD)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResourcePtr, MinLOD);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                float ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResource);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public float GetResourceMinLOD(ref ID3D11Resource pResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                float ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResourcePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ResolveSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteCommandList(ID3D11CommandList* pCommandList, int RestoreContextState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandList, RestoreContextState);
            }
        }

        /// <summary>To be added.</summary>
        public void ExecuteCommandList(ref ID3D11CommandList pCommandList, int RestoreContextState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11CommandList* pCommandListPtr = &pCommandList)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetShader(ID3D11HullShader* pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetShader(ID3D11HullShader* pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetShader(ref ID3D11HullShader pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetShader(ref ID3D11HullShader pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetShader(ref ID3D11DomainShader pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetShader(ref ID3D11DomainShader pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetShader(ref ID3D11ComputeShader pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetShader(ref ID3D11ComputeShader pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayout);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetInputLayout(ref ID3D11InputLayout* ppInputLayout)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11InputLayout** ppInputLayoutPtr = &ppInputLayout)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayoutPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    fixed (uint* pStridesPtr = &pStrides)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
                {
                    fixed (uint* pStridesPtr = &pStrides)
                    {
                        fixed (uint* pOffsetsPtr = &pOffsets)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                {
                    fixed (uint* OffsetPtr = &Offset)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
                {
                    fixed (uint* OffsetPtr = &Offset)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
                {
                    fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
                {
                    fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                    {
                        fixed (uint* OffsetPtr = &Offset)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void IAGetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopology);
            }
        }

        /// <summary>To be added.</summary>
        public void IAGetPrimitiveTopology(ref Silk.NET.Core.Native.D3DPrimitiveTopology pTopology)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.Core.Native.D3DPrimitiveTopology* pTopologyPtr = &pTopology)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopologyPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetPredication(ID3D11Predicate** ppPredicate, int* pPredicateValue)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValue);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetPredication(ID3D11Predicate** ppPredicate, ref int pPredicateValue)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (int* pPredicateValuePtr = &pPredicateValue)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetPredication(ref ID3D11Predicate* ppPredicate, int* pPredicateValue)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetPredication(ref ID3D11Predicate* ppPredicate, ref int pPredicateValue)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
                {
                    fixed (int* pPredicateValuePtr = &pPredicateValue)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
                {
                    fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                    {
                        fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    fixed (uint* pSampleMaskPtr = &pSampleMask)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
                {
                    fixed (uint* pSampleMaskPtr = &pSampleMask)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
                {
                    fixed (float* BlendFactorPtr = &BlendFactor)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
                {
                    fixed (float* BlendFactorPtr = &BlendFactor)
                    {
                        fixed (uint* pSampleMaskPtr = &pSampleMask)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, ref uint pStencilRef)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pStencilRefPtr = &pStencilRef)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetDepthStencilState(ref ID3D11DepthStencilState* ppDepthStencilState, uint* pStencilRef)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void OMGetDepthStencilState(ref ID3D11DepthStencilState* ppDepthStencilState, ref uint pStencilRef)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
                {
                    fixed (uint* pStencilRefPtr = &pStencilRef)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargets);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SOGetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerState);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetState(ref ID3D11RasterizerState* ppRasterizerState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11RasterizerState** ppRasterizerStatePtr = &ppRasterizerState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerStatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetViewports(uint* pNumViewports, Viewport* pViewports)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewports);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetViewports(uint* pNumViewports, ref Viewport pViewports)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Viewport* pViewportsPtr = &pViewports)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetViewports(ref uint pNumViewports, Viewport* pViewports)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumViewportsPtr = &pNumViewports)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void RSGetViewports(ref uint pNumViewports, ref Viewport pViewports)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumViewportsPtr = &pNumViewports)
                {
                    fixed (Viewport* pViewportsPtr = &pViewports)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetScissorRects(uint* pNumRects, Silk.NET.Core.Native.TagRect* pRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[96])(@this, pNumRects, pRects);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetScissorRects(uint* pNumRects, ref Silk.NET.Core.Native.TagRect pRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[96])(@this, pNumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void RSGetScissorRects(ref uint pNumRects, Silk.NET.Core.Native.TagRect* pRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumRectsPtr = &pNumRects)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void RSGetScissorRects(ref uint pNumRects, ref Silk.NET.Core.Native.TagRect pRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumRectsPtr = &pNumRects)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint*, Silk.NET.Core.Native.TagRect*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
                {
                    fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                    {
                        fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearState()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, void>)LpVtbl[110])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public void Flush()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, void>)LpVtbl[111])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public DeviceContextType GetType()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                DeviceContextType ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, DeviceContextType>)LpVtbl[112])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetContextFlags()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, uint>)LpVtbl[113])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FinishCommandList(int RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FinishCommandList(int RestoreDeferredContextState, ref ID3D11CommandList* ppCommandList)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CommandList** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (Box* pSrcBoxPtr = &pSrcBox)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1<T0>(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (T0* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1<T0>(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (T0* pSrcDataPtr = &pSrcData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (T0* pSrcDataPtr = &pSrcData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateSubresource1(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (Box* pDstBoxPtr = &pDstBox)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void UpdateSubresource1<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (Box* pDstBoxPtr = &pDstBox)
                    {
                        fixed (T0* pSrcDataPtr = &pSrcData)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, Box*, T0*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D11Resource* pResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResource);
            }
        }

        /// <summary>To be added.</summary>
        public void DiscardResource(ref ID3D11Resource pResource)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResourcePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardView(ID3D11View* pResourceView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceView);
            }
        }

        /// <summary>To be added.</summary>
        public void DiscardView(ref ID3D11View pResourceView)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pResourceViewPtr = &pResourceView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceViewPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
                {
                    fixed (uint* pFirstConstantPtr = &pFirstConstant)
                    {
                        fixed (uint* pNumConstantsPtr = &pNumConstants)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousState);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ref ID3DDeviceContextState* ppPreviousState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousStatePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SwapDeviceContextState(ref ID3DDeviceContextState pState, ID3DDeviceContextState** ppPreviousState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3DDeviceContextState* pStatePtr = &pState)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousState);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SwapDeviceContextState(ref ID3DDeviceContextState pState, ref ID3DDeviceContextState* ppPreviousState)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3DDeviceContextState* pStatePtr = &pState)
                {
                    fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousStatePtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, Silk.NET.Core.Native.TagRect* pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pView, Color, pRect, NumRects);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, ref Silk.NET.Core.Native.TagRect pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pView, Color, pRectPtr, NumRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] ref float Color, Silk.NET.Core.Native.TagRect* pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* ColorPtr = &Color)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRect, NumRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] ref float Color, ref Silk.NET.Core.Native.TagRect pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (float* ColorPtr = &Color)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRectPtr, NumRects);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] float* Color, Silk.NET.Core.Native.TagRect* pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pViewPtr = &pView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRect, NumRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] float* Color, ref Silk.NET.Core.Native.TagRect pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pViewPtr = &pView)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRectPtr, NumRects);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] ref float Color, Silk.NET.Core.Native.TagRect* pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pViewPtr = &pView)
                {
                    fixed (float* ColorPtr = &Color)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRect, NumRects);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ClearView(ref ID3D11View pView, [Count(Count = 4)] ref float Color, ref Silk.NET.Core.Native.TagRect pRect, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pViewPtr = &pView)
                {
                    fixed (float* ColorPtr = &Color)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, float*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRectPtr, NumRects);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardView1(ID3D11View* pResourceView, Silk.NET.Core.Native.TagRect* pRects, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[133])(@this, pResourceView, pRects, NumRects);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardView1(ID3D11View* pResourceView, ref Silk.NET.Core.Native.TagRect pRects, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (Silk.NET.Core.Native.TagRect* pRectsPtr = &pRects)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[133])(@this, pResourceView, pRectsPtr, NumRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardView1(ref ID3D11View pResourceView, Silk.NET.Core.Native.TagRect* pRects, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pResourceViewPtr = &pResourceView)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRects, NumRects);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DiscardView1(ref ID3D11View pResourceView, ref Silk.NET.Core.Native.TagRect pRects, uint NumRects)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11View* pResourceViewPtr = &pResourceView)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectsPtr = &pRects)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11View*, Silk.NET.Core.Native.TagRect*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRectsPtr, NumRects);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, uint* pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                {
                                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, uint* pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                                {
                                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, uint* pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                                {
                                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                    {
                                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, ref TiledResourceCoordinate pTiledResourceRegionStartCoordinates, ref TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, ref uint pRangeFlags, ref uint pTilePoolStartOffsets, ref uint pRangeTileCounts, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                        {
                            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                            {
                                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                                {
                                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                                    {
                                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                        {
                                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                        {
                            ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, TiledResourceCoordinate* pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                        {
                            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, TileRegionSize* pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                        {
                            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                            {
                                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CopyTileMappings(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, ref TiledResourceCoordinate pSourceRegionStartCoordinate, ref TileRegionSize pTileRegionSize, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                    {
                        fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                        {
                            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                            {
                                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                                {
                                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ID3D11Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTiles(ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyTiles(ref ID3D11Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
                {
                    fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                            {
                                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileData, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileData, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileData, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                    {
                        fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileData, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, TiledResourceCoordinate* pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                    {
                        fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileData, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, TileRegionSize* pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                    {
                        fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, void* pSourceTileData, uint Flags)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                        {
                            ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileData, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, ref TiledResourceCoordinate pDestTileRegionStartCoordinate, ref TileRegionSize pDestTileRegionSize, ref T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
                {
                    fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                        {
                            fixed (T0* pSourceTileDataPtr = &pSourceTileData)
                            {
                                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, T0*, uint, void>)LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeTilePool(ID3D11Buffer* pTilePool, ulong NewSizeInBytes)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, ulong, int>)LpVtbl[138])(@this, pTilePool, NewSizeInBytes);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeTilePool(ref ID3D11Buffer pTilePool, ulong NewSizeInBytes)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Buffer*, ulong, int>)LpVtbl[138])(@this, pTilePoolPtr, NewSizeInBytes);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void TiledResourceBarrier(ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void TiledResourceBarrier(ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrierPtr = &pTiledResourceOrViewAccessAfterBarrier)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrierPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void TiledResourceBarrier(ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrierPtr = &pTiledResourceOrViewAccessBeforeBarrier)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrierPtr, pTiledResourceOrViewAccessAfterBarrier);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void TiledResourceBarrier(ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrierPtr = &pTiledResourceOrViewAccessBeforeBarrier)
                {
                    fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrierPtr = &pTiledResourceOrViewAccessAfterBarrier)
                    {
                        ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrierPtr, pTiledResourceOrViewAccessAfterBarrierPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public int IsAnnotationEnabled()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, int>)LpVtbl[140])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetMarkerInt(char* pLabel, int Data)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, char*, int, void>)LpVtbl[141])(@this, pLabel, Data);
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarkerInt(ref char pLabel, int Data)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (char* pLabelPtr = &pLabel)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, char*, int, void>)LpVtbl[141])(@this, pLabelPtr, Data);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarkerInt(string pLabel, int Data)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
            var pLabelPtr = (byte*) Marshal.StringToHGlobalAnsi(pLabel);
                ((delegate* cdecl<ID3D11DeviceContext4*, byte*, int, void>)LpVtbl[141])(@this, pLabelPtr, Data);
            Marshal.FreeHGlobal((IntPtr)pLabelPtr);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginEventInt(char* pLabel, int Data)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, char*, int, void>)LpVtbl[142])(@this, pLabel, Data);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginEventInt(ref char pLabel, int Data)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (char* pLabelPtr = &pLabel)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, char*, int, void>)LpVtbl[142])(@this, pLabelPtr, Data);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void BeginEventInt(string pLabel, int Data)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
            var pLabelPtr = (byte*) Marshal.StringToHGlobalAnsi(pLabel);
                ((delegate* cdecl<ID3D11DeviceContext4*, byte*, int, void>)LpVtbl[142])(@this, pLabelPtr, Data);
            Marshal.FreeHGlobal((IntPtr)pLabelPtr);
            }
        }

        /// <summary>To be added.</summary>
        public void EndEvent()
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, void>)LpVtbl[143])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void Flush1(ContextType ContextType, void* hEvent)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, ContextType, void*, void>)LpVtbl[144])(@this, ContextType, hEvent);
            }
        }

        /// <summary>To be added.</summary>
        public void Flush1<T0>(ContextType ContextType, ref T0 hEvent) where T0 : unmanaged
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (T0* hEventPtr = &hEvent)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, ContextType, T0*, void>)LpVtbl[144])(@this, ContextType, hEventPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void SetHardwareProtectionState(int HwProtectionEnable)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, int, void>)LpVtbl[145])(@this, HwProtectionEnable);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetHardwareProtectionState(int* pHwProtectionEnable)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                ((delegate* cdecl<ID3D11DeviceContext4*, int*, void>)LpVtbl[146])(@this, pHwProtectionEnable);
            }
        }

        /// <summary>To be added.</summary>
        public void GetHardwareProtectionState(ref int pHwProtectionEnable)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                fixed (int* pHwProtectionEnablePtr = &pHwProtectionEnable)
                {
                    ((delegate* cdecl<ID3D11DeviceContext4*, int*, void>)LpVtbl[146])(@this, pHwProtectionEnablePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Signal(ID3D11Fence* pFence, ulong Value)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)LpVtbl[147])(@this, pFence, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Signal(ref ID3D11Fence pFence, ulong Value)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Fence* pFencePtr = &pFence)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)LpVtbl[147])(@this, pFencePtr, Value);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Wait(ID3D11Fence* pFence, ulong Value)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)LpVtbl[148])(@this, pFence, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Wait(ref ID3D11Fence pFence, ulong Value)
        {
            fixed (ID3D11DeviceContext4* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Fence* pFencePtr = &pFence)
                {
                    ret = ((delegate* cdecl<ID3D11DeviceContext4*, ID3D11Fence*, ulong, int>)LpVtbl[148])(@this, pFencePtr, Value);
                }
                return ret;
            }
        }

    }
}
