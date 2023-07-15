// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration"]/*'/>
[Guid("78DBF87B-F766-422B-A61C-C8C446BDB9AD")]
[NativeTypeName("struct ID3D12DeviceConfiguration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceConfiguration : ID3D12DeviceConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceConfiguration));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration*, uint> )(lpVtbl[1]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration*, uint> )(lpVtbl[2]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public D3D12_DEVICE_CONFIGURATION_DESC GetDesc()
    {
        D3D12_DEVICE_CONFIGURATION_DESC result;
        return *((delegate* unmanaged<ID3D12DeviceConfiguration*, D3D12_DEVICE_CONFIGURATION_DESC*, D3D12_DEVICE_CONFIGURATION_DESC*> )(lpVtbl[3]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.GetEnabledExperimentalFeatures"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids)
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration*, Guid*, uint, int> )(lpVtbl[4]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this), pGuids, NumGuids);
    }

    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.SerializeVersionedRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pDesc, ID3DBlob** ppResult, ID3DBlob** ppError)
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration*, D3D12_VERSIONED_ROOT_SIGNATURE_DESC*, ID3DBlob**, ID3DBlob**, int> )(lpVtbl[5]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this), pDesc, ppResult, ppError);
    }

    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.CreateVersionedRootSignatureDeserializer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] void* pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer)
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration*, void*, nuint, Guid*, void**, int> )(lpVtbl[6]))((ID3D12DeviceConfiguration*)Unsafe.AsPointer(ref this), pBlob, Size, riid, ppvDeserializer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        D3D12_DEVICE_CONFIGURATION_DESC GetDesc();
        [VtblIndex(4)]
        HRESULT GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids);
        [VtblIndex(5)]
        HRESULT SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pDesc, ID3DBlob** ppResult, ID3DBlob** ppError);
        [VtblIndex(6)]
        HRESULT CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] void* pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer);
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
        [NativeTypeName("D3D12_DEVICE_CONFIGURATION_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEVICE_CONFIGURATION_DESC*, D3D12_DEVICE_CONFIGURATION_DESC*> GetDesc;
        [NativeTypeName("HRESULT (GUID *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> GetEnabledExperimentalFeatures;
        [NativeTypeName("HRESULT (const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *, ID3DBlob **, ID3DBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VERSIONED_ROOT_SIGNATURE_DESC*, ID3DBlob**, ID3DBlob**, int> SerializeVersionedRootSignature;
        [NativeTypeName("HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, Guid*, void**, int> CreateVersionedRootSignatureDeserializer;
    }
}