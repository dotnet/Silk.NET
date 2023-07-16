// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D11On12On7.xml' path='doc/member[@name="ID3D11On12On7"]/*'/>
[Guid("00000000-0000-0000-0000-000000000000")]
[NativeTypeName("struct ID3D11On12On7 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11On12On7 : ID3D11On12On7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12On7));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11On12On7*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11On12On7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11On12On7*, uint> )(lpVtbl[1]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11On12On7*, uint> )(lpVtbl[2]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11On12On7.xml' path='doc/member[@name="ID3D11On12On7.SetThreadDeviceCreationParams"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetThreadDeviceCreationParams(ID3D12Device* pDevice, ID3D12CommandQueue* pGraphicsQueue)
    {
        ((delegate* unmanaged<ID3D11On12On7*, ID3D12Device*, ID3D12CommandQueue*, void> )(lpVtbl[3]))((ID3D11On12On7*)Unsafe.AsPointer(ref this), pDevice, pGraphicsQueue);
    }

    /// <include file='ID3D11On12On7.xml' path='doc/member[@name="ID3D11On12On7.SetThreadResourceCreationParams"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetThreadResourceCreationParams(ID3D12Resource* pResource)
    {
        ((delegate* unmanaged<ID3D11On12On7*, ID3D12Resource*, void> )(lpVtbl[4]))((ID3D11On12On7*)Unsafe.AsPointer(ref this), pResource);
    }

    /// <include file='ID3D11On12On7.xml' path='doc/member[@name="ID3D11On12On7.GetThreadLastCreatedDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D11On12On7Device* GetThreadLastCreatedDevice()
    {
        return ((delegate* unmanaged<ID3D11On12On7*, ID3D11On12On7Device*> )(lpVtbl[5]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11On12On7.xml' path='doc/member[@name="ID3D11On12On7.GetThreadLastCreatedResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("ID3D11On12On7Resource*")]
    public void* GetThreadLastCreatedResource()
    {
        return ((delegate* unmanaged<ID3D11On12On7*, void*> )(lpVtbl[6]))((ID3D11On12On7*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetThreadDeviceCreationParams(ID3D12Device* pDevice, ID3D12CommandQueue* pGraphicsQueue);
        [VtblIndex(4)]
        void SetThreadResourceCreationParams(ID3D12Resource* pResource);
        [VtblIndex(5)]
        ID3D11On12On7Device* GetThreadLastCreatedDevice();
        [VtblIndex(6)]
        [return: NativeTypeName("ID3D11On12On7Resource*")]
        void* GetThreadLastCreatedResource();
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
        [NativeTypeName("void (ID3D12Device *, ID3D12CommandQueue *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Device*, ID3D12CommandQueue*, void> SetThreadDeviceCreationParams;
        [NativeTypeName("void (ID3D12Resource *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, void> SetThreadResourceCreationParams;
        [NativeTypeName("ID3D11On12On7Device *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11On12On7Device*> GetThreadLastCreatedDevice;
        [NativeTypeName("ID3D11On12On7Resource *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetThreadLastCreatedResource;
    }
}