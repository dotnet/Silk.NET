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

namespace Silk.NET.Direct3D12
{
    [Guid("dd171223-8b61-4769-90e3-160ccde4e2c1")]
    [NativeName("Name", "ID3D12GraphicsCommandList7")]
    public unsafe partial struct ID3D12GraphicsCommandList7 : IComVtbl<ID3D12GraphicsCommandList7>, IComVtbl<ID3D12GraphicsCommandList6>, IComVtbl<ID3D12GraphicsCommandList5>, IComVtbl<ID3D12GraphicsCommandList4>, IComVtbl<ID3D12GraphicsCommandList3>, IComVtbl<ID3D12GraphicsCommandList2>, IComVtbl<ID3D12GraphicsCommandList1>, IComVtbl<ID3D12GraphicsCommandList>, IComVtbl<ID3D12CommandList>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dd171223-8b61-4769-90e3-160ccde4e2c1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12GraphicsCommandList6(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList6>(ref val);

        public static implicit operator ID3D12GraphicsCommandList5(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList5>(ref val);

        public static implicit operator ID3D12GraphicsCommandList4(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList4>(ref val);

        public static implicit operator ID3D12GraphicsCommandList3(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList3>(ref val);

        public static implicit operator ID3D12GraphicsCommandList2(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList2>(ref val);

        public static implicit operator ID3D12GraphicsCommandList1(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList1>(ref val);

        public static implicit operator ID3D12GraphicsCommandList(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12GraphicsCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12GraphicsCommandList7 val)
            => Unsafe.As<ID3D12GraphicsCommandList7, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12GraphicsCommandList7
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
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, CommandListType>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, int>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearState(ID3D12PipelineState* pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineState);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, uint, uint, void>)@this->LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, uint, int, uint, void>)@this->LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, uint, void>)@this->LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCopyLocation* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology PrimitiveTopology)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[20])(@this, PrimitiveTopology);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetViewports(uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewports);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetScissorRects(uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendFactor([Count(Count = 4)] float* BlendFactor)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, float*, void>)@this->LpVtbl[23])(@this, BlendFactor);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetStencilRef(uint StencilRef)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, void>)@this->LpVtbl[24])(@this, StencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPipelineState(ID3D12PipelineState* pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineState);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriers);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, uint, void>)@this->LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, uint, void>)@this->LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ulong, void>)@this->LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ulong, void>)@this->LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ulong, void>)@this->LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ulong, void>)@this->LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ulong, void>)@this->LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, ulong, void>)@this->LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetIndexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexBufferView* pView)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pView);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferView* pViews)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StreamOutputBufferView* pViews)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViews);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pRenderTargetDescriptors, Silk.NET.Core.Bool32 RTsSingleHandleToDescriptorRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, CpuDescriptorHandle*, Silk.NET.Core.Bool32, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, void>)@this->LpVtbl[58])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Resource** ppDependentResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Resource** ppDependentResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetDepthBounds(float Min, float Max)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, float, float, void>)@this->LpVtbl[62])(@this, Min, Max);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetViewInstanceMask(uint Mask)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, void>)@this->LpVtbl[65])(@this, Mask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[67])(@this, pProtectedResourceSession);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginRenderPass(uint NumRenderTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassRenderTargetDesc* pRenderTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPassDepthStencilDesc* pDepthStencil, RenderPassFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, RenderPassRenderTargetDesc*, RenderPassDepthStencilDesc*, RenderPassFlags, void>)@this->LpVtbl[68])(@this, NumRenderTargets, pRenderTargets, pDepthStencil, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndRenderPass()
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, void>)@this->LpVtbl[69])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeMetaCommand(ID3D12MetaCommand* pMetaCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParametersData, nuint InitializationParametersDataSizeInBytes)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[70])(@this, pMetaCommand, pInitializationParametersData, InitializationParametersDataSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteMetaCommand(ID3D12MetaCommand* pMetaCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParametersData, nuint ExecutionParametersDataSizeInBytes)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12MetaCommand*, void*, nuint, void>)@this->LpVtbl[71])(@this, pMetaCommand, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BuildRaytracingAccelerationStructure([Flow(Silk.NET.Core.Native.FlowDirection.In)] BuildRaytracingAccelerationStructureDesc* pDesc, uint NumPostbuildInfoDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RaytracingAccelerationStructurePostbuildInfoDesc* pPostbuildInfoDescs)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, BuildRaytracingAccelerationStructureDesc*, uint, RaytracingAccelerationStructurePostbuildInfoDesc*, void>)@this->LpVtbl[72])(@this, pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescs);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EmitRaytracingAccelerationStructurePostbuildInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] RaytracingAccelerationStructurePostbuildInfoDesc* pDesc, uint NumSourceAccelerationStructures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pSourceAccelerationStructureData)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, RaytracingAccelerationStructurePostbuildInfoDesc*, uint, ulong*, void>)@this->LpVtbl[73])(@this, pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyRaytracingAccelerationStructure(ulong DestAccelerationStructureData, ulong SourceAccelerationStructureData, RaytracingAccelerationStructureCopyMode Mode)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ulong, ulong, RaytracingAccelerationStructureCopyMode, void>)@this->LpVtbl[74])(@this, DestAccelerationStructureData, SourceAccelerationStructureData, Mode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPipelineState1(ID3D12StateObject* pStateObject)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12StateObject*, void>)@this->LpVtbl[75])(@this, pStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DispatchRays([Flow(Silk.NET.Core.Native.FlowDirection.In)] DispatchRaysDesc* pDesc)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, DispatchRaysDesc*, void>)@this->LpVtbl[76])(@this, pDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetShadingRate(ShadingRate baseShadingRate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShadingRateCombiner* combiners)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ShadingRate, ShadingRateCombiner*, void>)@this->LpVtbl[77])(@this, baseShadingRate, combiners);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetShadingRateImage(ID3D12Resource* shadingRateImage)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, ID3D12Resource*, void>)@this->LpVtbl[78])(@this, shadingRateImage);
        }

        /// <summary>To be documented.</summary>
        public readonly void DispatchMesh(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, uint, uint, void>)@this->LpVtbl[79])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Barrier(uint NumBarrierGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BarrierGroup* pBarrierGroups)
        {
            var @this = (ID3D12GraphicsCommandList7*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList7*, uint, BarrierGroup*, void>)@this->LpVtbl[80])(@this, NumBarrierGroups, pBarrierGroups);
        }

    }
}
