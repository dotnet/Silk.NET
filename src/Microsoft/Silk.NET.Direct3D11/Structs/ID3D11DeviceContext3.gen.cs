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
    [Guid("b4e3c01d-e79e-4637-91b2-510e9f4c9b8f")]
    [NativeName("Name", "ID3D11DeviceContext3")]
    public unsafe partial struct ID3D11DeviceContext3 : IComVtbl<ID3D11DeviceContext3>, IComVtbl<ID3D11DeviceContext2>, IComVtbl<ID3D11DeviceContext1>, IComVtbl<ID3D11DeviceContext>, IComVtbl<ID3D11DeviceChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b4e3c01d-e79e-4637-91b2-510e9f4c9b8f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11DeviceContext2(ID3D11DeviceContext3 val)
            => Unsafe.As<ID3D11DeviceContext3, ID3D11DeviceContext2>(ref val);

        public static implicit operator ID3D11DeviceContext1(ID3D11DeviceContext3 val)
            => Unsafe.As<ID3D11DeviceContext3, ID3D11DeviceContext1>(ref val);

        public static implicit operator ID3D11DeviceContext(ID3D11DeviceContext3 val)
            => Unsafe.As<ID3D11DeviceContext3, ID3D11DeviceContext>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11DeviceContext3 val)
            => Unsafe.As<ID3D11DeviceContext3, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11DeviceContext3 val)
            => Unsafe.As<ID3D11DeviceContext3, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11DeviceContext3
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
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ref ID3D11PixelShader pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ref ID3D11PixelShader pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ref ID3D11VertexShader pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ref ID3D11VertexShader pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, int, void>)@this->LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void Draw(uint VertexCount, uint StartVertexLocation)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, void>)@this->LpVtbl[13])(@this, VertexCount, StartVertexLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Map(ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Unmap(ID3D11Resource* pResource, uint Subresource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResource, Subresource);
        }

        /// <summary>To be documented.</summary>
        public readonly void Unmap(ref ID3D11Resource pResource, uint Subresource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResourcePtr, Subresource);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetInputLayout(ref ID3D11InputLayout pInputLayout)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11InputLayout* pInputLayoutPtr = &pInputLayout)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayoutPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetIndexBuffer(ref ID3D11Buffer pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pIndexBufferPtr = &pIndexBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, uint, int, uint, void>)@this->LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, uint, uint, void>)@this->LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ID3D11GeometryShader* pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ID3D11GeometryShader* pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ref ID3D11GeometryShader pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ref ID3D11GeometryShader pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology Topology)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[24])(@this, Topology);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Begin(ID3D11Asynchronous* pAsync)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsync);
        }

        /// <summary>To be documented.</summary>
        public readonly void Begin(ref ID3D11Asynchronous pAsync)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsyncPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void End(ID3D11Asynchronous* pAsync)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsync);
        }

        /// <summary>To be documented.</summary>
        public readonly void End(ref ID3D11Asynchronous pAsync)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsyncPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData<T0>(ID3D11Asynchronous* pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ref ID3D11Asynchronous pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetData<T0>(ref ID3D11Asynchronous pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D11Predicate* pPredicate, Silk.NET.Core.Bool32 PredicateValue)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Predicate*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[30])(@this, pPredicate, PredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D11Predicate pPredicate, Silk.NET.Core.Bool32 PredicateValue)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Predicate* pPredicatePtr = &pPredicate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Predicate*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ref ID3D11BlendState pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetBlendState(ref ID3D11BlendState pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilState, StencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetDepthStencilState(ref ID3D11DepthStencilState pDepthStencilState, uint StencilRef)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilState* pDepthStencilStatePtr = &pDepthStencilState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawAuto()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, void>)@this->LpVtbl[38])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstancedIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstancedIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, uint, void>)@this->LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void DispatchIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerState);
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetState(ref ID3D11RasterizerState pRasterizerState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RasterizerState* pRasterizerStatePtr = &pRasterizerState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerStatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetViewports(uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewports);
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetViewports(uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Viewport pViewports)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewportsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetScissorRects(uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetScissorRects(uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D11Resource* pDstResource, ref ID3D11Resource pSrcResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ref ID3D11Resource pDstResource, ID3D11Resource* pSrcResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource(ref ID3D11Resource pDstResource, ref ID3D11Resource pSrcResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0>(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0>(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateSubresource<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (void* pSrcDataPtr = &pSrcData)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyStructureCount(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRenderTargetView(ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
            {
                fixed (float* ColorRGBAPtr = &ColorRGBA)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, Values);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewUint(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, Values);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref float Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewFloat(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref float Values)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearDepthStencilView(ref ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceView);
        }

        /// <summary>To be documented.</summary>
        public readonly void GenerateMips(ref ID3D11ShaderResourceView pShaderResourceView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView* pShaderResourceViewPtr = &pShaderResourceView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceViewPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResource, MinLOD);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetResourceMinLOD(ref ID3D11Resource pResource, float MinLOD)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResourcePtr, MinLOD);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetResourceMinLOD(ref ID3D11Resource pResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteCommandList(ID3D11CommandList* pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11CommandList*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[58])(@this, pCommandList, RestoreContextState);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteCommandList(ref ID3D11CommandList pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CommandList* pCommandListPtr = &pCommandList)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11CommandList*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ID3D11HullShader* pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ID3D11HullShader* pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ref ID3D11HullShader pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ref ID3D11HullShader pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ref ID3D11DomainShader pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ref ID3D11DomainShader pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ref ID3D11ComputeShader pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ref ID3D11ComputeShader pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetInputLayout(ref ID3D11InputLayout* ppInputLayout)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11InputLayout** ppInputLayoutPtr = &ppInputLayout)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayoutPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* OffsetPtr = &Offset)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                {
                    fixed (uint* OffsetPtr = &Offset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopology);
        }

        /// <summary>To be documented.</summary>
        public readonly void IAGetPrimitiveTopology(ref Silk.NET.Core.Native.D3DPrimitiveTopology pTopology)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Core.Native.D3DPrimitiveTopology* pTopologyPtr = &pTopology)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopologyPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ID3D11Predicate** ppPredicate, int* pPredicateValue)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ID3D11Predicate** ppPredicate, ref int pPredicateValue)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pPredicateValuePtr = &pPredicateValue)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ref ID3D11Predicate* ppPredicate, int* pPredicateValue)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ref ID3D11Predicate* ppPredicate, ref int pPredicateValue)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
            {
                fixed (int* pPredicateValuePtr = &pPredicateValue)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pSampleMaskPtr = &pSampleMask)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    fixed (uint* pSampleMaskPtr = &pSampleMask)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, ref uint pStencilRef)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStencilRefPtr = &pStencilRef)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ref ID3D11DepthStencilState* ppDepthStencilState, uint* pStencilRef)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ref ID3D11DepthStencilState* ppDepthStencilState, ref uint pStencilRef)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
            {
                fixed (uint* pStencilRefPtr = &pStencilRef)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOGetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetState(ref ID3D11RasterizerState* ppRasterizerState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RasterizerState** ppRasterizerStatePtr = &ppRasterizerState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerStatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(uint* pNumViewports, Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewports);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(uint* pNumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(ref uint pNumViewports, Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumViewportsPtr = &pNumViewports)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void RSGetViewports(ref uint pNumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumViewportsPtr = &pNumViewports)
            {
                fixed (Viewport* pViewportsPtr = &pViewports)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(uint* pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(uint* pNumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(ref uint pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRectsPtr = &pNumRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRectsPtr, pRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void RSGetScissorRects(ref uint pNumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRectsPtr = &pNumRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, void>)@this->LpVtbl[110])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void Flush()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, void>)@this->LpVtbl[111])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly DeviceContextType GetType()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DeviceContextType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, DeviceContextType>)@this->LpVtbl[112])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetContextFlags()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint>)@this->LpVtbl[113])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishCommandList(Silk.NET.Core.Bool32 RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Bool32, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishCommandList(Silk.NET.Core.Bool32 RestoreDeferredContextState, ref ID3D11CommandList* ppCommandList)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CommandList** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Bool32, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0>(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0>(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateSubresource1<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (void* pSrcDataPtr = &pSrcData)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D11Resource* pResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, void>)@this->LpVtbl[117])(@this, pResource);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D11Resource pResource)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, void>)@this->LpVtbl[117])(@this, pResourcePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView(ID3D11View* pResourceView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, void>)@this->LpVtbl[118])(@this, pResourceView);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardView(ref ID3D11View pResourceView)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pResourceViewPtr = &pResourceView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, void>)@this->LpVtbl[118])(@this, pResourceViewPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Buffer* ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pState, ppPreviousState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ref ID3DDeviceContextState* ppPreviousState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pState, ppPreviousStatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ref ID3DDeviceContextState pState, ID3DDeviceContextState** ppPreviousState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3DDeviceContextState* pStatePtr = &pState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pStatePtr, ppPreviousState);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ref ID3DDeviceContextState pState, ref ID3DDeviceContextState* ppPreviousState)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3DDeviceContextState* pStatePtr = &pState)
            {
                fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pStatePtr, ppPreviousStatePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, Color, pRect, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, Color, pRectPtr, NumRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] ref float Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorPtr = &Color)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, ColorPtr, pRect, NumRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] ref float Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorPtr = &Color)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, ColorPtr, pRectPtr, NumRects);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, Color, pRect, NumRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, Color, pRectPtr, NumRects);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] ref float Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                fixed (float* ColorPtr = &Color)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, ColorPtr, pRect, NumRects);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearView(ref ID3D11View pView, [Count(Count = 4)] ref float Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                fixed (float* ColorPtr = &Color)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pViewPtr, ColorPtr, pRectPtr, NumRects);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ID3D11View* pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceView, pRects, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ID3D11View* pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceView, pRectsPtr, NumRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ref ID3D11View pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pResourceViewPtr = &pResourceView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceViewPtr, pRects, NumRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardView1(ref ID3D11View pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pResourceViewPtr = &pResourceView)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11View*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceViewPtr, pRectsPtr, NumRects);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ID3D11Resource* pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizes, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pTilePoolStartOffsetsPtr = &pTilePoolStartOffsets)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (uint* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ID3D11Buffer* pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePool, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTiledResourceRegionStartCoordinatesPtr = &pTiledResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pTiledResourceRegionSizesPtr = &pTiledResourceRegionSizes)
                    {
                        fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlags, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTileMappings(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, uint, uint*, uint*, uint*, uint, int>)@this->LpVtbl[134])(@this, pTiledResourcePtr, NumTiledResourceRegions, pTiledResourceRegionStartCoordinatesPtr, pTiledResourceRegionSizesPtr, pTilePoolPtr, NumRanges, pRangeFlagsPtr, pTilePoolStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResource, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinate, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ID3D11Resource* pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResource, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinate, pTileRegionSizePtr, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestRegionStartCoordinatePtr = &pDestRegionStartCoordinate)
                {
                    fixed (ID3D11Resource* pSourceTiledResourcePtr = &pSourceTiledResource)
                    {
                        fixed (TiledResourceCoordinate* pSourceRegionStartCoordinatePtr = &pSourceRegionStartCoordinate)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSize, Flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyTileMappings(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, uint, int>)@this->LpVtbl[135])(@this, pDestTiledResourcePtr, pDestRegionStartCoordinatePtr, pSourceTiledResourcePtr, pSourceRegionStartCoordinatePtr, pTileRegionSizePtr, Flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D11Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ID3D11Buffer* pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D11Buffer* pBufferPtr = &pBuffer)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D11Buffer*, ulong, uint, void>)@this->LpVtbl[136])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSourceTileDataPtr = &pSourceTileData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileDataPtr, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileData, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
            {
                fixed (void* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileData, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                fixed (void* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileData, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ID3D11Resource* pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    fixed (void* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResource, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (void* pSourceTileDataPtr = &pSourceTileData)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileData, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                {
                    fixed (void* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinate, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileData, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    fixed (void* pSourceTileDataPtr = &pSourceTileData)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSize, pSourceTileDataPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileData, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateTiles<T0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDestTiledResourcePtr = &pDestTiledResource)
            {
                fixed (TiledResourceCoordinate* pDestTileRegionStartCoordinatePtr = &pDestTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pDestTileRegionSizePtr = &pDestTileRegionSize)
                    {
                        fixed (void* pSourceTileDataPtr = &pSourceTileData)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Resource*, TiledResourceCoordinate*, TileRegionSize*, void*, uint, void>)@this->LpVtbl[137])(@this, pDestTiledResourcePtr, pDestTileRegionStartCoordinatePtr, pDestTileRegionSizePtr, pSourceTileDataPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ResizeTilePool(ID3D11Buffer* pTilePool, ulong NewSizeInBytes)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, ulong, int>)@this->LpVtbl[138])(@this, pTilePool, NewSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeTilePool(ref ID3D11Buffer pTilePool, ulong NewSizeInBytes)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Buffer* pTilePoolPtr = &pTilePool)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11Buffer*, ulong, int>)@this->LpVtbl[138])(@this, pTilePoolPtr, NewSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void TiledResourceBarrier(ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void TiledResourceBarrier(ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrierPtr = &pTiledResourceOrViewAccessAfterBarrier)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrierPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void TiledResourceBarrier(ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrier)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrierPtr = &pTiledResourceOrViewAccessBeforeBarrier)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrierPtr, pTiledResourceOrViewAccessAfterBarrier);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void TiledResourceBarrier(ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessBeforeBarrierPtr = &pTiledResourceOrViewAccessBeforeBarrier)
            {
                fixed (ID3D11DeviceChild* pTiledResourceOrViewAccessAfterBarrierPtr = &pTiledResourceOrViewAccessAfterBarrier)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ID3D11DeviceChild*, ID3D11DeviceChild*, void>)@this->LpVtbl[139])(@this, pTiledResourceOrViewAccessBeforeBarrierPtr, pTiledResourceOrViewAccessAfterBarrierPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsAnnotationEnabled()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Bool32>)@this->LpVtbl[140])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarkerInt([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pLabel, int Data)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, char*, int, void>)@this->LpVtbl[141])(@this, pLabel, Data);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarkerInt([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pLabel, int Data)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* pLabelPtr = &pLabel)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, char*, int, void>)@this->LpVtbl[141])(@this, pLabelPtr, Data);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarkerInt([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLabel, int Data)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pLabelPtr = (byte*) SilkMarshal.StringToPtr(pLabel, NativeStringEncoding.LPWStr);
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, byte*, int, void>)@this->LpVtbl[141])(@this, pLabelPtr, Data);
            SilkMarshal.Free((nint)pLabelPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEventInt([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pLabel, int Data)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, char*, int, void>)@this->LpVtbl[142])(@this, pLabel, Data);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEventInt([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pLabel, int Data)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* pLabelPtr = &pLabel)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, char*, int, void>)@this->LpVtbl[142])(@this, pLabelPtr, Data);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEventInt([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pLabel, int Data)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pLabelPtr = (byte*) SilkMarshal.StringToPtr(pLabel, NativeStringEncoding.LPWStr);
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, byte*, int, void>)@this->LpVtbl[142])(@this, pLabelPtr, Data);
            SilkMarshal.Free((nint)pLabelPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, void>)@this->LpVtbl[143])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Flush1(ContextType ContextType, void* hEvent)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ContextType, void*, void>)@this->LpVtbl[144])(@this, ContextType, hEvent);
        }

        /// <summary>To be documented.</summary>
        public readonly void Flush1<T0>(ContextType ContextType, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* hEventPtr = &hEvent)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, ContextType, void*, void>)@this->LpVtbl[144])(@this, ContextType, hEventPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetHardwareProtectionState(Silk.NET.Core.Bool32 HwProtectionEnable)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[145])(@this, HwProtectionEnable);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetHardwareProtectionState(int* pHwProtectionEnable)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, int*, void>)@this->LpVtbl[146])(@this, pHwProtectionEnable);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetHardwareProtectionState(ref int pHwProtectionEnable)
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pHwProtectionEnablePtr = &pHwProtectionEnable)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext3*, int*, void>)@this->LpVtbl[146])(@this, pHwProtectionEnablePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetDevice((ID3D11Device**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSSetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void PSSetShaderResources<TI0>(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void PSSetShader<TI0, TI1>(ComPtr<TI0> pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetShader((ID3D11PixelShader*) pPixelShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader<TI0>(ComPtr<TI0> pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetShader((ID3D11PixelShader*) pPixelShader.Handle, in ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSSetShader<TI0>(ref ID3D11PixelShader pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetShader(ref pPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSSetSamplers<TI0>(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void VSSetShader<TI0, TI1>(ComPtr<TI0> pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetShader((ID3D11VertexShader*) pVertexShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader<TI0>(ComPtr<TI0> pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetShader((ID3D11VertexShader*) pVertexShader.Handle, in ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSSetShader<TI0>(ref ID3D11VertexShader pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetShader(ref pVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map<TI0>(ComPtr<TI0> pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Map((ID3D11Resource*) pResource.Handle, Subresource, MapType, MapFlags, pMappedResource);
        }

        /// <summary>To be documented.</summary>
        public readonly int Map<TI0>(ComPtr<TI0> pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Map((ID3D11Resource*) pResource.Handle, Subresource, MapType, MapFlags, ref pMappedResource);
        }

        /// <summary>To be documented.</summary>
        public readonly void Unmap<TI0>(ComPtr<TI0> pResource, uint Subresource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->Unmap((ID3D11Resource*) pResource.Handle, Subresource);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSSetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetInputLayout<TI0>(ComPtr<TI0> pInputLayout) where TI0 : unmanaged, IComVtbl<ID3D11InputLayout>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IASetInputLayout((ID3D11InputLayout*) pInputLayout.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, in pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), in pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IASetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), in pStrides, in pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetIndexBuffer<TI0>(ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IASetIndexBuffer((ID3D11Buffer*) pIndexBuffer.Handle, Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSSetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GSSetShader<TI0, TI1>(ComPtr<TI0> pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetShader((ID3D11GeometryShader*) pShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader<TI0>(ComPtr<TI0> pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetShader((ID3D11GeometryShader*) pShader.Handle, in ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSSetShader<TI0>(ref ID3D11GeometryShader pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetShader(ref pShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSSetShaderResources<TI0>(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void VSSetSamplers<TI0>(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void Begin<TI0>(ComPtr<TI0> pAsync) where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->Begin((ID3D11Asynchronous*) pAsync.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void End<TI0>(ComPtr<TI0> pAsync) where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->End((ID3D11Asynchronous*) pAsync.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData<TI0>(ComPtr<TI0> pAsync, void* pData, uint DataSize, uint GetDataFlags) where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetData((ID3D11Asynchronous*) pAsync.Handle, pData, DataSize, GetDataFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetData<T0, TI0>(ComPtr<TI0> pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Asynchronous>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetData((ID3D11Asynchronous*) pAsync.Handle, ref pData, DataSize, GetDataFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication<TI0>(ComPtr<TI0> pPredicate, Silk.NET.Core.Bool32 PredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetPredication((ID3D11Predicate*) pPredicate.Handle, PredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSSetShaderResources<TI0>(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GSSetSamplers<TI0>(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetRenderTargets<TI0, TI1>(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetRenderTargets<TI0>(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets<TI0>(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargets(NumViews, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI2> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI2> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ComPtr<TI1> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref pDepthStencilView, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ComPtr<TI0> pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11UnorderedAccessView* ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, (ID3D11DepthStencilView*) pDepthStencilView.Handle, UAVStartSlot, NumUAVs, in ppUnorderedAccessViews, in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetRenderTargetsAndUnorderedAccessViews(NumRTVs, in ppRenderTargetViews, ref pDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState<TI0>(ComPtr<TI0> pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetBlendState((ID3D11BlendState*) pBlendState.Handle, BlendFactor, SampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetBlendState<TI0>(ComPtr<TI0> pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetBlendState((ID3D11BlendState*) pBlendState.Handle, ref BlendFactor, SampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetDepthStencilState<TI0>(ComPtr<TI0> pDepthStencilState, uint StencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMSetDepthStencilState((ID3D11DepthStencilState*) pDepthStencilState.Handle, StencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets<TI0>(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SOSetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf(), pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly void SOSetTargets<TI0>(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SOSetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf(), in pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstancedIndirect<TI0>(ComPtr<TI0> pBufferForArgs, uint AlignedByteOffsetForArgs) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DrawIndexedInstancedIndirect((ID3D11Buffer*) pBufferForArgs.Handle, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstancedIndirect<TI0>(ComPtr<TI0> pBufferForArgs, uint AlignedByteOffsetForArgs) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DrawInstancedIndirect((ID3D11Buffer*) pBufferForArgs.Handle, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void DispatchIndirect<TI0>(ComPtr<TI0> pBufferForArgs, uint AlignedByteOffsetForArgs) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DispatchIndirect((ID3D11Buffer*) pBufferForArgs.Handle, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetState<TI0>(ComPtr<TI0> pRasterizerState) where TI0 : unmanaged, IComVtbl<ID3D11RasterizerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->RSSetState((ID3D11RasterizerState*) pRasterizerState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI1> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI1> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, in pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, ref pSrcResource, SrcSubresource, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, ref pSrcResource, SrcSubresource, in pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion<TI0>(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI0> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion<TI0>(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI0> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, in pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource<TI0, TI1>(ComPtr<TI0> pDstResource, ComPtr<TI1> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyResource((ID3D11Resource*) pDstResource.Handle, (ID3D11Resource*) pSrcResource.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource<TI0>(ComPtr<TI0> pDstResource, ref ID3D11Resource pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyResource((ID3D11Resource*) pDstResource.Handle, ref pSrcResource);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource<TI0>(ref ID3D11Resource pDstResource, ComPtr<TI0> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyResource(ref pDstResource, (ID3D11Resource*) pSrcResource.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0, TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, pDstBox, in pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, in pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateSubresource<T0, TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, in pDstBox, in pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyStructureCount<TI0, TI1>(ComPtr<TI0> pDstBuffer, uint DstAlignedByteOffset, ComPtr<TI1> pSrcView) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyStructureCount((ID3D11Buffer*) pDstBuffer.Handle, DstAlignedByteOffset, (ID3D11UnorderedAccessView*) pSrcView.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyStructureCount<TI0>(ComPtr<TI0> pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyStructureCount((ID3D11Buffer*) pDstBuffer.Handle, DstAlignedByteOffset, ref pSrcView);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyStructureCount<TI0>(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ComPtr<TI0> pSrcView) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyStructureCount(ref pDstBuffer, DstAlignedByteOffset, (ID3D11UnorderedAccessView*) pSrcView.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView<TI0>(ComPtr<TI0> pRenderTargetView, [Count(Count = 4)] float* ColorRGBA) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearRenderTargetView((ID3D11RenderTargetView*) pRenderTargetView.Handle, ColorRGBA);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRenderTargetView<TI0>(ComPtr<TI0> pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearRenderTargetView((ID3D11RenderTargetView*) pRenderTargetView.Handle, ref ColorRGBA);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint<TI0>(ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] uint* Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewUint((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, Values);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewUint<TI0>(ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] ref uint Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewUint((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, ref Values);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat<TI0>(ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] float* Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewFloat((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, Values);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewFloat<TI0>(ComPtr<TI0> pUnorderedAccessView, [Count(Count = 4)] ref float Values) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewFloat((ID3D11UnorderedAccessView*) pUnorderedAccessView.Handle, ref Values);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearDepthStencilView<TI0>(ComPtr<TI0> pDepthStencilView, uint ClearFlags, float Depth, byte Stencil) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearDepthStencilView((ID3D11DepthStencilView*) pDepthStencilView.Handle, ClearFlags, Depth, Stencil);
        }

        /// <summary>To be documented.</summary>
        public readonly void GenerateMips<TI0>(ComPtr<TI0> pShaderResourceView) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GenerateMips((ID3D11ShaderResourceView*) pShaderResourceView.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetResourceMinLOD<TI0>(ComPtr<TI0> pResource, float MinLOD) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetResourceMinLOD((ID3D11Resource*) pResource.Handle, MinLOD);
        }

        /// <summary>To be documented.</summary>
        public readonly float GetResourceMinLOD<TI0>(ComPtr<TI0> pResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetResourceMinLOD((ID3D11Resource*) pResource.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, ComPtr<TI1> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresource((ID3D11Resource*) pDstResource.Handle, DstSubresource, ref pSrcResource, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource<TI0>(ref ID3D11Resource pDstResource, uint DstSubresource, ComPtr<TI0> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresource(ref pDstResource, DstSubresource, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteCommandList<TI0>(ComPtr<TI0> pCommandList, Silk.NET.Core.Bool32 RestoreContextState) where TI0 : unmanaged, IComVtbl<ID3D11CommandList>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteCommandList((ID3D11CommandList*) pCommandList.Handle, RestoreContextState);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSSetShaderResources<TI0>(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void HSSetShader<TI0, TI1>(ComPtr<TI0> pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetShader((ID3D11HullShader*) pHullShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader<TI0>(ComPtr<TI0> pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetShader((ID3D11HullShader*) pHullShader.Handle, in ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSSetShader<TI0>(ref ID3D11HullShader pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetShader(ref pHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSSetSamplers<TI0>(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void HSSetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void DSSetShaderResources<TI0>(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void DSSetShader<TI0, TI1>(ComPtr<TI0> pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetShader((ID3D11DomainShader*) pDomainShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader<TI0>(ComPtr<TI0> pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetShader((ID3D11DomainShader*) pDomainShader.Handle, in ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void DSSetShader<TI0>(ref ID3D11DomainShader pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetShader(ref pDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void DSSetSamplers<TI0>(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void DSSetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetShaderResources<TI0>(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews<TI0>(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetUnorderedAccessViews<TI0>(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pUAVInitialCounts) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf(), in pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetShader<TI0, TI1>(ComPtr<TI0> pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI1> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetShader((ID3D11ComputeShader*) pComputeShader.Handle, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader<TI0>(ComPtr<TI0> pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11ClassInstance* ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetShader((ID3D11ComputeShader*) pComputeShader.Handle, in ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetShader<TI0>(ref ID3D11ComputeShader pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppClassInstances, uint NumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetShader(ref pComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetSamplers<TI0>(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void VSGetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void PSGetShaderResources<TI0>(uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader<TI0, TI1>(ref ComPtr<TI0> ppPixelShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSGetShader<TI0, TI1>(ref ComPtr<TI0> ppPixelShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader<TI0>(ref ComPtr<TI0> ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader<TI0>(ref ComPtr<TI0> ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11PixelShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShader((ID3D11PixelShader**) ppPixelShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader<TI0>(ref ID3D11PixelShader* ppPixelShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShader(ref ppPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader<TI0>(ref ID3D11PixelShader* ppPixelShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetShader(ref ppPixelShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSGetSamplers<TI0>(uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader<TI0, TI1>(ref ComPtr<TI0> ppVertexShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSGetShader<TI0, TI1>(ref ComPtr<TI0> ppVertexShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader<TI0>(ref ComPtr<TI0> ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader<TI0>(ref ComPtr<TI0> ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11VertexShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShader((ID3D11VertexShader**) ppVertexShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader<TI0>(ref ID3D11VertexShader* ppVertexShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShader(ref ppVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader<TI0>(ref ID3D11VertexShader* ppVertexShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShader(ref ppVertexShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSGetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void IAGetInputLayout<TI0>(ref ComPtr<TI0> ppInputLayout) where TI0 : unmanaged, IComVtbl<ID3D11InputLayout>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetInputLayout((ID3D11InputLayout**) ppInputLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, uint* pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), pStrides, ref pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, uint* pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly void IAGetVertexBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppVertexBuffers, ref uint pStrides, ref uint pOffsets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetVertexBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppVertexBuffers.GetAddressOf(), ref pStrides, ref pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer<TI0>(ref ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer<TI0>(ref ComPtr<TI0> pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), Format, ref Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer<TI0>(ref ComPtr<TI0> pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), ref Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly void IAGetIndexBuffer<TI0>(ref ComPtr<TI0> pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->IAGetIndexBuffer((ID3D11Buffer**) pIndexBuffer.GetAddressOf(), ref Format, ref Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSGetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader<TI0, TI1>(ref ComPtr<TI0> ppGeometryShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSGetShader<TI0, TI1>(ref ComPtr<TI0> ppGeometryShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader<TI0>(ref ComPtr<TI0> ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader<TI0>(ref ComPtr<TI0> ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11GeometryShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShader((ID3D11GeometryShader**) ppGeometryShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader<TI0>(ref ID3D11GeometryShader* ppGeometryShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShader(ref ppGeometryShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader<TI0>(ref ID3D11GeometryShader* ppGeometryShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShader(ref ppGeometryShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSGetShaderResources<TI0>(uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void VSGetSamplers<TI0>(uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication<TI0>(ref ComPtr<TI0> ppPredicate, int* pPredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetPredication((ID3D11Predicate**) ppPredicate.GetAddressOf(), pPredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetPredication<TI0>(ref ComPtr<TI0> ppPredicate, ref int pPredicateValue) where TI0 : unmanaged, IComVtbl<ID3D11Predicate>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetPredication((ID3D11Predicate**) ppPredicate.GetAddressOf(), ref pPredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSGetShaderResources<TI0>(uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GSGetSamplers<TI0>(uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void OMGetRenderTargets<TI0, TI1>(uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets<TI0>(uint NumViews, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargets(NumViews, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets<TI0>(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargets(NumViews, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1, TI2>(uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI2> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI2>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ComPtr<TI1> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, ref ComPtr<TI0> ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11RenderTargetView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, (ID3D11RenderTargetView**) ppRenderTargetViews.GetAddressOf(), ref ppDepthStencilView, UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0, TI1>(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI1> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ComPtr<TI0> ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, (ID3D11DepthStencilView**) ppDepthStencilView.GetAddressOf(), UAVStartSlot, NumUAVs, ref ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews<TI0>(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetRenderTargetsAndUnorderedAccessViews(NumRTVs, ref ppRenderTargetViews, ref ppDepthStencilView, UAVStartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState<TI0>(ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), BlendFactor, pSampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState<TI0>(ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), BlendFactor, ref pSampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState<TI0>(ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), ref BlendFactor, pSampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMGetBlendState<TI0>(ref ComPtr<TI0> ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask) where TI0 : unmanaged, IComVtbl<ID3D11BlendState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetBlendState((ID3D11BlendState**) ppBlendState.GetAddressOf(), ref BlendFactor, ref pSampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState<TI0>(ref ComPtr<TI0> ppDepthStencilState, uint* pStencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetDepthStencilState((ID3D11DepthStencilState**) ppDepthStencilState.GetAddressOf(), pStencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMGetDepthStencilState<TI0>(ref ComPtr<TI0> ppDepthStencilState, ref uint pStencilRef) where TI0 : unmanaged, IComVtbl<ID3D11DepthStencilState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->OMGetDepthStencilState((ID3D11DepthStencilState**) ppDepthStencilState.GetAddressOf(), ref pStencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly void SOGetTargets<TI0>(uint NumBuffers, ref ComPtr<TI0> ppSOTargets) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SOGetTargets(NumBuffers, (ID3D11Buffer**) ppSOTargets.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void RSGetState<TI0>(ref ComPtr<TI0> ppRasterizerState) where TI0 : unmanaged, IComVtbl<ID3D11RasterizerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->RSGetState((ID3D11RasterizerState**) ppRasterizerState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void HSGetShaderResources<TI0>(uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader<TI0, TI1>(ref ComPtr<TI0> ppHullShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSGetShader<TI0, TI1>(ref ComPtr<TI0> ppHullShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader<TI0>(ref ComPtr<TI0> ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader<TI0>(ref ComPtr<TI0> ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11HullShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShader((ID3D11HullShader**) ppHullShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader<TI0>(ref ID3D11HullShader* ppHullShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShader(ref ppHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader<TI0>(ref ID3D11HullShader* ppHullShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetShader(ref ppHullShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSGetSamplers<TI0>(uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void HSGetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void DSGetShaderResources<TI0>(uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader<TI0, TI1>(ref ComPtr<TI0> ppDomainShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void DSGetShader<TI0, TI1>(ref ComPtr<TI0> ppDomainShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader<TI0>(ref ComPtr<TI0> ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader<TI0>(ref ComPtr<TI0> ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11DomainShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShader((ID3D11DomainShader**) ppDomainShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader<TI0>(ref ID3D11DomainShader* ppDomainShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShader(ref ppDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader<TI0>(ref ID3D11DomainShader* ppDomainShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetShader(ref ppDomainShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void DSGetSamplers<TI0>(uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void DSGetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void CSGetShaderResources<TI0>(uint StartSlot, uint NumViews, ref ComPtr<TI0> ppShaderResourceViews) where TI0 : unmanaged, IComVtbl<ID3D11ShaderResourceView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShaderResources(StartSlot, NumViews, (ID3D11ShaderResourceView**) ppShaderResourceViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void CSGetUnorderedAccessViews<TI0>(uint StartSlot, uint NumUAVs, ref ComPtr<TI0> ppUnorderedAccessViews) where TI0 : unmanaged, IComVtbl<ID3D11UnorderedAccessView>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetUnorderedAccessViews(StartSlot, NumUAVs, (ID3D11UnorderedAccessView**) ppUnorderedAccessViews.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader<TI0, TI1>(ref ComPtr<TI0> ppComputeShader, ref ComPtr<TI1> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSGetShader<TI0, TI1>(ref ComPtr<TI0> ppComputeShader, ref ComPtr<TI1> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader<TI0>(ref ComPtr<TI0> ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), ref ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader<TI0>(ref ComPtr<TI0> ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ComputeShader>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShader((ID3D11ComputeShader**) ppComputeShader.GetAddressOf(), ref ppClassInstances, ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader<TI0>(ref ID3D11ComputeShader* ppComputeShader, ref ComPtr<TI0> ppClassInstances, uint* pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShader(ref ppComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader<TI0>(ref ID3D11ComputeShader* ppComputeShader, ref ComPtr<TI0> ppClassInstances, ref uint pNumClassInstances) where TI0 : unmanaged, IComVtbl<ID3D11ClassInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetShader(ref ppComputeShader, (ID3D11ClassInstance**) ppClassInstances.GetAddressOf(), ref pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSGetSamplers<TI0>(uint StartSlot, uint NumSamplers, ref ComPtr<TI0> ppSamplers) where TI0 : unmanaged, IComVtbl<ID3D11SamplerState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetSamplers(StartSlot, NumSamplers, (ID3D11SamplerState**) ppSamplers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void CSGetConstantBuffers<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetConstantBuffers(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishCommandList<TI0>(Silk.NET.Core.Bool32 RestoreDeferredContextState, ref ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D11CommandList>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->FinishCommandList(RestoreDeferredContextState, (ID3D11CommandList**) ppCommandList.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI1> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion1((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion1<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI1> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion1((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, in pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion1((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, ref pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion1<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion1((ID3D11Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, DstZ, ref pSrcResource, SrcSubresource, in pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1<TI0>(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI0> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion1(ref pDstResource, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion1<TI0>(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ComPtr<TI0> pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pSrcBox, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopySubresourceRegion1(ref pDstResource, DstSubresource, DstX, DstY, DstZ, (ID3D11Resource*) pSrcResource.Handle, SrcSubresource, in pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource1((ID3D11Resource*) pDstResource.Handle, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0, TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource1((ID3D11Resource*) pDstResource.Handle, DstSubresource, pDstBox, in pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource1((ID3D11Resource*) pDstResource.Handle, DstSubresource, in pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateSubresource1<T0, TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Box pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateSubresource1((ID3D11Resource*) pDstResource.Handle, DstSubresource, in pDstBox, in pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource<TI0>(ComPtr<TI0> pResource) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardResource((ID3D11Resource*) pResource.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardView<TI0>(ComPtr<TI0> pResourceView) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardView((ID3D11View*) pResourceView.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void DSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSSetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSSetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), in pFirstConstant, in pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void VSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->VSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void HSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->HSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void DSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void GSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void PSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->PSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void CSGetConstantBuffers1<TI0>(uint StartSlot, uint NumBuffers, ref ComPtr<TI0> ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CSGetConstantBuffers1(StartSlot, NumBuffers, (ID3D11Buffer**) ppConstantBuffers.GetAddressOf(), ref pFirstConstant, ref pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly void SwapDeviceContextState<TI0, TI1>(ComPtr<TI0> pState, ref ComPtr<TI1> ppPreviousState) where TI0 : unmanaged, IComVtbl<ID3DDeviceContextState>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3DDeviceContextState>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SwapDeviceContextState((ID3DDeviceContextState*) pState.Handle, (ID3DDeviceContextState**) ppPreviousState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState<TI0>(ComPtr<TI0> pState, ref ID3DDeviceContextState* ppPreviousState) where TI0 : unmanaged, IComVtbl<ID3DDeviceContextState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SwapDeviceContextState((ID3DDeviceContextState*) pState.Handle, ref ppPreviousState);
        }

        /// <summary>To be documented.</summary>
        public readonly void SwapDeviceContextState<TI0>(ref ID3DDeviceContextState pState, ref ComPtr<TI0> ppPreviousState) where TI0 : unmanaged, IComVtbl<ID3DDeviceContextState>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SwapDeviceContextState(ref pState, (ID3DDeviceContextState**) ppPreviousState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView<TI0>(ComPtr<TI0> pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearView((ID3D11View*) pView.Handle, Color, pRect, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView<TI0>(ComPtr<TI0> pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint NumRects) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearView((ID3D11View*) pView.Handle, Color, in pRect, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView<TI0>(ComPtr<TI0> pView, [Count(Count = 4)] ref float Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearView((ID3D11View*) pView.Handle, ref Color, pRect, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearView<TI0>(ComPtr<TI0> pView, [Count(Count = 4)] ref float Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint NumRects) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearView((ID3D11View*) pView.Handle, ref Color, in pRect, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1<TI0>(ComPtr<TI0> pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects, uint NumRects) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardView1((ID3D11View*) pResourceView.Handle, pRects, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardView1<TI0>(ComPtr<TI0> pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRects, uint NumRects) where TI0 : unmanaged, IComVtbl<ID3D11View>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardView1((ID3D11View*) pResourceView.Handle, in pRects, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTileMappings<TI0, TI1>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI1> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTileMappings<TI0>(ComPtr<TI0> pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ref ID3D11Buffer pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings((ID3D11Resource*) pTiledResource.Handle, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, ref pTilePool, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateTileMappings<TI0>(ref ID3D11Resource pTiledResource, uint NumTiledResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTiledResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTiledResourceRegionSizes, ComPtr<TI0> pTilePool, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pTilePoolStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateTileMappings(ref pTiledResource, NumTiledResourceRegions, in pTiledResourceRegionStartCoordinates, in pTiledResourceRegionSizes, (ID3D11Buffer*) pTilePool.Handle, NumRanges, in pRangeFlags, in pTilePoolStartOffsets, in pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, ref pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, ref pSourceTiledResource, pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, ref pSourceTiledResource, in pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, pDestRegionStartCoordinate, ref pSourceTiledResource, in pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyTileMappings<TI0, TI1>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI1> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, ref pSourceTiledResource, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, ref pSourceTiledResource, pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, ref pSourceTiledResource, in pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyTileMappings<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ref ID3D11Resource pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings((ID3D11Resource*) pDestTiledResource.Handle, in pDestRegionStartCoordinate, ref pSourceTiledResource, in pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyTileMappings<TI0>(ref ID3D11Resource pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestRegionStartCoordinate, ComPtr<TI0> pSourceTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSourceRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyTileMappings(ref pDestTiledResource, in pDestRegionStartCoordinate, (ID3D11Resource*) pSourceTiledResource.Handle, in pSourceRegionStartCoordinate, in pTileRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, in pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, in pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, in pTileRegionStartCoordinate, pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, in pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, in pTileRegionStartCoordinate, in pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ref ID3D11Buffer pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D11Resource*) pTiledResource.Handle, in pTileRegionStartCoordinate, in pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, pTileRegionStartCoordinate, in pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, in pTileRegionStartCoordinate, pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles<TI0>(ref ID3D11Resource pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, in pTileRegionStartCoordinate, in pTileRegionSize, (ID3D11Buffer*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0, TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, pDestTileRegionStartCoordinate, pDestTileRegionSize, in pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, pDestTileRegionStartCoordinate, in pDestTileRegionSize, pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0, TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, pDestTileRegionStartCoordinate, in pDestTileRegionSize, in pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, in pDestTileRegionStartCoordinate, pDestTileRegionSize, pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<T0, TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, in pDestTileRegionStartCoordinate, pDestTileRegionSize, in pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTiles<TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSourceTileData, uint Flags) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, in pDestTileRegionStartCoordinate, in pDestTileRegionSize, pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateTiles<T0, TI0>(ComPtr<TI0> pDestTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDestTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pDestTileRegionSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSourceTileData, uint Flags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->UpdateTiles((ID3D11Resource*) pDestTiledResource.Handle, in pDestTileRegionStartCoordinate, in pDestTileRegionSize, in pSourceTileData, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeTilePool<TI0>(ComPtr<TI0> pTilePool, ulong NewSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D11Buffer>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ResizeTilePool((ID3D11Buffer*) pTilePool.Handle, NewSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly void TiledResourceBarrier<TI0, TI1>(ComPtr<TI0> pTiledResourceOrViewAccessBeforeBarrier, ComPtr<TI1> pTiledResourceOrViewAccessAfterBarrier) where TI0 : unmanaged, IComVtbl<ID3D11DeviceChild>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceChild>, IComVtbl<TI1>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->TiledResourceBarrier((ID3D11DeviceChild*) pTiledResourceOrViewAccessBeforeBarrier.Handle, (ID3D11DeviceChild*) pTiledResourceOrViewAccessAfterBarrier.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void TiledResourceBarrier<TI0>(ComPtr<TI0> pTiledResourceOrViewAccessBeforeBarrier, ref ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier) where TI0 : unmanaged, IComVtbl<ID3D11DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->TiledResourceBarrier((ID3D11DeviceChild*) pTiledResourceOrViewAccessBeforeBarrier.Handle, ref pTiledResourceOrViewAccessAfterBarrier);
        }

        /// <summary>To be documented.</summary>
        public readonly void TiledResourceBarrier<TI0>(ref ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, ComPtr<TI0> pTiledResourceOrViewAccessAfterBarrier) where TI0 : unmanaged, IComVtbl<ID3D11DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->TiledResourceBarrier(ref pTiledResourceOrViewAccessBeforeBarrier, (ID3D11DeviceChild*) pTiledResourceOrViewAccessAfterBarrier.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11DeviceContext3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
