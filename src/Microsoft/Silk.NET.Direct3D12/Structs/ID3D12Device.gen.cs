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
    [Guid("189819f1-1db6-4b57-be54-1821339b85f7")]
    [NativeName("Name", "ID3D12Device")]
    public unsafe partial struct ID3D12Device : IComVtbl<ID3D12Device>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("189819f1-1db6-4b57-be54-1821339b85f7");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12Object(ID3D12Device val)
            => Unsafe.As<ID3D12Device, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Device val)
            => Unsafe.As<ID3D12Device, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Device
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
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNodeCount()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetDescriptorHandleIncrementSize(DescriptorHeapType DescriptorHeapType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, DescriptorHeapType, uint>)@this->LpVtbl[15])(@this, DescriptorHeapType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateConstantBufferView([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyDescriptorsSimple(uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)@this->LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly HeapProperties GetCustomHeapProperties(uint nodeMask, HeapType heapType)
        {
            HeapProperties silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            HeapProperties* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, uint, HeapType, HeapProperties*>)@this->LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, void** ppvObj)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObj);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Evict(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceRemovedReason()
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, int>)@this->LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStablePowerState(Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[40])(@this, Enable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly Luid GetAdapterLuid()
        {
            Luid silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Luid* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device*, Luid*, Luid*>)@this->LpVtbl[43])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

    }
}
