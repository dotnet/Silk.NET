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

[Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
[NativeTypeName("struct ID3D12VersionedRootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    : ID3D12VersionedRootSignatureDeserializer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VersionedRootSignatureDeserializer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRootSignatureDescAtVersion(
        D3D_ROOT_SIGNATURE_VERSION convertToVersion,
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")]
            D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12VersionedRootSignatureDeserializer,
                D3D_ROOT_SIGNATURE_VERSION,
                D3D12_VERSIONED_ROOT_SIGNATURE_DESC**,
                int>)((*lpVtbl)[3])
        )(this, convertToVersion, ppDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc()
    {
        return (
            (delegate* unmanaged<
                ID3D12VersionedRootSignatureDeserializer,
                D3D12_VERSIONED_ROOT_SIGNATURE_DESC*>)((*lpVtbl)[4])
        )(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRootSignatureDescAtVersion(
            D3D_ROOT_SIGNATURE_VERSION convertToVersion,
            [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")]
                D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc
        );

        [VtblIndex(4)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc();
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

        [NativeTypeName(
            "HRESULT (D3D_ROOT_SIGNATURE_VERSION, const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D_ROOT_SIGNATURE_VERSION,
            D3D12_VERSIONED_ROOT_SIGNATURE_DESC**,
            int> GetRootSignatureDescAtVersion;

        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_VERSIONED_ROOT_SIGNATURE_DESC*> GetUnconvertedRootSignatureDesc;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VersionedRootSignatureDeserializer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VersionedRootSignatureDeserializer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12VersionedRootSignatureDeserializer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12VersionedRootSignatureDeserializer(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ID3D12VersionedRootSignatureDeserializer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12VersionedRootSignatureDeserializer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VersionedRootSignatureDeserializer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ID3D12VersionedRootSignatureDeserializer value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
