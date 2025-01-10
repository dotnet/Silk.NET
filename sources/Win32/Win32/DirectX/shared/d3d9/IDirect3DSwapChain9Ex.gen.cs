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

[Guid("91886CAF-1C3D-4D2E-A0AB-3E4C7D8D3303")]
[NativeTypeName("struct IDirect3DSwapChain9Ex : IDirect3DSwapChain9")]
[NativeInheritance("IDirect3DSwapChain9")]
public unsafe partial struct IDirect3DSwapChain9Ex : IDirect3DSwapChain9Ex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DSwapChain9Ex));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Present(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestRect,
        HWND hDestWindowOverride,
        [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IDirect3DSwapChain9Ex, RECT*, RECT*, HWND, RGNDATA*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, IDirect3DSurface9, int>)((*lpVtbl)[4]))(
            this,
            pDestSurface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBackBuffer(
        uint iBackBuffer,
        D3DBACKBUFFER_TYPE Type,
        IDirect3DSurface9* ppBackBuffer
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DSwapChain9Ex,
                uint,
                D3DBACKBUFFER_TYPE,
                IDirect3DSurface9*,
                int>)((*lpVtbl)[5])
        )(this, iBackBuffer, Type, ppBackBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRasterStatus(D3DRASTER_STATUS* pRasterStatus)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, D3DRASTER_STATUS*, int>)((*lpVtbl)[6]))(
            this,
            pRasterStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayMode(D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, D3DDISPLAYMODE*, int>)((*lpVtbl)[7]))(
            this,
            pMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDevice(IDirect3DDevice9* ppDevice)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, IDirect3DDevice9*, int>)((*lpVtbl)[8]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters)
    {
        return (
            (delegate* unmanaged<IDirect3DSwapChain9Ex, D3DPRESENT_PARAMETERS*, int>)((*lpVtbl)[9])
        )(this, pPresentationParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetLastPresentCount(uint* pLastPresentCount)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, uint*, int>)((*lpVtbl)[10]))(
            this,
            pLastPresentCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPresentStats(D3DPRESENTSTATS* pPresentationStatistics)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9Ex, D3DPRESENTSTATS*, int>)((*lpVtbl)[11]))(
            this,
            pPresentationStatistics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDisplayModeEx(D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation)
    {
        return (
            (delegate* unmanaged<
                IDirect3DSwapChain9Ex,
                D3DDISPLAYMODEEX*,
                D3DDISPLAYROTATION*,
                int>)((*lpVtbl)[12])
        )(this, pMode, pRotation);
    }

    public interface Interface : IDirect3DSwapChain9.Interface
    {
        [VtblIndex(10)]
        HRESULT GetLastPresentCount(uint* pLastPresentCount);

        [VtblIndex(11)]
        HRESULT GetPresentStats(D3DPRESENTSTATS* pPresentationStatistics);

        [VtblIndex(12)]
        HRESULT GetDisplayModeEx(D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation);
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

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, HWND, RGNDATA*, uint, int> Present;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface9, int> GetFrontBufferData;

        [NativeTypeName(
            "HRESULT (UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DBACKBUFFER_TYPE,
            IDirect3DSurface9*,
            int> GetBackBuffer;

        [NativeTypeName(
            "HRESULT (D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DRASTER_STATUS*, int> GetRasterStatus;

        [NativeTypeName(
            "HRESULT (D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DDISPLAYMODE*, int> GetDisplayMode;

        [NativeTypeName(
            "HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DDevice9*, int> GetDevice;

        [NativeTypeName(
            "HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DPRESENT_PARAMETERS*, int> GetPresentParameters;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLastPresentCount;

        [NativeTypeName(
            "HRESULT (D3DPRESENTSTATS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DPRESENTSTATS*, int> GetPresentStats;

        [NativeTypeName(
            "HRESULT (D3DDISPLAYMODEEX *, D3DDISPLAYROTATION *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DDISPLAYMODEEX*,
            D3DDISPLAYROTATION*,
            int> GetDisplayModeEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DSwapChain9Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DSwapChain9Ex(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirect3DSwapChain9"/> to <see cref = "IDirect3DSwapChain9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirect3DSwapChain9"/> instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9Ex(
        Silk.NET.DirectX.IDirect3DSwapChain9 value
    )
    {
        return new IDirect3DSwapChain9Ex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DSwapChain9Ex"/> to <see cref = "Silk.NET.DirectX.IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9Ex"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirect3DSwapChain9(
        IDirect3DSwapChain9Ex value
    )
    {
        return new Silk.NET.DirectX.IDirect3DSwapChain9(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DSwapChain9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9Ex(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DSwapChain9Ex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DSwapChain9Ex"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9Ex"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DSwapChain9Ex value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
