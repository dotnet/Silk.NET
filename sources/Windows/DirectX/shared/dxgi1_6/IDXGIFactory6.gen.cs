// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDXGIFactory6.xml' path='doc/member[@name="IDXGIFactory6"]/*'/>
[Guid("C1B6694F-FF09-44A9-B03C-77900A0A1D17")]
[NativeTypeName("struct IDXGIFactory6 : IDXGIFactory5")]
[NativeInheritance("IDXGIFactory5")]
[SupportedOSPlatform("windows10.0.17134.0")]
public unsafe partial struct IDXGIFactory6 : IDXGIFactory6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory6));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIFactory6*, uint> )(lpVtbl[1]))((IDXGIFactory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIFactory6*, uint> )(lpVtbl[2]))((IDXGIFactory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, Guid*, uint, void*, int> )(lpVtbl[3]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, Guid*, IUnknown*, int> )(lpVtbl[4]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref = "IDXGIObject.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, Guid*, uint*, void*, int> )(lpVtbl[5]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref = "IDXGIObject.GetParent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, Guid*, void**, int> )(lpVtbl[6]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <inheritdoc cref = "IDXGIFactory.EnumAdapters"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, uint, IDXGIAdapter**, int> )(lpVtbl[7]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
    }

    /// <inheritdoc cref = "IDXGIFactory.MakeWindowAssociation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MakeWindowAssociation(HWND WindowHandle, uint Flags)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HWND, uint, int> )(lpVtbl[8]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
    }

    /// <inheritdoc cref = "IDXGIFactory.GetWindowAssociation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetWindowAssociation(HWND* pWindowHandle)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HWND*, int> )(lpVtbl[9]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), pWindowHandle);
    }

    /// <inheritdoc cref = "IDXGIFactory.CreateSwapChain"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateSwapChain(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int> )(lpVtbl[10]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
    }

    /// <inheritdoc cref = "IDXGIFactory.CreateSoftwareAdapter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateSoftwareAdapter(HMODULE Module, IDXGIAdapter** ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HMODULE, IDXGIAdapter**, int> )(lpVtbl[11]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Module, ppAdapter);
    }

    /// <inheritdoc cref = "IDXGIFactory1.EnumAdapters1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, uint, IDXGIAdapter1**, int> )(lpVtbl[12]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
    }

    /// <inheritdoc cref = "IDXGIFactory1.IsCurrent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public BOOL IsCurrent()
    {
        return ((delegate* unmanaged<IDXGIFactory6*, int> )(lpVtbl[13]))((IDXGIFactory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIFactory2.IsWindowedStereoEnabled"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public BOOL IsWindowedStereoEnabled()
    {
        return ((delegate* unmanaged<IDXGIFactory6*, int> )(lpVtbl[14]))((IDXGIFactory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIFactory2.CreateSwapChainForHwnd"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateSwapChainForHwnd(IUnknown* pDevice, HWND hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, IUnknown*, HWND, DXGI_SWAP_CHAIN_DESC1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, IDXGIOutput*, IDXGISwapChain1**, int> )(lpVtbl[15]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <inheritdoc cref = "IDXGIFactory2.CreateSwapChainForCoreWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, IUnknown*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> )(lpVtbl[16]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <inheritdoc cref = "IDXGIFactory2.GetSharedResourceAdapterLuid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSharedResourceAdapterLuid(HANDLE hResource, LUID* pLuid)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HANDLE, LUID*, int> )(lpVtbl[17]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), hResource, pLuid);
    }

    /// <inheritdoc cref = "IDXGIFactory2.RegisterStereoStatusWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RegisterStereoStatusWindow(HWND WindowHandle, uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HWND, uint, uint*, int> )(lpVtbl[18]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
    }

    /// <inheritdoc cref = "IDXGIFactory2.RegisterStereoStatusEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RegisterStereoStatusEvent(HANDLE hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HANDLE, uint*, int> )(lpVtbl[19]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
    }

    /// <inheritdoc cref = "IDXGIFactory2.UnregisterStereoStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
    {
        ((delegate* unmanaged<IDXGIFactory6*, uint, void> )(lpVtbl[20]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <inheritdoc cref = "IDXGIFactory2.RegisterOcclusionStatusWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RegisterOcclusionStatusWindow(HWND WindowHandle, uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HWND, uint, uint*, int> )(lpVtbl[21]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
    }

    /// <inheritdoc cref = "IDXGIFactory2.RegisterOcclusionStatusEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RegisterOcclusionStatusEvent(HANDLE hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, HANDLE, uint*, int> )(lpVtbl[22]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
    }

    /// <inheritdoc cref = "IDXGIFactory2.UnregisterOcclusionStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
    {
        ((delegate* unmanaged<IDXGIFactory6*, uint, void> )(lpVtbl[23]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <inheritdoc cref = "IDXGIFactory2.CreateSwapChainForComposition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateSwapChainForComposition(IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> )(lpVtbl[24]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <inheritdoc cref = "IDXGIFactory3.GetCreationFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public uint GetCreationFlags()
    {
        return ((delegate* unmanaged<IDXGIFactory6*, uint> )(lpVtbl[25]))((IDXGIFactory6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDXGIFactory4.EnumAdapterByLuid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, LUID, Guid*, void**, int> )(lpVtbl[26]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
    }

    /// <inheritdoc cref = "IDXGIFactory4.EnumWarpAdapter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, Guid*, void**, int> )(lpVtbl[27]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
    }

    /// <inheritdoc cref = "IDXGIFactory5.CheckFeatureSupport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CheckFeatureSupport(DXGI_FEATURE Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, DXGI_FEATURE, void*, uint, int> )(lpVtbl[28]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
    }

    /// <include file='IDXGIFactory6.xml' path='doc/member[@name="IDXGIFactory6.EnumAdapterByGpuPreference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT EnumAdapterByGpuPreference(uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6*, uint, DXGI_GPU_PREFERENCE, Guid*, void**, int> )(lpVtbl[29]))((IDXGIFactory6*)Unsafe.AsPointer(ref this), Adapter, GpuPreference, riid, ppvAdapter);
    }

    public interface Interface : IDXGIFactory5.Interface
    {
        [VtblIndex(29)]
        HRESULT EnumAdapterByGpuPreference(uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter);
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
        [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIAdapter**, int> EnumAdapters;
        [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> MakeWindowAssociation;
        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindowAssociation;
        [NativeTypeName("HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int> CreateSwapChain;
        [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMODULE, IDXGIAdapter**, int> CreateSoftwareAdapter;
        [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIAdapter1**, int> EnumAdapters1;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsCurrent;
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsWindowedStereoEnabled;
        [NativeTypeName("HRESULT (IUnknown *, HWND, const DXGI_SWAP_CHAIN_DESC1 *, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, HWND, DXGI_SWAP_CHAIN_DESC1*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForHwnd;
        [NativeTypeName("HRESULT (IUnknown *, IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForCoreWindow;
        [NativeTypeName("HRESULT (HANDLE, LUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, LUID*, int> GetSharedResourceAdapterLuid;
        [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, uint*, int> RegisterStereoStatusWindow;
        [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, uint*, int> RegisterStereoStatusEvent;
        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> UnregisterStereoStatus;
        [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, uint*, int> RegisterOcclusionStatusWindow;
        [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, uint*, int> RegisterOcclusionStatusEvent;
        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> UnregisterOcclusionStatus;
        [NativeTypeName("HRESULT (IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForComposition;
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCreationFlags;
        [NativeTypeName("HRESULT (LUID, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID, Guid*, void**, int> EnumAdapterByLuid;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> EnumWarpAdapter;
        [NativeTypeName("HRESULT (DXGI_FEATURE, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FEATURE, void*, uint, int> CheckFeatureSupport;
        [NativeTypeName("HRESULT (UINT, DXGI_GPU_PREFERENCE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DXGI_GPU_PREFERENCE, Guid*, void**, int> EnumAdapterByGpuPreference;
    }
}