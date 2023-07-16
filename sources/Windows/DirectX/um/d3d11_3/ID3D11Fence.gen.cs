// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D11Fence.xml' path='doc/member[@name="ID3D11Fence"]/*'/>
[Guid("AFFDE9D1-1DF7-4BB7-8A34-0F46251DAB80")]
[NativeTypeName("struct ID3D11Fence : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11Fence : ID3D11Fence.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Fence));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Fence*, Guid*, void**, int> )(lpVtbl[0]))((ID3D11Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11Fence*, uint> )(lpVtbl[1]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Fence*, uint> )(lpVtbl[2]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11Fence*, ID3D11Device**, void> )(lpVtbl[3]))((ID3D11Fence*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int> )(lpVtbl[4]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11Fence*, Guid*, uint, void*, int> )(lpVtbl[5]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D11DeviceChild.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11Fence*, Guid*, IUnknown*, int> )(lpVtbl[6]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <include file='ID3D11Fence.xml' path='doc/member[@name="ID3D11Fence.CreateSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, HANDLE* pHandle)
    {
        return ((delegate* unmanaged<ID3D11Fence*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int> )(lpVtbl[7]))((ID3D11Fence*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
    }

    /// <include file='ID3D11Fence.xml' path='doc/member[@name="ID3D11Fence.GetCompletedValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetCompletedValue()
    {
        return ((delegate* unmanaged<ID3D11Fence*, ulong> )(lpVtbl[8]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11Fence.xml' path='doc/member[@name="ID3D11Fence.SetEventOnCompletion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, HANDLE hEvent)
    {
        return ((delegate* unmanaged<ID3D11Fence*, ulong, HANDLE, int> )(lpVtbl[9]))((ID3D11Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        HRESULT CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, HANDLE* pHandle);
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        ulong GetCompletedValue();
        [VtblIndex(9)]
        HRESULT SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, HANDLE hEvent);
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
        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int> CreateSharedHandle;
        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetCompletedValue;
        [NativeTypeName("HRESULT (UINT64, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, HANDLE, int> SetEventOnCompletion;
    }
}