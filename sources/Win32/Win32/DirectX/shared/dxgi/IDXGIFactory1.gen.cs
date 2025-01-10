// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("770AAE78-F26F-4DBA-A829-253C83D1B387")]
[NativeTypeName("struct IDXGIFactory1 : IDXGIFactory")]
[NativeInheritance("IDXGIFactory")]
public unsafe partial struct IDXGIFactory1 : IDXGIFactory1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIFactory1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIFactory1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIFactory1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIFactory1, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDXGIFactory1, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDXGIFactory1, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDXGIFactory1, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumAdapters(uint Adapter, IDXGIAdapter* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory1, uint, IDXGIAdapter*, int>)((*lpVtbl)[7]))(
            this,
            Adapter,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MakeWindowAssociation(HWND WindowHandle, uint Flags)
    {
        return ((delegate* unmanaged<IDXGIFactory1, HWND, uint, int>)((*lpVtbl)[8]))(
            this,
            WindowHandle,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetWindowAssociation(HWND* pWindowHandle)
    {
        return ((delegate* unmanaged<IDXGIFactory1, HWND*, int>)((*lpVtbl)[9]))(
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
                IDXGIFactory1,
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
        return ((delegate* unmanaged<IDXGIFactory1, HMODULE, IDXGIAdapter*, int>)((*lpVtbl)[11]))(
            this,
            Module,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumAdapters1(uint Adapter, IDXGIAdapter1* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory1, uint, IDXGIAdapter1*, int>)((*lpVtbl)[12]))(
            this,
            Adapter,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public BOOL IsCurrent()
    {
        return ((delegate* unmanaged<IDXGIFactory1, int>)((*lpVtbl)[13]))(this);
    }

    public interface Interface : IDXGIFactory.Interface
    {
        [VtblIndex(12)]
        HRESULT EnumAdapters1(uint Adapter, IDXGIAdapter1* ppAdapter);

        [VtblIndex(13)]
        BOOL IsCurrent();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIFactory1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIFactory1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory"/> to <see cref = "IDXGIFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory"/> instance to be converted </param>
    public static explicit operator IDXGIFactory1(Silk.NET.DirectX.IDXGIFactory value)
    {
        return new IDXGIFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory1"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory(IDXGIFactory1 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIFactory1(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory1"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIFactory1 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIFactory1(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIFactory1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
