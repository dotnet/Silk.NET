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

[Guid("B18B10CE-2649-405A-870F-95F777D4313A")]
[NativeTypeName("struct IDirect3DDevice9Ex : IDirect3DDevice9")]
[NativeInheritance("IDirect3DDevice9")]
public unsafe partial struct IDirect3DDevice9Ex : IDirect3DDevice9Ex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DDevice9Ex));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TestCooperativeLevel()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetAvailableTextureMem()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EvictManagedResources()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDirect3D(IDirect3D9* ppD3D9)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, IDirect3D9*, int>)((*lpVtbl)[6]))(
            this,
            ppD3D9
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceCaps(D3DCAPS9* pCaps)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DCAPS9*, int>)((*lpVtbl)[7]))(
            this,
            pCaps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayMode(uint iSwapChain, D3DDISPLAYMODE* pMode)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DDISPLAYMODE*, int>)((*lpVtbl)[8])
        )(this, iSwapChain, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCreationParameters(D3DDEVICE_CREATION_PARAMETERS* pParameters)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DDEVICE_CREATION_PARAMETERS*, int>)(
                (*lpVtbl)[9]
            )
        )(this, pParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCursorProperties(
        uint XHotSpot,
        uint YHotSpot,
        IDirect3DSurface9 pCursorBitmap
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, uint, IDirect3DSurface9, int>)(
                (*lpVtbl)[10]
            )
        )(this, XHotSpot, YHotSpot, pCursorBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags)
    {
        ((delegate* unmanaged<IDirect3DDevice9Ex, int, int, uint, void>)((*lpVtbl)[11]))(
            this,
            X,
            Y,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL ShowCursor(BOOL bShow)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, BOOL, int>)((*lpVtbl)[12]))(this, bShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateAdditionalSwapChain(
        D3DPRESENT_PARAMETERS* pPresentationParameters,
        IDirect3DSwapChain9* pSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DPRESENT_PARAMETERS*,
                IDirect3DSwapChain9*,
                int>)((*lpVtbl)[13])
        )(this, pPresentationParameters, pSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSwapChain(uint iSwapChain, IDirect3DSwapChain9* pSwapChain)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, IDirect3DSwapChain9*, int>)(
                (*lpVtbl)[14]
            )
        )(this, iSwapChain, pSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetNumberOfSwapChains()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Reset(D3DPRESENT_PARAMETERS* pPresentationParameters)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DPRESENT_PARAMETERS*, int>)((*lpVtbl)[16])
        )(this, pPresentationParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Present(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestRect,
        HWND hDestWindowOverride,
        [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, RECT*, RECT*, HWND, RGNDATA*, int>)(
                (*lpVtbl)[17]
            )
        )(this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBackBuffer(
        uint iSwapChain,
        uint iBackBuffer,
        D3DBACKBUFFER_TYPE Type,
        IDirect3DSurface9* ppBackBuffer
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DBACKBUFFER_TYPE,
                IDirect3DSurface9*,
                int>)((*lpVtbl)[18])
        )(this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetRasterStatus(uint iSwapChain, D3DRASTER_STATUS* pRasterStatus)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DRASTER_STATUS*, int>)((*lpVtbl)[19])
        )(this, iSwapChain, pRasterStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetDialogBoxMode(BOOL bEnableDialogs)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, BOOL, int>)((*lpVtbl)[20]))(
            this,
            bEnableDialogs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void SetGammaRamp(
        uint iSwapChain,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("const D3DGAMMARAMP *")] D3DGAMMARAMP* pRamp
    )
    {
        ((delegate* unmanaged<IDirect3DDevice9Ex, uint, uint, D3DGAMMARAMP*, void>)((*lpVtbl)[21]))(
            this,
            iSwapChain,
            Flags,
            pRamp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void GetGammaRamp(uint iSwapChain, D3DGAMMARAMP* pRamp)
    {
        ((delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DGAMMARAMP*, void>)((*lpVtbl)[22]))(
            this,
            iSwapChain,
            pRamp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateTexture(
        uint Width,
        uint Height,
        uint Levels,
        [NativeTypeName("DWORD")] uint Usage,
        D3DFORMAT Format,
        D3DPOOL Pool,
        IDirect3DTexture9* ppTexture,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                uint,
                uint,
                D3DFORMAT,
                D3DPOOL,
                IDirect3DTexture9*,
                HANDLE*,
                int>)((*lpVtbl)[23])
        )(this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateVolumeTexture(
        uint Width,
        uint Height,
        uint Depth,
        uint Levels,
        [NativeTypeName("DWORD")] uint Usage,
        D3DFORMAT Format,
        D3DPOOL Pool,
        IDirect3DVolumeTexture9* ppVolumeTexture,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                uint,
                uint,
                uint,
                D3DFORMAT,
                D3DPOOL,
                IDirect3DVolumeTexture9*,
                HANDLE*,
                int>)((*lpVtbl)[24])
        )(this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateCubeTexture(
        uint EdgeLength,
        uint Levels,
        [NativeTypeName("DWORD")] uint Usage,
        D3DFORMAT Format,
        D3DPOOL Pool,
        IDirect3DCubeTexture9* ppCubeTexture,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                uint,
                D3DFORMAT,
                D3DPOOL,
                IDirect3DCubeTexture9*,
                HANDLE*,
                int>)((*lpVtbl)[25])
        )(this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateVertexBuffer(
        uint Length,
        [NativeTypeName("DWORD")] uint Usage,
        [NativeTypeName("DWORD")] uint FVF,
        D3DPOOL Pool,
        IDirect3DVertexBuffer9* ppVertexBuffer,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                uint,
                D3DPOOL,
                IDirect3DVertexBuffer9*,
                HANDLE*,
                int>)((*lpVtbl)[26])
        )(this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateIndexBuffer(
        uint Length,
        [NativeTypeName("DWORD")] uint Usage,
        D3DFORMAT Format,
        D3DPOOL Pool,
        IDirect3DIndexBuffer9* ppIndexBuffer,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DPOOL,
                IDirect3DIndexBuffer9*,
                HANDLE*,
                int>)((*lpVtbl)[27])
        )(this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateRenderTarget(
        uint Width,
        uint Height,
        D3DFORMAT Format,
        D3DMULTISAMPLE_TYPE MultiSample,
        [NativeTypeName("DWORD")] uint MultisampleQuality,
        BOOL Lockable,
        IDirect3DSurface9* ppSurface,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DMULTISAMPLE_TYPE,
                uint,
                BOOL,
                IDirect3DSurface9*,
                HANDLE*,
                int>)((*lpVtbl)[28])
        )(
            this,
            Width,
            Height,
            Format,
            MultiSample,
            MultisampleQuality,
            Lockable,
            ppSurface,
            pSharedHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateDepthStencilSurface(
        uint Width,
        uint Height,
        D3DFORMAT Format,
        D3DMULTISAMPLE_TYPE MultiSample,
        [NativeTypeName("DWORD")] uint MultisampleQuality,
        BOOL Discard,
        IDirect3DSurface9* ppSurface,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DMULTISAMPLE_TYPE,
                uint,
                BOOL,
                IDirect3DSurface9*,
                HANDLE*,
                int>)((*lpVtbl)[29])
        )(
            this,
            Width,
            Height,
            Format,
            MultiSample,
            MultisampleQuality,
            Discard,
            ppSurface,
            pSharedHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT UpdateSurface(
        IDirect3DSurface9 pSourceSurface,
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        IDirect3DSurface9 pDestinationSurface,
        [NativeTypeName("const POINT *")] POINT* pDestPoint
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                IDirect3DSurface9,
                RECT*,
                IDirect3DSurface9,
                POINT*,
                int>)((*lpVtbl)[30])
        )(this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT UpdateTexture(
        IDirect3DBaseTexture9 pSourceTexture,
        IDirect3DBaseTexture9 pDestinationTexture
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                IDirect3DBaseTexture9,
                IDirect3DBaseTexture9,
                int>)((*lpVtbl)[31])
        )(this, pSourceTexture, pDestinationTexture);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetRenderTargetData(
        IDirect3DSurface9 pRenderTarget,
        IDirect3DSurface9 pDestSurface
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DSurface9, IDirect3DSurface9, int>)(
                (*lpVtbl)[32]
            )
        )(this, pRenderTarget, pDestSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetFrontBufferData(uint iSwapChain, IDirect3DSurface9 pDestSurface)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, IDirect3DSurface9, int>)((*lpVtbl)[33])
        )(this, iSwapChain, pDestSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT StretchRect(
        IDirect3DSurface9 pSourceSurface,
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        IDirect3DSurface9 pDestSurface,
        [NativeTypeName("const RECT *")] RECT* pDestRect,
        D3DTEXTUREFILTERTYPE Filter
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                IDirect3DSurface9,
                RECT*,
                IDirect3DSurface9,
                RECT*,
                D3DTEXTUREFILTERTYPE,
                int>)((*lpVtbl)[34])
        )(this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT ColorFill(
        IDirect3DSurface9 pSurface,
        [NativeTypeName("const RECT *")] RECT* pRect,
        [NativeTypeName("D3DCOLOR")] uint color
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DSurface9, RECT*, uint, int>)(
                (*lpVtbl)[35]
            )
        )(this, pSurface, pRect, color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateOffscreenPlainSurface(
        uint Width,
        uint Height,
        D3DFORMAT Format,
        D3DPOOL Pool,
        IDirect3DSurface9* ppSurface,
        HANDLE* pSharedHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DPOOL,
                IDirect3DSurface9*,
                HANDLE*,
                int>)((*lpVtbl)[36])
        )(this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetRenderTarget(
        [NativeTypeName("DWORD")] uint RenderTargetIndex,
        IDirect3DSurface9 pRenderTarget
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, IDirect3DSurface9, int>)((*lpVtbl)[37])
        )(this, RenderTargetIndex, pRenderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetRenderTarget(
        [NativeTypeName("DWORD")] uint RenderTargetIndex,
        IDirect3DSurface9* ppRenderTarget
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, IDirect3DSurface9*, int>)((*lpVtbl)[38])
        )(this, RenderTargetIndex, ppRenderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetDepthStencilSurface(IDirect3DSurface9 pNewZStencil)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DSurface9, int>)((*lpVtbl)[39]))(
            this,
            pNewZStencil
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetDepthStencilSurface(IDirect3DSurface9* ppZStencilSurface)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DSurface9*, int>)((*lpVtbl)[40]))(
            this,
            ppZStencilSurface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT BeginScene()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int>)((*lpVtbl)[41]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT EndScene()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int>)((*lpVtbl)[42]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT Clear(
        [NativeTypeName("DWORD")] uint Count,
        [NativeTypeName("const D3DRECT *")] D3DRECT* pRects,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("D3DCOLOR")] uint Color,
        float Z,
        [NativeTypeName("DWORD")] uint Stencil
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DRECT*, uint, uint, float, uint, int>)(
                (*lpVtbl)[43]
            )
        )(this, Count, pRects, Flags, Color, Z, Stencil);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT SetTransform(
        D3DTRANSFORMSTATETYPE State,
        [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DTRANSFORMSTATETYPE,
                D2D_MATRIX_4X4_F*,
                int>)((*lpVtbl)[44])
        )(this, State, pMatrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT GetTransform(
        D3DTRANSFORMSTATETYPE State,
        [NativeTypeName("D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DTRANSFORMSTATETYPE,
                D2D_MATRIX_4X4_F*,
                int>)((*lpVtbl)[45])
        )(this, State, pMatrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT MultiplyTransform(
        D3DTRANSFORMSTATETYPE param0,
        [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* param1
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DTRANSFORMSTATETYPE,
                D2D_MATRIX_4X4_F*,
                int>)((*lpVtbl)[46])
        )(this, param0, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3DVIEWPORT9* pViewport)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DVIEWPORT9*, int>)((*lpVtbl)[47]))(
            this,
            pViewport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetViewport(D3DVIEWPORT9* pViewport)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DVIEWPORT9*, int>)((*lpVtbl)[48]))(
            this,
            pViewport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3DMATERIAL9* pMaterial)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DMATERIAL9*, int>)((*lpVtbl)[49]))(
            this,
            pMaterial
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT GetMaterial(D3DMATERIAL9* pMaterial)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DMATERIAL9*, int>)((*lpVtbl)[50]))(
            this,
            pMaterial
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT SetLight(
        [NativeTypeName("DWORD")] uint Index,
        [NativeTypeName("const D3DLIGHT9 *")] D3DLIGHT9* param1
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DLIGHT9*, int>)((*lpVtbl)[51]))(
            this,
            Index,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT GetLight([NativeTypeName("DWORD")] uint Index, D3DLIGHT9* param1)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DLIGHT9*, int>)((*lpVtbl)[52]))(
            this,
            Index,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT LightEnable([NativeTypeName("DWORD")] uint Index, BOOL Enable)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, BOOL, int>)((*lpVtbl)[53]))(
            this,
            Index,
            Enable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetLightEnable([NativeTypeName("DWORD")] uint Index, BOOL* pEnable)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, BOOL*, int>)((*lpVtbl)[54]))(
            this,
            Index,
            pEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT SetClipPlane(
        [NativeTypeName("DWORD")] uint Index,
        [NativeTypeName("const float *")] float* pPlane
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, int>)((*lpVtbl)[55]))(
            this,
            Index,
            pPlane
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, int>)((*lpVtbl)[56]))(
            this,
            Index,
            pPlane
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT SetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD")] uint Value)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DRENDERSTATETYPE, uint, int>)((*lpVtbl)[57])
        )(this, State, Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT GetRenderState(
        D3DRENDERSTATETYPE State,
        [NativeTypeName("DWORD *")] uint* pValue
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DRENDERSTATETYPE, uint*, int>)((*lpVtbl)[58])
        )(this, State, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT CreateStateBlock(D3DSTATEBLOCKTYPE Type, IDirect3DStateBlock9* ppSB)
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DSTATEBLOCKTYPE,
                IDirect3DStateBlock9*,
                int>)((*lpVtbl)[59])
        )(this, Type, ppSB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT BeginStateBlock()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int>)((*lpVtbl)[60]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT EndStateBlock(IDirect3DStateBlock9* ppSB)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DStateBlock9*, int>)((*lpVtbl)[61])
        )(this, ppSB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT SetClipStatus(
        [NativeTypeName("const D3DCLIPSTATUS9 *")] D3DCLIPSTATUS9* pClipStatus
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DCLIPSTATUS9*, int>)((*lpVtbl)[62]))(
            this,
            pClipStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT GetClipStatus(D3DCLIPSTATUS9* pClipStatus)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, D3DCLIPSTATUS9*, int>)((*lpVtbl)[63]))(
            this,
            pClipStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT GetTexture(
        [NativeTypeName("DWORD")] uint Stage,
        IDirect3DBaseTexture9* ppTexture
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, IDirect3DBaseTexture9*, int>)(
                (*lpVtbl)[64]
            )
        )(this, Stage, ppTexture);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT SetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9 pTexture)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, IDirect3DBaseTexture9, int>)(
                (*lpVtbl)[65]
            )
        )(this, Stage, pTexture);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT GetTextureStageState(
        [NativeTypeName("DWORD")] uint Stage,
        D3DTEXTURESTAGESTATETYPE Type,
        [NativeTypeName("DWORD *")] uint* pValue
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DTEXTURESTAGESTATETYPE, uint*, int>)(
                (*lpVtbl)[66]
            )
        )(this, Stage, Type, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT SetTextureStageState(
        [NativeTypeName("DWORD")] uint Stage,
        D3DTEXTURESTAGESTATETYPE Type,
        [NativeTypeName("DWORD")] uint Value
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DTEXTURESTAGESTATETYPE, uint, int>)(
                (*lpVtbl)[67]
            )
        )(this, Stage, Type, Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT GetSamplerState(
        [NativeTypeName("DWORD")] uint Sampler,
        D3DSAMPLERSTATETYPE Type,
        [NativeTypeName("DWORD *")] uint* pValue
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DSAMPLERSTATETYPE, uint*, int>)(
                (*lpVtbl)[68]
            )
        )(this, Sampler, Type, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT SetSamplerState(
        [NativeTypeName("DWORD")] uint Sampler,
        D3DSAMPLERSTATETYPE Type,
        [NativeTypeName("DWORD")] uint Value
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, D3DSAMPLERSTATETYPE, uint, int>)(
                (*lpVtbl)[69]
            )
        )(this, Sampler, Type, Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint*, int>)((*lpVtbl)[70]))(
            this,
            pNumPasses
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT SetPaletteEntries(
        uint PaletteNumber,
        [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, PALETTEENTRY*, int>)((*lpVtbl)[71]))(
            this,
            PaletteNumber,
            pEntries
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT GetPaletteEntries(uint PaletteNumber, PALETTEENTRY* pEntries)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, PALETTEENTRY*, int>)((*lpVtbl)[72]))(
            this,
            PaletteNumber,
            pEntries
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT SetCurrentTexturePalette(uint PaletteNumber)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int>)((*lpVtbl)[73]))(
            this,
            PaletteNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT GetCurrentTexturePalette(uint* PaletteNumber)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint*, int>)((*lpVtbl)[74]))(
            this,
            PaletteNumber
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, RECT*, int>)((*lpVtbl)[75]))(this, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT GetScissorRect(RECT* pRect)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, RECT*, int>)((*lpVtbl)[76]))(this, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT SetSoftwareVertexProcessing(BOOL bSoftware)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, BOOL, int>)((*lpVtbl)[77]))(
            this,
            bSoftware
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public BOOL GetSoftwareVertexProcessing()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int>)((*lpVtbl)[78]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT SetNPatchMode(float nSegments)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, float, int>)((*lpVtbl)[79]))(
            this,
            nSegments
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public float GetNPatchMode()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, float>)((*lpVtbl)[80]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT DrawPrimitive(
        D3DPRIMITIVETYPE PrimitiveType,
        uint StartVertex,
        uint PrimitiveCount
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DPRIMITIVETYPE, uint, uint, int>)(
                (*lpVtbl)[81]
            )
        )(this, PrimitiveType, StartVertex, PrimitiveCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT DrawIndexedPrimitive(
        D3DPRIMITIVETYPE param0,
        int BaseVertexIndex,
        uint MinVertexIndex,
        uint NumVertices,
        uint startIndex,
        uint primCount
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DPRIMITIVETYPE,
                int,
                uint,
                uint,
                uint,
                uint,
                int>)((*lpVtbl)[82])
        )(this, param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT DrawPrimitiveUP(
        D3DPRIMITIVETYPE PrimitiveType,
        uint PrimitiveCount,
        [NativeTypeName("const void *")] void* pVertexStreamZeroData,
        uint VertexStreamZeroStride
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DPRIMITIVETYPE, uint, void*, uint, int>)(
                (*lpVtbl)[83]
            )
        )(this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT DrawIndexedPrimitiveUP(
        D3DPRIMITIVETYPE PrimitiveType,
        uint MinVertexIndex,
        uint NumVertices,
        uint PrimitiveCount,
        [NativeTypeName("const void *")] void* pIndexData,
        D3DFORMAT IndexDataFormat,
        [NativeTypeName("const void *")] void* pVertexStreamZeroData,
        uint VertexStreamZeroStride
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DPRIMITIVETYPE,
                uint,
                uint,
                uint,
                void*,
                D3DFORMAT,
                void*,
                uint,
                int>)((*lpVtbl)[84])
        )(
            this,
            PrimitiveType,
            MinVertexIndex,
            NumVertices,
            PrimitiveCount,
            pIndexData,
            IndexDataFormat,
            pVertexStreamZeroData,
            VertexStreamZeroStride
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT ProcessVertices(
        uint SrcStartIndex,
        uint DestIndex,
        uint VertexCount,
        IDirect3DVertexBuffer9 pDestBuffer,
        IDirect3DVertexDeclaration9 pVertexDecl,
        [NativeTypeName("DWORD")] uint Flags
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                uint,
                IDirect3DVertexBuffer9,
                IDirect3DVertexDeclaration9,
                uint,
                int>)((*lpVtbl)[85])
        )(this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT CreateVertexDeclaration(
        [NativeTypeName("const D3DVERTEXELEMENT9 *")] D3DVERTEXELEMENT9* pVertexElements,
        IDirect3DVertexDeclaration9* ppDecl
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DVERTEXELEMENT9*,
                IDirect3DVertexDeclaration9*,
                int>)((*lpVtbl)[86])
        )(this, pVertexElements, ppDecl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT SetVertexDeclaration(IDirect3DVertexDeclaration9 pDecl)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DVertexDeclaration9, int>)(
                (*lpVtbl)[87]
            )
        )(this, pDecl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT GetVertexDeclaration(IDirect3DVertexDeclaration9* ppDecl)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DVertexDeclaration9*, int>)(
                (*lpVtbl)[88]
            )
        )(this, ppDecl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT SetFVF([NativeTypeName("DWORD")] uint FVF)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int>)((*lpVtbl)[89]))(this, FVF);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT GetFVF([NativeTypeName("DWORD *")] uint* pFVF)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint*, int>)((*lpVtbl)[90]))(this, pFVF);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT CreateVertexShader(
        [NativeTypeName("const DWORD *")] uint* pFunction,
        IDirect3DVertexShader9* ppShader
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint*, IDirect3DVertexShader9*, int>)(
                (*lpVtbl)[91]
            )
        )(this, pFunction, ppShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT SetVertexShader(IDirect3DVertexShader9 pShader)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DVertexShader9, int>)((*lpVtbl)[92])
        )(this, pShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT GetVertexShader(IDirect3DVertexShader9* ppShader)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DVertexShader9*, int>)((*lpVtbl)[93])
        )(this, ppShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT SetVertexShaderConstantF(
        uint StartRegister,
        [NativeTypeName("const float *")] float* pConstantData,
        uint Vector4fCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, uint, int>)((*lpVtbl)[94]))(
            this,
            StartRegister,
            pConstantData,
            Vector4fCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT GetVertexShaderConstantF(
        uint StartRegister,
        float* pConstantData,
        uint Vector4fCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, uint, int>)((*lpVtbl)[95]))(
            this,
            StartRegister,
            pConstantData,
            Vector4fCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT SetVertexShaderConstantI(
        uint StartRegister,
        [NativeTypeName("const int *")] int* pConstantData,
        uint Vector4iCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int*, uint, int>)((*lpVtbl)[96]))(
            this,
            StartRegister,
            pConstantData,
            Vector4iCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT GetVertexShaderConstantI(
        uint StartRegister,
        int* pConstantData,
        uint Vector4iCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int*, uint, int>)((*lpVtbl)[97]))(
            this,
            StartRegister,
            pConstantData,
            Vector4iCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT SetVertexShaderConstantB(
        uint StartRegister,
        [NativeTypeName("const BOOL *")] BOOL* pConstantData,
        uint BoolCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, BOOL*, uint, int>)((*lpVtbl)[98]))(
            this,
            StartRegister,
            pConstantData,
            BoolCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT GetVertexShaderConstantB(uint StartRegister, BOOL* pConstantData, uint BoolCount)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, BOOL*, uint, int>)((*lpVtbl)[99]))(
            this,
            StartRegister,
            pConstantData,
            BoolCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT SetStreamSource(
        uint StreamNumber,
        IDirect3DVertexBuffer9 pStreamData,
        uint OffsetInBytes,
        uint Stride
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                IDirect3DVertexBuffer9,
                uint,
                uint,
                int>)((*lpVtbl)[100])
        )(this, StreamNumber, pStreamData, OffsetInBytes, Stride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT GetStreamSource(
        uint StreamNumber,
        IDirect3DVertexBuffer9* ppStreamData,
        uint* pOffsetInBytes,
        uint* pStride
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                IDirect3DVertexBuffer9*,
                uint*,
                uint*,
                int>)((*lpVtbl)[101])
        )(this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT SetStreamSourceFreq(uint StreamNumber, uint Setting)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, uint, int>)((*lpVtbl)[102]))(
            this,
            StreamNumber,
            Setting
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, uint*, int>)((*lpVtbl)[103]))(
            this,
            StreamNumber,
            pSetting
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT SetIndices(IDirect3DIndexBuffer9 pIndexData)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DIndexBuffer9, int>)((*lpVtbl)[104])
        )(this, pIndexData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT GetIndices(IDirect3DIndexBuffer9* ppIndexData)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DIndexBuffer9*, int>)((*lpVtbl)[105])
        )(this, ppIndexData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT CreatePixelShader(
        [NativeTypeName("const DWORD *")] uint* pFunction,
        IDirect3DPixelShader9* ppShader
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint*, IDirect3DPixelShader9*, int>)(
                (*lpVtbl)[106]
            )
        )(this, pFunction, ppShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT SetPixelShader(IDirect3DPixelShader9 pShader)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DPixelShader9, int>)((*lpVtbl)[107])
        )(this, pShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT GetPixelShader(IDirect3DPixelShader9* ppShader)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DPixelShader9*, int>)((*lpVtbl)[108])
        )(this, ppShader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT SetPixelShaderConstantF(
        uint StartRegister,
        [NativeTypeName("const float *")] float* pConstantData,
        uint Vector4fCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, uint, int>)((*lpVtbl)[109]))(
            this,
            StartRegister,
            pConstantData,
            Vector4fCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT GetPixelShaderConstantF(
        uint StartRegister,
        float* pConstantData,
        uint Vector4fCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, uint, int>)((*lpVtbl)[110]))(
            this,
            StartRegister,
            pConstantData,
            Vector4fCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT SetPixelShaderConstantI(
        uint StartRegister,
        [NativeTypeName("const int *")] int* pConstantData,
        uint Vector4iCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int*, uint, int>)((*lpVtbl)[111]))(
            this,
            StartRegister,
            pConstantData,
            Vector4iCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT GetPixelShaderConstantI(
        uint StartRegister,
        int* pConstantData,
        uint Vector4iCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int*, uint, int>)((*lpVtbl)[112]))(
            this,
            StartRegister,
            pConstantData,
            Vector4iCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT SetPixelShaderConstantB(
        uint StartRegister,
        [NativeTypeName("const BOOL *")] BOOL* pConstantData,
        uint BoolCount
    )
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, BOOL*, uint, int>)((*lpVtbl)[113]))(
            this,
            StartRegister,
            pConstantData,
            BoolCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT GetPixelShaderConstantB(uint StartRegister, BOOL* pConstantData, uint BoolCount)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, BOOL*, uint, int>)((*lpVtbl)[114]))(
            this,
            StartRegister,
            pConstantData,
            BoolCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT DrawRectPatch(
        uint Handle,
        [NativeTypeName("const float *")] float* pNumSegs,
        [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DRECTPATCH_INFO* pRectPatchInfo
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, D3DRECTPATCH_INFO*, int>)(
                (*lpVtbl)[115]
            )
        )(this, Handle, pNumSegs, pRectPatchInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT DrawTriPatch(
        uint Handle,
        [NativeTypeName("const float *")] float* pNumSegs,
        [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DTRIPATCH_INFO* pTriPatchInfo
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, float*, D3DTRIPATCH_INFO*, int>)(
                (*lpVtbl)[116]
            )
        )(this, Handle, pNumSegs, pTriPatchInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT DeletePatch(uint Handle)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int>)((*lpVtbl)[117]))(this, Handle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT CreateQuery(D3DQUERYTYPE Type, IDirect3DQuery9* ppQuery)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, D3DQUERYTYPE, IDirect3DQuery9*, int>)(
                (*lpVtbl)[118]
            )
        )(this, Type, ppQuery);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT SetConvolutionMonoKernel(uint width, uint height, float* rows, float* columns)
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, uint, uint, float*, float*, int>)(
                (*lpVtbl)[119]
            )
        )(this, width, height, rows, columns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT ComposeRects(
        IDirect3DSurface9 pSrc,
        IDirect3DSurface9 pDst,
        IDirect3DVertexBuffer9 pSrcRectDescs,
        uint NumRects,
        IDirect3DVertexBuffer9 pDstRectDescs,
        D3DCOMPOSERECTSOP Operation,
        int Xoffset,
        int Yoffset
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                IDirect3DSurface9,
                IDirect3DSurface9,
                IDirect3DVertexBuffer9,
                uint,
                IDirect3DVertexBuffer9,
                D3DCOMPOSERECTSOP,
                int,
                int,
                int>)((*lpVtbl)[120])
        )(this, pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT PresentEx(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestRect,
        HWND hDestWindowOverride,
        [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, RECT*, RECT*, HWND, RGNDATA*, uint, int>)(
                (*lpVtbl)[121]
            )
        )(this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT GetGPUThreadPriority(int* pPriority)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int*, int>)((*lpVtbl)[122]))(
            this,
            pPriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT SetGPUThreadPriority(int Priority)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, int, int>)((*lpVtbl)[123]))(
            this,
            Priority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT WaitForVBlank(uint iSwapChain)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int>)((*lpVtbl)[124]))(
            this,
            iSwapChain
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT CheckResourceResidency(
        IDirect3DResource9* pResourceArray,
        [NativeTypeName("UINT32")] uint NumResources
    )
    {
        return (
            (delegate* unmanaged<IDirect3DDevice9Ex, IDirect3DResource9*, uint, int>)(
                (*lpVtbl)[125]
            )
        )(this, pResourceArray, NumResources);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT SetMaximumFrameLatency(uint MaxLatency)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint, int>)((*lpVtbl)[126]))(
            this,
            MaxLatency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT GetMaximumFrameLatency(uint* pMaxLatency)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, uint*, int>)((*lpVtbl)[127]))(
            this,
            pMaxLatency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT CheckDeviceState(HWND hDestinationWindow)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Ex, HWND, int>)((*lpVtbl)[128]))(
            this,
            hDestinationWindow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT CreateRenderTargetEx(
        uint Width,
        uint Height,
        D3DFORMAT Format,
        D3DMULTISAMPLE_TYPE MultiSample,
        [NativeTypeName("DWORD")] uint MultisampleQuality,
        BOOL Lockable,
        IDirect3DSurface9* ppSurface,
        HANDLE* pSharedHandle,
        [NativeTypeName("DWORD")] uint Usage
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DMULTISAMPLE_TYPE,
                uint,
                BOOL,
                IDirect3DSurface9*,
                HANDLE*,
                uint,
                int>)((*lpVtbl)[129])
        )(
            this,
            Width,
            Height,
            Format,
            MultiSample,
            MultisampleQuality,
            Lockable,
            ppSurface,
            pSharedHandle,
            Usage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT CreateOffscreenPlainSurfaceEx(
        uint Width,
        uint Height,
        D3DFORMAT Format,
        D3DPOOL Pool,
        IDirect3DSurface9* ppSurface,
        HANDLE* pSharedHandle,
        [NativeTypeName("DWORD")] uint Usage
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DPOOL,
                IDirect3DSurface9*,
                HANDLE*,
                uint,
                int>)((*lpVtbl)[130])
        )(this, Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT CreateDepthStencilSurfaceEx(
        uint Width,
        uint Height,
        D3DFORMAT Format,
        D3DMULTISAMPLE_TYPE MultiSample,
        [NativeTypeName("DWORD")] uint MultisampleQuality,
        BOOL Discard,
        IDirect3DSurface9* ppSurface,
        HANDLE* pSharedHandle,
        [NativeTypeName("DWORD")] uint Usage
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                uint,
                D3DFORMAT,
                D3DMULTISAMPLE_TYPE,
                uint,
                BOOL,
                IDirect3DSurface9*,
                HANDLE*,
                uint,
                int>)((*lpVtbl)[131])
        )(
            this,
            Width,
            Height,
            Format,
            MultiSample,
            MultisampleQuality,
            Discard,
            ppSurface,
            pSharedHandle,
            Usage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT ResetEx(
        D3DPRESENT_PARAMETERS* pPresentationParameters,
        D3DDISPLAYMODEEX* pFullscreenDisplayMode
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                D3DPRESENT_PARAMETERS*,
                D3DDISPLAYMODEEX*,
                int>)((*lpVtbl)[132])
        )(this, pPresentationParameters, pFullscreenDisplayMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT GetDisplayModeEx(
        uint iSwapChain,
        D3DDISPLAYMODEEX* pMode,
        D3DDISPLAYROTATION* pRotation
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Ex,
                uint,
                D3DDISPLAYMODEEX*,
                D3DDISPLAYROTATION*,
                int>)((*lpVtbl)[133])
        )(this, iSwapChain, pMode, pRotation);
    }

    public interface Interface : IDirect3DDevice9.Interface
    {
        [VtblIndex(119)]
        HRESULT SetConvolutionMonoKernel(uint width, uint height, float* rows, float* columns);

        [VtblIndex(120)]
        HRESULT ComposeRects(
            IDirect3DSurface9 pSrc,
            IDirect3DSurface9 pDst,
            IDirect3DVertexBuffer9 pSrcRectDescs,
            uint NumRects,
            IDirect3DVertexBuffer9 pDstRectDescs,
            D3DCOMPOSERECTSOP Operation,
            int Xoffset,
            int Yoffset
        );

        [VtblIndex(121)]
        HRESULT PresentEx(
            [NativeTypeName("const RECT *")] RECT* pSourceRect,
            [NativeTypeName("const RECT *")] RECT* pDestRect,
            HWND hDestWindowOverride,
            [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(122)]
        HRESULT GetGPUThreadPriority(int* pPriority);

        [VtblIndex(123)]
        HRESULT SetGPUThreadPriority(int Priority);

        [VtblIndex(124)]
        HRESULT WaitForVBlank(uint iSwapChain);

        [VtblIndex(125)]
        HRESULT CheckResourceResidency(
            IDirect3DResource9* pResourceArray,
            [NativeTypeName("UINT32")] uint NumResources
        );

        [VtblIndex(126)]
        HRESULT SetMaximumFrameLatency(uint MaxLatency);

        [VtblIndex(127)]
        HRESULT GetMaximumFrameLatency(uint* pMaxLatency);

        [VtblIndex(128)]
        HRESULT CheckDeviceState(HWND hDestinationWindow);

        [VtblIndex(129)]
        HRESULT CreateRenderTargetEx(
            uint Width,
            uint Height,
            D3DFORMAT Format,
            D3DMULTISAMPLE_TYPE MultiSample,
            [NativeTypeName("DWORD")] uint MultisampleQuality,
            BOOL Lockable,
            IDirect3DSurface9* ppSurface,
            HANDLE* pSharedHandle,
            [NativeTypeName("DWORD")] uint Usage
        );

        [VtblIndex(130)]
        HRESULT CreateOffscreenPlainSurfaceEx(
            uint Width,
            uint Height,
            D3DFORMAT Format,
            D3DPOOL Pool,
            IDirect3DSurface9* ppSurface,
            HANDLE* pSharedHandle,
            [NativeTypeName("DWORD")] uint Usage
        );

        [VtblIndex(131)]
        HRESULT CreateDepthStencilSurfaceEx(
            uint Width,
            uint Height,
            D3DFORMAT Format,
            D3DMULTISAMPLE_TYPE MultiSample,
            [NativeTypeName("DWORD")] uint MultisampleQuality,
            BOOL Discard,
            IDirect3DSurface9* ppSurface,
            HANDLE* pSharedHandle,
            [NativeTypeName("DWORD")] uint Usage
        );

        [VtblIndex(132)]
        HRESULT ResetEx(
            D3DPRESENT_PARAMETERS* pPresentationParameters,
            D3DDISPLAYMODEEX* pFullscreenDisplayMode
        );

        [VtblIndex(133)]
        HRESULT GetDisplayModeEx(
            uint iSwapChain,
            D3DDISPLAYMODEEX* pMode,
            D3DDISPLAYROTATION* pRotation
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TestCooperativeLevel;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetAvailableTextureMem;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EvictManagedResources;

        [NativeTypeName(
            "HRESULT (IDirect3D9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3D9*, int> GetDirect3D;

        [NativeTypeName("HRESULT (D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3DCAPS9*, int> GetDeviceCaps;

        [NativeTypeName(
            "HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DDISPLAYMODE*, int> GetDisplayMode;

        [NativeTypeName(
            "HRESULT (D3DDEVICE_CREATION_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DDEVICE_CREATION_PARAMETERS*,
            int> GetCreationParameters;

        [NativeTypeName(
            "HRESULT (UINT, UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, IDirect3DSurface9, int> SetCursorProperties;

        [NativeTypeName("void (int, int, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, uint, void> SetCursorPosition;

        [NativeTypeName("BOOL (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowCursor;

        [NativeTypeName(
            "HRESULT (D3DPRESENT_PARAMETERS *, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DPRESENT_PARAMETERS*,
            IDirect3DSwapChain9*,
            int> CreateAdditionalSwapChain;

        [NativeTypeName(
            "HRESULT (UINT, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DSwapChain9*, int> GetSwapChain;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNumberOfSwapChains;

        [NativeTypeName(
            "HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DPRESENT_PARAMETERS*, int> Reset;

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, HWND, RGNDATA*, int> Present;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DBACKBUFFER_TYPE,
            IDirect3DSurface9*,
            int> GetBackBuffer;

        [NativeTypeName(
            "HRESULT (UINT, D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DRASTER_STATUS*, int> GetRasterStatus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetDialogBoxMode;

        [NativeTypeName(
            "void (UINT, DWORD, const D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, D3DGAMMARAMP*, void> SetGammaRamp;

        [NativeTypeName(
            "void (UINT, D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DGAMMARAMP*, void> GetGammaRamp;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            uint,
            D3DFORMAT,
            D3DPOOL,
            IDirect3DTexture9*,
            HANDLE*,
            int> CreateTexture;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            uint,
            uint,
            D3DFORMAT,
            D3DPOOL,
            IDirect3DVolumeTexture9*,
            HANDLE*,
            int> CreateVolumeTexture;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            D3DFORMAT,
            D3DPOOL,
            IDirect3DCubeTexture9*,
            HANDLE*,
            int> CreateCubeTexture;

        [NativeTypeName(
            "HRESULT (UINT, DWORD, DWORD, D3DPOOL, IDirect3DVertexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            D3DPOOL,
            IDirect3DVertexBuffer9*,
            HANDLE*,
            int> CreateVertexBuffer;

        [NativeTypeName(
            "HRESULT (UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DPOOL,
            IDirect3DIndexBuffer9*,
            HANDLE*,
            int> CreateIndexBuffer;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DMULTISAMPLE_TYPE,
            uint,
            BOOL,
            IDirect3DSurface9*,
            HANDLE*,
            int> CreateRenderTarget;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DMULTISAMPLE_TYPE,
            uint,
            BOOL,
            IDirect3DSurface9*,
            HANDLE*,
            int> CreateDepthStencilSurface;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const POINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface9,
            RECT*,
            IDirect3DSurface9,
            POINT*,
            int> UpdateSurface;

        [NativeTypeName(
            "HRESULT (IDirect3DBaseTexture9 *, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DBaseTexture9,
            IDirect3DBaseTexture9,
            int> UpdateTexture;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface9,
            IDirect3DSurface9,
            int> GetRenderTargetData;

        [NativeTypeName(
            "HRESULT (UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9, int> GetFrontBufferData;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const RECT *, D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface9,
            RECT*,
            IDirect3DSurface9,
            RECT*,
            D3DTEXTUREFILTERTYPE,
            int> StretchRect;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, const RECT *, D3DCOLOR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface9, RECT*, uint, int> ColorFill;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DFORMAT, D3DPOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DPOOL,
            IDirect3DSurface9*,
            HANDLE*,
            int> CreateOffscreenPlainSurface;

        [NativeTypeName(
            "HRESULT (DWORD, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9, int> SetRenderTarget;

        [NativeTypeName(
            "HRESULT (DWORD, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9*, int> GetRenderTarget;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface9, int> SetDepthStencilSurface;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface9*, int> GetDepthStencilSurface;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginScene;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndScene;

        [NativeTypeName(
            "HRESULT (DWORD, const D3DRECT *, DWORD, D3DCOLOR, float, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DRECT*, uint, uint, float, uint, int> Clear;

        [NativeTypeName(
            "HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DTRANSFORMSTATETYPE,
            D2D_MATRIX_4X4_F*,
            int> SetTransform;

        [NativeTypeName(
            "HRESULT (D3DTRANSFORMSTATETYPE, D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DTRANSFORMSTATETYPE,
            D2D_MATRIX_4X4_F*,
            int> GetTransform;

        [NativeTypeName(
            "HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DTRANSFORMSTATETYPE,
            D2D_MATRIX_4X4_F*,
            int> MultiplyTransform;

        [NativeTypeName(
            "HRESULT (const D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DVIEWPORT9*, int> SetViewport;

        [NativeTypeName(
            "HRESULT (D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DVIEWPORT9*, int> GetViewport;

        [NativeTypeName(
            "HRESULT (const D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DMATERIAL9*, int> SetMaterial;

        [NativeTypeName(
            "HRESULT (D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DMATERIAL9*, int> GetMaterial;

        [NativeTypeName(
            "HRESULT (DWORD, const D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DLIGHT9*, int> SetLight;

        [NativeTypeName(
            "HRESULT (DWORD, D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DLIGHT9*, int> GetLight;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> LightEnable;

        [NativeTypeName(
            "HRESULT (DWORD, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> GetLightEnable;

        [NativeTypeName(
            "HRESULT (DWORD, const float *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, int> SetClipPlane;

        [NativeTypeName(
            "HRESULT (DWORD, float *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetClipPlane;

        [NativeTypeName(
            "HRESULT (D3DRENDERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DRENDERSTATETYPE, uint, int> SetRenderState;

        [NativeTypeName(
            "HRESULT (D3DRENDERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DRENDERSTATETYPE, uint*, int> GetRenderState;

        [NativeTypeName(
            "HRESULT (D3DSTATEBLOCKTYPE, IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DSTATEBLOCKTYPE,
            IDirect3DStateBlock9*,
            int> CreateStateBlock;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginStateBlock;

        [NativeTypeName(
            "HRESULT (IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DStateBlock9*, int> EndStateBlock;

        [NativeTypeName(
            "HRESULT (const D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DCLIPSTATUS9*, int> SetClipStatus;

        [NativeTypeName(
            "HRESULT (D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DCLIPSTATUS9*, int> GetClipStatus;

        [NativeTypeName(
            "HRESULT (DWORD, IDirect3DBaseTexture9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DBaseTexture9*, int> GetTexture;

        [NativeTypeName(
            "HRESULT (DWORD, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDirect3DBaseTexture9, int> SetTexture;

        [NativeTypeName(
            "HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DTEXTURESTAGESTATETYPE,
            uint*,
            int> GetTextureStageState;

        [NativeTypeName(
            "HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DTEXTURESTAGESTATETYPE,
            uint,
            int> SetTextureStageState;

        [NativeTypeName(
            "HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DSAMPLERSTATETYPE, uint*, int> GetSamplerState;

        [NativeTypeName(
            "HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, D3DSAMPLERSTATETYPE, uint, int> SetSamplerState;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> ValidateDevice;

        [NativeTypeName(
            "HRESULT (UINT, const PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, int> SetPaletteEntries;

        [NativeTypeName(
            "HRESULT (UINT, PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, int> GetPaletteEntries;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentTexturePalette;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentTexturePalette;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetScissorRect;

        [NativeTypeName("HRESULT (RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetScissorRect;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetSoftwareVertexProcessing;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetSoftwareVertexProcessing;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetNPatchMode;

        [NativeTypeName("float () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetNPatchMode;

        [NativeTypeName(
            "HRESULT (D3DPRIMITIVETYPE, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DPRIMITIVETYPE, uint, uint, int> DrawPrimitive;

        [NativeTypeName(
            "HRESULT (D3DPRIMITIVETYPE, INT, UINT, UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DPRIMITIVETYPE,
            int,
            uint,
            uint,
            uint,
            uint,
            int> DrawIndexedPrimitive;

        [NativeTypeName(
            "HRESULT (D3DPRIMITIVETYPE, UINT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DPRIMITIVETYPE,
            uint,
            void*,
            uint,
            int> DrawPrimitiveUP;

        [NativeTypeName(
            "HRESULT (D3DPRIMITIVETYPE, UINT, UINT, UINT, const void *, D3DFORMAT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DPRIMITIVETYPE,
            uint,
            uint,
            uint,
            void*,
            D3DFORMAT,
            void*,
            uint,
            int> DrawIndexedPrimitiveUP;

        [NativeTypeName(
            "HRESULT (UINT, UINT, UINT, IDirect3DVertexBuffer9 *, IDirect3DVertexDeclaration9 *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint,
            IDirect3DVertexBuffer9,
            IDirect3DVertexDeclaration9,
            uint,
            int> ProcessVertices;

        [NativeTypeName(
            "HRESULT (const D3DVERTEXELEMENT9 *, IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DVERTEXELEMENT9*,
            IDirect3DVertexDeclaration9*,
            int> CreateVertexDeclaration;

        [NativeTypeName(
            "HRESULT (IDirect3DVertexDeclaration9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DVertexDeclaration9, int> SetVertexDeclaration;

        [NativeTypeName(
            "HRESULT (IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DVertexDeclaration9*, int> GetVertexDeclaration;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFVF;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFVF;

        [NativeTypeName(
            "HRESULT (const DWORD *, IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, IDirect3DVertexShader9*, int> CreateVertexShader;

        [NativeTypeName(
            "HRESULT (IDirect3DVertexShader9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DVertexShader9, int> SetVertexShader;

        [NativeTypeName(
            "HRESULT (IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DVertexShader9*, int> GetVertexShader;

        [NativeTypeName(
            "HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, uint, int> SetVertexShaderConstantF;

        [NativeTypeName(
            "HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, uint, int> GetVertexShaderConstantF;

        [NativeTypeName(
            "HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, int*, uint, int> SetVertexShaderConstantI;

        [NativeTypeName(
            "HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, int*, uint, int> GetVertexShaderConstantI;

        [NativeTypeName(
            "HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, uint, int> SetVertexShaderConstantB;

        [NativeTypeName(
            "HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, uint, int> GetVertexShaderConstantB;

        [NativeTypeName(
            "HRESULT (UINT, IDirect3DVertexBuffer9 *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDirect3DVertexBuffer9,
            uint,
            uint,
            int> SetStreamSource;

        [NativeTypeName(
            "HRESULT (UINT, IDirect3DVertexBuffer9 **, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDirect3DVertexBuffer9*,
            uint*,
            uint*,
            int> GetStreamSource;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetStreamSourceFreq;

        [NativeTypeName("HRESULT (UINT, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetStreamSourceFreq;

        [NativeTypeName(
            "HRESULT (IDirect3DIndexBuffer9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DIndexBuffer9, int> SetIndices;

        [NativeTypeName(
            "HRESULT (IDirect3DIndexBuffer9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DIndexBuffer9*, int> GetIndices;

        [NativeTypeName(
            "HRESULT (const DWORD *, IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, IDirect3DPixelShader9*, int> CreatePixelShader;

        [NativeTypeName(
            "HRESULT (IDirect3DPixelShader9 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DPixelShader9, int> SetPixelShader;

        [NativeTypeName(
            "HRESULT (IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DPixelShader9*, int> GetPixelShader;

        [NativeTypeName(
            "HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, uint, int> SetPixelShaderConstantF;

        [NativeTypeName(
            "HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, uint, int> GetPixelShaderConstantF;

        [NativeTypeName(
            "HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, int*, uint, int> SetPixelShaderConstantI;

        [NativeTypeName(
            "HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, int*, uint, int> GetPixelShaderConstantI;

        [NativeTypeName(
            "HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, uint, int> SetPixelShaderConstantB;

        [NativeTypeName(
            "HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, uint, int> GetPixelShaderConstantB;

        [NativeTypeName(
            "HRESULT (UINT, const float *, const D3DRECTPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, D3DRECTPATCH_INFO*, int> DrawRectPatch;

        [NativeTypeName(
            "HRESULT (UINT, const float *, const D3DTRIPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, D3DTRIPATCH_INFO*, int> DrawTriPatch;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DeletePatch;

        [NativeTypeName(
            "HRESULT (D3DQUERYTYPE, IDirect3DQuery9 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DQUERYTYPE, IDirect3DQuery9*, int> CreateQuery;

        [NativeTypeName(
            "HRESULT (UINT, UINT, float *, float *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            float*,
            float*,
            int> SetConvolutionMonoKernel;

        [NativeTypeName(
            "HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *, IDirect3DVertexBuffer9 *, UINT, IDirect3DVertexBuffer9 *, D3DCOMPOSERECTSOP, int, int) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirect3DSurface9,
            IDirect3DSurface9,
            IDirect3DVertexBuffer9,
            uint,
            IDirect3DVertexBuffer9,
            D3DCOMPOSERECTSOP,
            int,
            int,
            int> ComposeRects;

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, HWND, RGNDATA*, uint, int> PresentEx;

        [NativeTypeName("HRESULT (INT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetGPUThreadPriority;

        [NativeTypeName("HRESULT (INT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetGPUThreadPriority;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WaitForVBlank;

        [NativeTypeName(
            "HRESULT (IDirect3DResource9 **, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DResource9*, uint, int> CheckResourceResidency;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMaximumFrameLatency;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumFrameLatency;

        [NativeTypeName("HRESULT (HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> CheckDeviceState;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DMULTISAMPLE_TYPE,
            uint,
            BOOL,
            IDirect3DSurface9*,
            HANDLE*,
            uint,
            int> CreateRenderTargetEx;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DFORMAT, D3DPOOL, IDirect3DSurface9 **, HANDLE *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DPOOL,
            IDirect3DSurface9*,
            HANDLE*,
            uint,
            int> CreateOffscreenPlainSurfaceEx;

        [NativeTypeName(
            "HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3DFORMAT,
            D3DMULTISAMPLE_TYPE,
            uint,
            BOOL,
            IDirect3DSurface9*,
            HANDLE*,
            uint,
            int> CreateDepthStencilSurfaceEx;

        [NativeTypeName(
            "HRESULT (D3DPRESENT_PARAMETERS *, D3DDISPLAYMODEEX *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, int> ResetEx;

        [NativeTypeName(
            "HRESULT (UINT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDISPLAYMODEEX*,
            D3DDISPLAYROTATION*,
            int> GetDisplayModeEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDevice9Ex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDevice9Ex(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirect3DDevice9"/> to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirect3DDevice9"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Ex(Silk.NET.DirectX.IDirect3DDevice9 value)
    {
        return new IDirect3DDevice9Ex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DDevice9Ex"/> to <see cref = "Silk.NET.DirectX.IDirect3DDevice9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirect3DDevice9(IDirect3DDevice9Ex value)
    {
        return new Silk.NET.DirectX.IDirect3DDevice9(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DDevice9Ex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Ex(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DDevice9Ex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DDevice9Ex"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Ex"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DDevice9Ex value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
