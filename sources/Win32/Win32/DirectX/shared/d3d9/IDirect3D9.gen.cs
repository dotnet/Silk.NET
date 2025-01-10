// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("81BDCBCA-64D4-426D-AE8D-AD0147F4275C")]
[NativeTypeName("struct IDirect3D9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3D9 : IDirect3D9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3D9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3D9, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3D9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3D9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterSoftwareDevice(void* pInitializeFunction)
    {
        return ((delegate* unmanaged<IDirect3D9, void*, int>)((*lpVtbl)[3]))(
            this,
            pInitializeFunction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetAdapterCount()
    {
        return ((delegate* unmanaged<IDirect3D9, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAdapterIdentifier(
        uint Adapter,
        [NativeTypeName("DWORD")] uint Flags,
        D3DADAPTER_IDENTIFIER9* pIdentifier
    )
    {
        return (
            (delegate* unmanaged<IDirect3D9, uint, uint, D3DADAPTER_IDENTIFIER9*, int>)(
                (*lpVtbl)[5]
            )
        )(this, Adapter, Flags, pIdentifier);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetAdapterModeCount(uint Adapter, D3DFORMAT Format)
    {
        return ((delegate* unmanaged<IDirect3D9, uint, D3DFORMAT, uint>)((*lpVtbl)[6]))(
            this,
            Adapter,
            Format
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumAdapterModes(
        uint Adapter,
        D3DFORMAT Format,
        uint Mode,
        D3DDISPLAYMODE* pMode
    )
    {
        return (
            (delegate* unmanaged<IDirect3D9, uint, D3DFORMAT, uint, D3DDISPLAYMODE*, int>)(
                (*lpVtbl)[7]
            )
        )(this, Adapter, Format, Mode, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAdapterDisplayMode(uint Adapter, D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged<IDirect3D9, uint, D3DDISPLAYMODE*, int>)((*lpVtbl)[8]))(
            this,
            Adapter,
            pMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CheckDeviceType(
        uint Adapter,
        D3DDEVTYPE DevType,
        D3DFORMAT AdapterFormat,
        D3DFORMAT BackBufferFormat,
        BOOL bWindowed
    )
    {
        return (
            (delegate* unmanaged<IDirect3D9, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, BOOL, int>)(
                (*lpVtbl)[9]
            )
        )(this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CheckDeviceFormat(
        uint Adapter,
        D3DDEVTYPE DeviceType,
        D3DFORMAT AdapterFormat,
        [NativeTypeName("DWORD")] uint Usage,
        D3DRESOURCETYPE RType,
        D3DFORMAT CheckFormat
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3D9,
                uint,
                D3DDEVTYPE,
                D3DFORMAT,
                uint,
                D3DRESOURCETYPE,
                D3DFORMAT,
                int>)((*lpVtbl)[10])
        )(this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CheckDeviceMultiSampleType(
        uint Adapter,
        D3DDEVTYPE DeviceType,
        D3DFORMAT SurfaceFormat,
        BOOL Windowed,
        D3DMULTISAMPLE_TYPE MultiSampleType,
        [NativeTypeName("DWORD *")] uint* pQualityLevels
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3D9,
                uint,
                D3DDEVTYPE,
                D3DFORMAT,
                BOOL,
                D3DMULTISAMPLE_TYPE,
                uint*,
                int>)((*lpVtbl)[11])
        )(this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CheckDepthStencilMatch(
        uint Adapter,
        D3DDEVTYPE DeviceType,
        D3DFORMAT AdapterFormat,
        D3DFORMAT RenderTargetFormat,
        D3DFORMAT DepthStencilFormat
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3D9,
                uint,
                D3DDEVTYPE,
                D3DFORMAT,
                D3DFORMAT,
                D3DFORMAT,
                int>)((*lpVtbl)[12])
        )(this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CheckDeviceFormatConversion(
        uint Adapter,
        D3DDEVTYPE DeviceType,
        D3DFORMAT SourceFormat,
        D3DFORMAT TargetFormat
    )
    {
        return (
            (delegate* unmanaged<IDirect3D9, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int>)(
                (*lpVtbl)[13]
            )
        )(this, Adapter, DeviceType, SourceFormat, TargetFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceCaps(uint Adapter, D3DDEVTYPE DeviceType, D3DCAPS9* pCaps)
    {
        return ((delegate* unmanaged<IDirect3D9, uint, D3DDEVTYPE, D3DCAPS9*, int>)((*lpVtbl)[14]))(
            this,
            Adapter,
            DeviceType,
            pCaps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HMONITOR GetAdapterMonitor(uint Adapter)
    {
        return (
            (HMONITOR)(
                ((delegate* unmanaged<IDirect3D9, uint, void*>)((*lpVtbl)[15]))(this, Adapter)
            )
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateDevice(
        uint Adapter,
        D3DDEVTYPE DeviceType,
        HWND hFocusWindow,
        [NativeTypeName("DWORD")] uint BehaviorFlags,
        D3DPRESENT_PARAMETERS* pPresentationParameters,
        IDirect3DDevice9* ppReturnedDeviceInterface
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3D9,
                uint,
                D3DDEVTYPE,
                HWND,
                uint,
                D3DPRESENT_PARAMETERS*,
                IDirect3DDevice9*,
                int>)((*lpVtbl)[16])
        )(
            this,
            Adapter,
            DeviceType,
            hFocusWindow,
            BehaviorFlags,
            pPresentationParameters,
            ppReturnedDeviceInterface
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterSoftwareDevice(void* pInitializeFunction);

        [VtblIndex(4)]
        uint GetAdapterCount();

        [VtblIndex(5)]
        HRESULT GetAdapterIdentifier(
            uint Adapter,
            [NativeTypeName("DWORD")] uint Flags,
            D3DADAPTER_IDENTIFIER9* pIdentifier
        );

        [VtblIndex(6)]
        uint GetAdapterModeCount(uint Adapter, D3DFORMAT Format);

        [VtblIndex(7)]
        HRESULT EnumAdapterModes(uint Adapter, D3DFORMAT Format, uint Mode, D3DDISPLAYMODE* pMode);

        [VtblIndex(8)]
        HRESULT GetAdapterDisplayMode(uint Adapter, D3DDISPLAYMODE* pMode);

        [VtblIndex(9)]
        HRESULT CheckDeviceType(
            uint Adapter,
            D3DDEVTYPE DevType,
            D3DFORMAT AdapterFormat,
            D3DFORMAT BackBufferFormat,
            BOOL bWindowed
        );

        [VtblIndex(10)]
        HRESULT CheckDeviceFormat(
            uint Adapter,
            D3DDEVTYPE DeviceType,
            D3DFORMAT AdapterFormat,
            [NativeTypeName("DWORD")] uint Usage,
            D3DRESOURCETYPE RType,
            D3DFORMAT CheckFormat
        );

        [VtblIndex(11)]
        HRESULT CheckDeviceMultiSampleType(
            uint Adapter,
            D3DDEVTYPE DeviceType,
            D3DFORMAT SurfaceFormat,
            BOOL Windowed,
            D3DMULTISAMPLE_TYPE MultiSampleType,
            [NativeTypeName("DWORD *")] uint* pQualityLevels
        );

        [VtblIndex(12)]
        HRESULT CheckDepthStencilMatch(
            uint Adapter,
            D3DDEVTYPE DeviceType,
            D3DFORMAT AdapterFormat,
            D3DFORMAT RenderTargetFormat,
            D3DFORMAT DepthStencilFormat
        );

        [VtblIndex(13)]
        HRESULT CheckDeviceFormatConversion(
            uint Adapter,
            D3DDEVTYPE DeviceType,
            D3DFORMAT SourceFormat,
            D3DFORMAT TargetFormat
        );

        [VtblIndex(14)]
        HRESULT GetDeviceCaps(uint Adapter, D3DDEVTYPE DeviceType, D3DCAPS9* pCaps);

        [VtblIndex(15)]
        HMONITOR GetAdapterMonitor(uint Adapter);

        [VtblIndex(16)]
        HRESULT CreateDevice(
            uint Adapter,
            D3DDEVTYPE DeviceType,
            HWND hFocusWindow,
            [NativeTypeName("DWORD")] uint BehaviorFlags,
            D3DPRESENT_PARAMETERS* pPresentationParameters,
            IDirect3DDevice9* ppReturnedDeviceInterface
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

        [NativeTypeName("HRESULT (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> RegisterSoftwareDevice;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetAdapterCount;

        [NativeTypeName(
            "HRESULT (UINT, DWORD, D3DADAPTER_IDENTIFIER9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DADAPTER_IDENTIFIER9*,
            int> GetAdapterIdentifier;

        [NativeTypeName("UINT (UINT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3DFORMAT, uint> GetAdapterModeCount;

        [NativeTypeName(
            "HRESULT (UINT, D3DFORMAT, UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DFORMAT,
            uint,
            D3DDISPLAYMODE*,
            int> EnumAdapterModes;

        [NativeTypeName(
            "HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DDISPLAYMODE*, int> GetAdapterDisplayMode;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            D3DFORMAT,
            D3DFORMAT,
            BOOL,
            int> CheckDeviceType;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, DWORD, D3DRESOURCETYPE, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            D3DFORMAT,
            uint,
            D3DRESOURCETYPE,
            D3DFORMAT,
            int> CheckDeviceFormat;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, BOOL, D3DMULTISAMPLE_TYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            D3DFORMAT,
            BOOL,
            D3DMULTISAMPLE_TYPE,
            uint*,
            int> CheckDeviceMultiSampleType;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            D3DFORMAT,
            D3DFORMAT,
            D3DFORMAT,
            int> CheckDepthStencilMatch;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            D3DFORMAT,
            D3DFORMAT,
            int> CheckDeviceFormatConversion;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DDEVTYPE, D3DCAPS9*, int> GetDeviceCaps;

        [NativeTypeName("HMONITOR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*> GetAdapterMonitor;

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, HWND, DWORD, D3DPRESENT_PARAMETERS *, IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            HWND,
            uint,
            D3DPRESENT_PARAMETERS*,
            IDirect3DDevice9*,
            int> CreateDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3D9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3D9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3D9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3D9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3D9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3D9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3D9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
