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
    [Guid("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1")]
    [NativeName("Name", "ID3D11DeviceContext1")]
    public unsafe partial struct ID3D11DeviceContext1 : IComVtbl<ID3D11DeviceContext1>, IComVtbl<ID3D11DeviceContext>, IComVtbl<ID3D11DeviceChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11DeviceContext(ID3D11DeviceContext1 val)
            => Unsafe.As<ID3D11DeviceContext1, ID3D11DeviceContext>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11DeviceContext1 val)
            => Unsafe.As<ID3D11DeviceContext1, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11DeviceContext1 val)
            => Unsafe.As<ID3D11DeviceContext1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11DeviceContext1
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
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, int, void>)@this->LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void Draw(uint VertexCount, uint StartVertexLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, void>)@this->LpVtbl[13])(@this, VertexCount, StartVertexLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Unmap(ID3D11Resource* pResource, uint Subresource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResource, Subresource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, int, uint, void>)@this->LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, uint, void>)@this->LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ID3D11GeometryShader* pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology Topology)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[24])(@this, Topology);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Begin(ID3D11Asynchronous* pAsync)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsync);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void End(ID3D11Asynchronous* pAsync)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsync);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D11Predicate* pPredicate, Silk.NET.Core.Bool32 PredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[30])(@this, pPredicate, PredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilState, StencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawAuto()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)@this->LpVtbl[38])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, void>)@this->LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetViewports(uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewports);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetScissorRects(uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, Values);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, Values);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResource, MinLOD);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteCommandList(ID3D11CommandList* pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11CommandList*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[58])(@this, pCommandList, RestoreContextState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ID3D11HullShader* pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopology);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ID3D11Predicate** ppPredicate, int* pPredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValue);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(uint* pNumViewports, Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewports);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(uint* pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)@this->LpVtbl[110])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void Flush()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)@this->LpVtbl[111])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly DeviceContextType GetType()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DeviceContextType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, DeviceContextType>)@this->LpVtbl[112])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetContextFlags()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)@this->LpVtbl[113])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishCommandList(Silk.NET.Core.Bool32 RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Bool32, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D11Resource* pResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, void>)@this->LpVtbl[117])(@this, pResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView(ID3D11View* pResourceView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, void>)@this->LpVtbl[118])(@this, pResourceView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pState, ppPreviousState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, Color, pRect, NumRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ID3D11View* pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceView, pRects, NumRects);
        }

    }
}
