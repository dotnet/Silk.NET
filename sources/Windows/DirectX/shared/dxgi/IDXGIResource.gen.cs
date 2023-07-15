// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDXGIResource.xml' path='doc/member[@name="IDXGIResource"]/*'/>
[Guid("035F3AB4-482E-4E50-B41F-8A7F8BD8960B")]
[NativeTypeName("struct IDXGIResource : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IDXGIResource : IDXGIResource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIResource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIResource*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIResource*, uint> )(lpVtbl[1]))((IDXGIResource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIResource*, uint> )(lpVtbl[2]))((IDXGIResource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIResource*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIResource*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIResource*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIResource*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIResource*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIResource*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIResource*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIDeviceSubObject.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
    {
        return ((delegate* unmanaged<IDXGIResource*, Guid*, void**, int> )(lpVtbl[7]))((IDXGIResource*)Unsafe.AsPointer(ref this), riid, ppDevice);
    }

    /// <include file='IDXGIResource.xml' path='doc/member[@name="IDXGIResource.GetSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSharedHandle(HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged<IDXGIResource*, HANDLE*, int> )(lpVtbl[8]))((IDXGIResource*)Unsafe.AsPointer(ref this), pSharedHandle);
    }

    /// <include file='IDXGIResource.xml' path='doc/member[@name="IDXGIResource.GetUsage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetUsage([NativeTypeName("DXGI_USAGE *")] uint* pUsage)
    {
        return ((delegate* unmanaged<IDXGIResource*, uint*, int> )(lpVtbl[9]))((IDXGIResource*)Unsafe.AsPointer(ref this), pUsage);
    }

    /// <include file='IDXGIResource.xml' path='doc/member[@name="IDXGIResource.SetEvictionPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEvictionPriority(uint EvictionPriority)
    {
        return ((delegate* unmanaged<IDXGIResource*, uint, int> )(lpVtbl[10]))((IDXGIResource*)Unsafe.AsPointer(ref this), EvictionPriority);
    }

    /// <include file='IDXGIResource.xml' path='doc/member[@name="IDXGIResource.GetEvictionPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetEvictionPriority(uint* pEvictionPriority)
    {
        return ((delegate* unmanaged<IDXGIResource*, uint*, int> )(lpVtbl[11]))((IDXGIResource*)Unsafe.AsPointer(ref this), pEvictionPriority);
    }

    public interface Interface : IDXGIDeviceSubObject.Interface
    {
        [VtblIndex(8)]
        HRESULT GetSharedHandle(HANDLE* pSharedHandle);
        [VtblIndex(9)]
        HRESULT GetUsage([NativeTypeName("DXGI_USAGE *")] uint* pUsage);
        [VtblIndex(10)]
        HRESULT SetEvictionPriority(uint EvictionPriority);
        [VtblIndex(11)]
        HRESULT GetEvictionPriority(uint* pEvictionPriority);
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
    }
}