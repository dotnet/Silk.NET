// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D12ProtectedResourceSession1.xml' path='doc/member[@name="ID3D12ProtectedResourceSession1"]/*'/>
[Guid("D6F12DD6-76FB-406E-8961-4296EEFC0409")]
[NativeTypeName("struct ID3D12ProtectedResourceSession1 : ID3D12ProtectedResourceSession")]
[NativeInheritance("ID3D12ProtectedResourceSession")]
public unsafe partial struct ID3D12ProtectedResourceSession1 : ID3D12ProtectedResourceSession1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ProtectedResourceSession1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, uint> )(lpVtbl[1]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, uint> )(lpVtbl[2]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, Guid*, uint*, void*, int> )(lpVtbl[3]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, Guid*, uint, void*, int> )(lpVtbl[4]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, Guid*, IUnknown*, int> )(lpVtbl[5]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, ushort*, int> )(lpVtbl[6]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, Guid*, void**, int> )(lpVtbl[7]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref = "ID3D12ProtectedSession.GetStatusFence"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStatusFence([NativeTypeName("const IID &")] Guid* riid, void** ppFence)
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, Guid*, void**, int> )(lpVtbl[8]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), riid, ppFence);
    }

    /// <inheritdoc cref = "ID3D12ProtectedSession.GetSessionStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12_PROTECTED_SESSION_STATUS GetSessionStatus()
    {
        return ((delegate* unmanaged<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_SESSION_STATUS> )(lpVtbl[9]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12ProtectedResourceSession.GetDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc()
    {
        D3D12_PROTECTED_RESOURCE_SESSION_DESC result;
        return *((delegate* unmanaged<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*> )(lpVtbl[10]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID3D12ProtectedResourceSession1.xml' path='doc/member[@name="ID3D12ProtectedResourceSession1.GetDesc1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12_PROTECTED_RESOURCE_SESSION_DESC1 GetDesc1()
    {
        D3D12_PROTECTED_RESOURCE_SESSION_DESC1 result;
        return *((delegate* unmanaged<ID3D12ProtectedResourceSession1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*> )(lpVtbl[11]))((ID3D12ProtectedResourceSession1*)Unsafe.AsPointer(ref this), &result);
    }

    public interface Interface : ID3D12ProtectedResourceSession.Interface
    {
        [VtblIndex(11)]
        D3D12_PROTECTED_RESOURCE_SESSION_DESC1 GetDesc1();
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
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetStatusFence;
        [NativeTypeName("D3D12_PROTECTED_SESSION_STATUS () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_PROTECTED_SESSION_STATUS> GetSessionStatus;
        [NativeTypeName("D3D12_PROTECTED_RESOURCE_SESSION_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*> GetDesc;
        [NativeTypeName("D3D12_PROTECTED_RESOURCE_SESSION_DESC1 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*, D3D12_PROTECTED_RESOURCE_SESSION_DESC1*> GetDesc1;
    }
}