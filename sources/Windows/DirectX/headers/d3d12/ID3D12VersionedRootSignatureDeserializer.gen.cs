// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer"]/*' />
[Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
[NativeTypeName("struct ID3D12VersionedRootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12VersionedRootSignatureDeserializer : ID3D12VersionedRootSignatureDeserializer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VersionedRootSignatureDeserializer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, uint>)(lpVtbl[1]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, uint>)(lpVtbl[2]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer.GetRootSignatureDescAtVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)
    {
        return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, D3D_ROOT_SIGNATURE_VERSION, D3D12_VERSIONED_ROOT_SIGNATURE_DESC**, int>)(lpVtbl[3]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), convertToVersion, ppDesc);
    }

    /// <include file='ID3D12VersionedRootSignatureDeserializer.xml' path='doc/member[@name="ID3D12VersionedRootSignatureDeserializer.GetUnconvertedRootSignatureDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc()
    {
        return ((delegate* unmanaged<ID3D12VersionedRootSignatureDeserializer*, D3D12_VERSIONED_ROOT_SIGNATURE_DESC*>)(lpVtbl[4]))((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc);

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

        [NativeTypeName("HRESULT (D3D_ROOT_SIGNATURE_VERSION, const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_ROOT_SIGNATURE_VERSION, D3D12_VERSIONED_ROOT_SIGNATURE_DESC**, int> GetRootSignatureDescAtVersion;

        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_VERSIONED_ROOT_SIGNATURE_DESC*> GetUnconvertedRootSignatureDesc;
    }
}
