// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12PipelineLibrary1.xml' path='doc/member[@name="ID3D12PipelineLibrary1"]/*'/>
[Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
[NativeTypeName("struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary")]
[NativeInheritance("ID3D12PipelineLibrary")]
public unsafe partial struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12PipelineLibrary1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, uint> )(lpVtbl[1]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, uint> )(lpVtbl[2]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int> )(lpVtbl[3]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, Guid*, uint, void*, int> )(lpVtbl[4]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, Guid*, IUnknown*, int> )(lpVtbl[5]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, ushort*, int> )(lpVtbl[6]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, Guid*, void**, int> )(lpVtbl[7]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref = "ID3D12PipelineLibrary.StorePipeline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState* pPipeline)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, ushort*, ID3D12PipelineState*, int> )(lpVtbl[8]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pPipeline);
    }

    /// <inheritdoc cref = "ID3D12PipelineLibrary.LoadGraphicsPipeline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, ushort*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int> )(lpVtbl[9]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
    }

    /// <inheritdoc cref = "ID3D12PipelineLibrary.LoadComputePipeline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, ushort*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int> )(lpVtbl[10]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
    }

    /// <inheritdoc cref = "ID3D12PipelineLibrary.GetSerializedSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSerializedSize()
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, nuint> )(lpVtbl[11]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12PipelineLibrary.Serialize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, void*, nuint, int> )(lpVtbl[12]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pData, DataSizeInBytes);
    }

    /// <include file='ID3D12PipelineLibrary1.xml' path='doc/member[@name="ID3D12PipelineLibrary1.LoadPipeline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
    {
        return ((delegate* unmanaged<ID3D12PipelineLibrary1*, ushort*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int> )(lpVtbl[13]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
    }

    public interface Interface : ID3D12PipelineLibrary.Interface
    {
        [VtblIndex(13)]
        HRESULT LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("HRESULT (LPCWSTR, ID3D12PipelineState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ID3D12PipelineState*, int> StorePipeline;
        [NativeTypeName("HRESULT (LPCWSTR, const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int> LoadGraphicsPipeline;
        [NativeTypeName("HRESULT (LPCWSTR, const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int> LoadComputePipeline;
        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetSerializedSize;
        [NativeTypeName("HRESULT (void *, SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, int> Serialize;
        [NativeTypeName("HRESULT (LPCWSTR, const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int> LoadPipeline;
    }
}