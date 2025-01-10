// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C1B6694F-FF09-44A9-B03C-77900A0A1D17")]
[NativeTypeName("struct IDXGIFactory6 : IDXGIFactory5")]
[NativeInheritance("IDXGIFactory5")]
[SupportedOSPlatform("windows10.0.17134.0")]
public unsafe partial struct IDXGIFactory6 : IDXGIFactory6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIFactory6, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIFactory6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIFactory6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
            this,
            Name,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            Name,
            pUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
            this,
            Name,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIFactory6, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumAdapters(uint Adapter, IDXGIAdapter* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6, uint, IDXGIAdapter*, int>)((*lpVtbl)[7]))(
            this,
            Adapter,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MakeWindowAssociation(HWND WindowHandle, uint Flags)
    {
        return ((delegate* unmanaged<IDXGIFactory6, HWND, uint, int>)((*lpVtbl)[8]))(
            this,
            WindowHandle,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetWindowAssociation(HWND* pWindowHandle)
    {
        return ((delegate* unmanaged<IDXGIFactory6, HWND*, int>)((*lpVtbl)[9]))(
            this,
            pWindowHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateSwapChain(
        IUnknown pDevice,
        DXGI_SWAP_CHAIN_DESC* pDesc,
        IDXGISwapChain* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory6,
                IUnknown,
                DXGI_SWAP_CHAIN_DESC*,
                IDXGISwapChain*,
                int>)((*lpVtbl)[10])
        )(this, pDevice, pDesc, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateSoftwareAdapter(HMODULE Module, IDXGIAdapter* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6, HMODULE, IDXGIAdapter*, int>)((*lpVtbl)[11]))(
            this,
            Module,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumAdapters1(uint Adapter, IDXGIAdapter1* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6, uint, IDXGIAdapter1*, int>)((*lpVtbl)[12]))(
            this,
            Adapter,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public BOOL IsCurrent()
    {
        return ((delegate* unmanaged<IDXGIFactory6, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public BOOL IsWindowedStereoEnabled()
    {
        return ((delegate* unmanaged<IDXGIFactory6, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateSwapChainForHwnd(
        IUnknown pDevice,
        HWND hWnd,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory6,
                IUnknown,
                HWND,
                DXGI_SWAP_CHAIN_DESC1*,
                DXGI_SWAP_CHAIN_FULLSCREEN_DESC*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[15])
        )(this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateSwapChainForCoreWindow(
        IUnknown pDevice,
        IUnknown pWindow,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory6,
                IUnknown,
                IUnknown,
                DXGI_SWAP_CHAIN_DESC1*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[16])
        )(this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSharedResourceAdapterLuid(HANDLE hResource, LUID* pLuid)
    {
        return ((delegate* unmanaged<IDXGIFactory6, HANDLE, LUID*, int>)((*lpVtbl)[17]))(
            this,
            hResource,
            pLuid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RegisterStereoStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, HWND, uint, uint*, int>)((*lpVtbl)[18]))(
            this,
            WindowHandle,
            wMsg,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RegisterStereoStatusEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, HANDLE, uint*, int>)((*lpVtbl)[19]))(
            this,
            hEvent,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
    {
        ((delegate* unmanaged<IDXGIFactory6, uint, void>)((*lpVtbl)[20]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RegisterOcclusionStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, HWND, uint, uint*, int>)((*lpVtbl)[21]))(
            this,
            WindowHandle,
            wMsg,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RegisterOcclusionStatusEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, HANDLE, uint*, int>)((*lpVtbl)[22]))(
            this,
            hEvent,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
    {
        ((delegate* unmanaged<IDXGIFactory6, uint, void>)((*lpVtbl)[23]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateSwapChainForComposition(
        IUnknown pDevice,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory6,
                IUnknown,
                DXGI_SWAP_CHAIN_DESC1*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[24])
        )(this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public uint GetCreationFlags()
    {
        return ((delegate* unmanaged<IDXGIFactory6, uint>)((*lpVtbl)[25]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT EnumAdapterByLuid(
        LUID AdapterLuid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapter
    )
    {
        return ((delegate* unmanaged<IDXGIFactory6, LUID, Guid*, void**, int>)((*lpVtbl)[26]))(
            this,
            AdapterLuid,
            riid,
            ppvAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory6, Guid*, void**, int>)((*lpVtbl)[27]))(
            this,
            riid,
            ppvAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CheckFeatureSupport(
        DXGI_FEATURE Feature,
        void* pFeatureSupportData,
        uint FeatureSupportDataSize
    )
    {
        return (
            (delegate* unmanaged<IDXGIFactory6, DXGI_FEATURE, void*, uint, int>)((*lpVtbl)[28])
        )(this, Feature, pFeatureSupportData, FeatureSupportDataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT EnumAdapterByGpuPreference(
        uint Adapter,
        DXGI_GPU_PREFERENCE GpuPreference,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapter
    )
    {
        return (
            (delegate* unmanaged<IDXGIFactory6, uint, DXGI_GPU_PREFERENCE, Guid*, void**, int>)(
                (*lpVtbl)[29]
            )
        )(this, Adapter, GpuPreference, riid, ppvAdapter);
    }

    public interface Interface : IDXGIFactory5.Interface
    {
        [VtblIndex(29)]
        HRESULT EnumAdapterByGpuPreference(
            uint Adapter,
            DXGI_GPU_PREFERENCE GpuPreference,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvAdapter
        );
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
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;

        [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIAdapter*, int> EnumAdapters;

        [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> MakeWindowAssociation;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindowAssociation;

        [NativeTypeName(
            "HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            DXGI_SWAP_CHAIN_DESC*,
            IDXGISwapChain*,
            int> CreateSwapChain;

        [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMODULE, IDXGIAdapter*, int> CreateSoftwareAdapter;

        [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIAdapter1*, int> EnumAdapters1;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsCurrent;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsWindowedStereoEnabled;

        [NativeTypeName(
            "HRESULT (IUnknown *, HWND, const DXGI_SWAP_CHAIN_DESC1 *, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            HWND,
            DXGI_SWAP_CHAIN_DESC1*,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForHwnd;

        [NativeTypeName(
            "HRESULT (IUnknown *, IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IUnknown,
            DXGI_SWAP_CHAIN_DESC1*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForCoreWindow;

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

        [NativeTypeName(
            "HRESULT (IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            DXGI_SWAP_CHAIN_DESC1*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForComposition;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCreationFlags;

        [NativeTypeName("HRESULT (LUID, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID, Guid*, void**, int> EnumAdapterByLuid;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> EnumWarpAdapter;

        [NativeTypeName("HRESULT (DXGI_FEATURE, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FEATURE, void*, uint, int> CheckFeatureSupport;

        [NativeTypeName(
            "HRESULT (UINT, DXGI_GPU_PREFERENCE, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DXGI_GPU_PREFERENCE,
            Guid*,
            void**,
            int> EnumAdapterByGpuPreference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIFactory6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIFactory6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory5"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory5"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIFactory5 value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory5"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory5(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory5(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory4"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory4"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIFactory4 value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory4"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory4(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory3"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory3"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIFactory3 value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory3"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory3(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory2"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory2"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIFactory2 value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory2(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory1"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory1"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIFactory1 value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory1(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIFactory value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIFactory6 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIFactory6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIFactory6(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIFactory6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIFactory6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
