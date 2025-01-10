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

[Guid("794950F2-ADFC-458A-905E-10A10B0B503B")]
[NativeTypeName("struct IDirect3DSwapChain9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DSwapChain9 : IDirect3DSwapChain9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DSwapChain9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DSwapChain9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IDirect3DSwapChain9, RECT*, RECT*, HWND, RGNDATA*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9, IDirect3DSurface9, int>)((*lpVtbl)[4]))(
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
                IDirect3DSwapChain9,
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
        return ((delegate* unmanaged<IDirect3DSwapChain9, D3DRASTER_STATUS*, int>)((*lpVtbl)[6]))(
            this,
            pRasterStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayMode(D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9, D3DDISPLAYMODE*, int>)((*lpVtbl)[7]))(
            this,
            pMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDevice(IDirect3DDevice9* ppDevice)
    {
        return ((delegate* unmanaged<IDirect3DSwapChain9, IDirect3DDevice9*, int>)((*lpVtbl)[8]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters)
    {
        return (
            (delegate* unmanaged<IDirect3DSwapChain9, D3DPRESENT_PARAMETERS*, int>)((*lpVtbl)[9])
        )(this, pPresentationParameters);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Present(
            [NativeTypeName("const RECT *")] RECT* pSourceRect,
            [NativeTypeName("const RECT *")] RECT* pDestRect,
            HWND hDestWindowOverride,
            [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(4)]
        HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface);

        [VtblIndex(5)]
        HRESULT GetBackBuffer(
            uint iBackBuffer,
            D3DBACKBUFFER_TYPE Type,
            IDirect3DSurface9* ppBackBuffer
        );

        [VtblIndex(6)]
        HRESULT GetRasterStatus(D3DRASTER_STATUS* pRasterStatus);

        [VtblIndex(7)]
        HRESULT GetDisplayMode(D3DDISPLAYMODE* pMode);

        [VtblIndex(8)]
        HRESULT GetDevice(IDirect3DDevice9* ppDevice);

        [VtblIndex(9)]
        HRESULT GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DSwapChain9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DSwapChain9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DSwapChain9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DSwapChain9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DSwapChain9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
