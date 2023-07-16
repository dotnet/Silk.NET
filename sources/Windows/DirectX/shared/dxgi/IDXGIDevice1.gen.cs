// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDXGIDevice1.xml' path='doc/member[@name="IDXGIDevice1"]/*'/>
[Guid("77DB970F-6276-48BA-BA28-070143B4392C")]
[NativeTypeName("struct IDXGIDevice1 : IDXGIDevice")]
[NativeInheritance("IDXGIDevice")]
public unsafe partial struct IDXGIDevice1 : IDXGIDevice1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIDevice1*, uint> )(lpVtbl[1]))((IDXGIDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDevice1*, uint> )(lpVtbl[2]))((IDXGIDevice1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIDevice.GetAdapter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAdapter(IDXGIAdapter** pAdapter)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, IDXGIAdapter**, int> )(lpVtbl[7]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pAdapter);
    }

    /// <inheritdoc cref = "IDXGIDevice.CreateSurface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface([NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc, uint NumSurfaces, [NativeTypeName("DXGI_USAGE")] uint Usage, [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource, IDXGISurface** ppSurface)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, DXGI_SURFACE_DESC*, uint, uint, DXGI_SHARED_RESOURCE*, IDXGISurface**, int> )(lpVtbl[8]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
    }

    /// <inheritdoc cref = "IDXGIDevice.QueryResourceResidency"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryResourceResidency([NativeTypeName("IUnknown *const *")] IUnknown** ppResources, DXGI_RESIDENCY* pResidencyStatus, uint NumResources)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, IUnknown**, DXGI_RESIDENCY*, uint, int> )(lpVtbl[9]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
    }

    /// <inheritdoc cref = "IDXGIDevice.SetGPUThreadPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetGPUThreadPriority(int Priority)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, int, int> )(lpVtbl[10]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Priority);
    }

    /// <inheritdoc cref = "IDXGIDevice.GetGPUThreadPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGPUThreadPriority(int* pPriority)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, int*, int> )(lpVtbl[11]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pPriority);
    }

    /// <include file='IDXGIDevice1.xml' path='doc/member[@name="IDXGIDevice1.SetMaximumFrameLatency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetMaximumFrameLatency(uint MaxLatency)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, uint, int> )(lpVtbl[12]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), MaxLatency);
    }

    /// <include file='IDXGIDevice1.xml' path='doc/member[@name="IDXGIDevice1.GetMaximumFrameLatency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMaximumFrameLatency(uint* pMaxLatency)
    {
        return ((delegate* unmanaged<IDXGIDevice1*, uint*, int> )(lpVtbl[13]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pMaxLatency);
    }

    public interface Interface : IDXGIDevice.Interface
    {
        [VtblIndex(12)]
        HRESULT SetMaximumFrameLatency(uint MaxLatency);
        [VtblIndex(13)]
        HRESULT GetMaximumFrameLatency(uint* pMaxLatency);
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
        [NativeTypeName("HRESULT (IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIAdapter**, int> GetAdapter;
        [NativeTypeName("HRESULT (const DXGI_SURFACE_DESC *, UINT, DXGI_USAGE, const DXGI_SHARED_RESOURCE *, IDXGISurface **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_SURFACE_DESC*, uint, uint, DXGI_SHARED_RESOURCE*, IDXGISurface**, int> CreateSurface;
        [NativeTypeName("HRESULT (IUnknown *const *, DXGI_RESIDENCY *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, DXGI_RESIDENCY*, uint, int> QueryResourceResidency;
        [NativeTypeName("HRESULT (INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetGPUThreadPriority;
        [NativeTypeName("HRESULT (INT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetGPUThreadPriority;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMaximumFrameLatency;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumFrameLatency;
    }
}