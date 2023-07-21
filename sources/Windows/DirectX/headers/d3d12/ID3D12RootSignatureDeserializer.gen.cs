// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer"]/*' />
[Guid("34AB647B-3CC8-46AC-841B-C0965645C046")]
[NativeTypeName("struct ID3D12RootSignatureDeserializer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12RootSignatureDeserializer : ID3D12RootSignatureDeserializer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12RootSignatureDeserializer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, uint>)(lpVtbl[1]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, uint>)(lpVtbl[2]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12RootSignatureDeserializer.xml' path='doc/member[@name="ID3D12RootSignatureDeserializer.GetRootSignatureDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
    public D3D12_ROOT_SIGNATURE_DESC* GetRootSignatureDesc()
    {
        return ((delegate* unmanaged<ID3D12RootSignatureDeserializer*, D3D12_ROOT_SIGNATURE_DESC*>)(lpVtbl[3]))((ID3D12RootSignatureDeserializer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
        D3D12_ROOT_SIGNATURE_DESC* GetRootSignatureDesc();
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

        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_ROOT_SIGNATURE_DESC*> GetRootSignatureDesc;
    }
}
