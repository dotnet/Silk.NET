// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDXGIResource1.xml' path='doc/member[@name="IDXGIResource1"]/*'/>
[Guid("30961379-4609-4A41-998E-54FE567EE0C1")]
[NativeTypeName("struct IDXGIResource1 : IDXGIResource")]
[NativeInheritance("IDXGIResource")]
public unsafe partial struct IDXGIResource1 : IDXGIResource1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIResource1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIResource1*, uint> )(lpVtbl[1]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIResource1*, uint> )(lpVtbl[2]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIResource1*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIResource1*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIDeviceSubObject.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int> )(lpVtbl[7]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppDevice);
    }

    /// <inheritdoc cref = "IDXGIResource.GetSharedHandle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSharedHandle(HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged<IDXGIResource1*, HANDLE*, int> )(lpVtbl[8]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pSharedHandle);
    }

    /// <inheritdoc cref = "IDXGIResource.GetUsage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetUsage([NativeTypeName("DXGI_USAGE *")] uint* pUsage)
    {
        return ((delegate* unmanaged<IDXGIResource1*, uint*, int> )(lpVtbl[9]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pUsage);
    }

    /// <inheritdoc cref = "IDXGIResource.SetEvictionPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEvictionPriority(uint EvictionPriority)
    {
        return ((delegate* unmanaged<IDXGIResource1*, uint, int> )(lpVtbl[10]))((IDXGIResource1*)Unsafe.AsPointer(ref this), EvictionPriority);
    }

    /// <inheritdoc cref = "IDXGIResource.GetEvictionPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEvictionPriority(uint* pEvictionPriority)
    {
        return ((delegate* unmanaged<IDXGIResource1*, uint*, int> )(lpVtbl[11]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pEvictionPriority);
    }

    /// <include file='IDXGIResource1.xml' path='doc/member[@name="IDXGIResource1.CreateSubresourceSurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateSubresourceSurface(uint index, IDXGISurface2** ppSurface)
    {
        return ((delegate* unmanaged<IDXGIResource1*, uint, IDXGISurface2**, int> )(lpVtbl[12]))((IDXGIResource1*)Unsafe.AsPointer(ref this), index, ppSurface);
    }

    /// <include file='IDXGIResource1.xml' path='doc/member[@name="IDXGIResource1.CreateSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, HANDLE* pHandle)
    {
        return ((delegate* unmanaged<IDXGIResource1*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int> )(lpVtbl[13]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
    }

    public interface Interface : IDXGIResource.Interface
    {
        [VtblIndex(12)]
        HRESULT CreateSubresourceSurface(uint index, IDXGISurface2** ppSurface);
        [VtblIndex(13)]
        HRESULT CreateSharedHandle([NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint dwAccess, [NativeTypeName("LPCWSTR")] ushort* lpName, HANDLE* pHandle);
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
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetSharedHandle;
        [NativeTypeName("HRESULT (DXGI_USAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUsage;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEvictionPriority;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetEvictionPriority;
        [NativeTypeName("HRESULT (UINT, IDXGISurface2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGISurface2**, int> CreateSubresourceSurface;
        [NativeTypeName("HRESULT (const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int> CreateSharedHandle;
    }
}