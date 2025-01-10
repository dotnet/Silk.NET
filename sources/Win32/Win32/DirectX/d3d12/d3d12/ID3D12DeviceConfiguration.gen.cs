// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("78DBF87B-F766-422B-A61C-C8C446BDB9AD")]
[NativeTypeName("struct ID3D12DeviceConfiguration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceConfiguration
    : ID3D12DeviceConfiguration.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceConfiguration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public D3D12_DEVICE_CONFIGURATION_DESC GetDesc()
    {
        D3D12_DEVICE_CONFIGURATION_DESC result;
        return *(
            (delegate* unmanaged<
                ID3D12DeviceConfiguration,
                D3D12_DEVICE_CONFIGURATION_DESC*,
                D3D12_DEVICE_CONFIGURATION_DESC*>)((*lpVtbl)[3])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids)
    {
        return ((delegate* unmanaged<ID3D12DeviceConfiguration, Guid*, uint, int>)((*lpVtbl)[4]))(
            this,
            pGuids,
            NumGuids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pDesc,
        ID3DBlob* ppResult,
        ID3DBlob* ppError
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12DeviceConfiguration,
                D3D12_VERSIONED_ROOT_SIGNATURE_DESC*,
                ID3DBlob*,
                ID3DBlob*,
                int>)((*lpVtbl)[5])
        )(this, pDesc, ppResult, ppError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateVersionedRootSignatureDeserializer(
        [NativeTypeName("const void *")] void* pBlob,
        [NativeTypeName("SIZE_T")] nuint Size,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvDeserializer
    )
    {
        return (
            (delegate* unmanaged<ID3D12DeviceConfiguration, void*, nuint, Guid*, void**, int>)(
                (*lpVtbl)[6]
            )
        )(this, pBlob, Size, riid, ppvDeserializer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        D3D12_DEVICE_CONFIGURATION_DESC GetDesc();

        [VtblIndex(4)]
        HRESULT GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids);

        [VtblIndex(5)]
        HRESULT SerializeVersionedRootSignature(
            [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
                D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pDesc,
            ID3DBlob* ppResult,
            ID3DBlob* ppError
        );

        [VtblIndex(6)]
        HRESULT CreateVersionedRootSignatureDeserializer(
            [NativeTypeName("const void *")] void* pBlob,
            [NativeTypeName("SIZE_T")] nuint Size,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvDeserializer
        );
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
        public delegate* unmanaged<
            TSelf*,
            D3D12_DEVICE_CONFIGURATION_DESC*,
            D3D12_DEVICE_CONFIGURATION_DESC*> GetDesc;

        [NativeTypeName("HRESULT (GUID *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> GetEnabledExperimentalFeatures;

        [NativeTypeName(
            "HRESULT (const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *, ID3DBlob **, ID3DBlob **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VERSIONED_ROOT_SIGNATURE_DESC*,
            ID3DBlob*,
            ID3DBlob*,
            int> SerializeVersionedRootSignature;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            nuint,
            Guid*,
            void**,
            int> CreateVersionedRootSignatureDeserializer;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceConfiguration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceConfiguration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12DeviceConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12DeviceConfiguration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DeviceConfiguration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12DeviceConfiguration value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
