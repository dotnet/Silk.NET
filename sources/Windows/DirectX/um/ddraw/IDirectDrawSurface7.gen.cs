// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7"]/*' />
[Guid("06675A80-3B9B-11D2-B92F-00609797EA5B")]
[NativeTypeName("struct IDirectDrawSurface7 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawSurface7 : IDirectDrawSurface7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawSurface7));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint>)(lpVtbl[1]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint>)(lpVtbl[2]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.AddAttachedSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawSurface7*, int>)(lpVtbl[3]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.AddOverlayDirtyRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.Blt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, IDirectDrawSurface7*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.BltBatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.BltFast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, uint, IDirectDrawSurface7*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.DeleteAttachedSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, IDirectDrawSurface7*, int>)(lpVtbl[8]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.EnumAttachedSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT> param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.EnumOverlayZOrders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT> param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[10]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.Flip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawSurface7*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetAttachedSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, DDSCAPS2*, IDirectDrawSurface7**, int>)(lpVtbl[12]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetBltStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBltStatus([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCaps([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, DDSCAPS2*, int>)(lpVtbl[14]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetClipper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDC(HDC* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, HDC*, int>)(lpVtbl[17]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetFlipStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFlipStatus([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetOverlayPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetPixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetSurfaceDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, int>)(lpVtbl[22]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDraw*, DDSURFACEDESC2*, int>)(lpVtbl[23]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.IsLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT IsLost()
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, int>)(lpVtbl[24]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.Lock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("DWORD")] uint param2, HANDLE param3)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, DDSURFACEDESC2*, uint, HANDLE, int>)(lpVtbl[25]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.ReleaseDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ReleaseDC(HDC param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, HDC, int>)(lpVtbl[26]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.Restore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Restore()
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, int>)(lpVtbl[27]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetClipper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetOverlayPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.Unlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Unlock([NativeTypeName("LPRECT")] RECT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, int>)(lpVtbl[32]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.UpdateOverlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, RECT*, IDirectDrawSurface7*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.UpdateOverlayDisplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.UpdateOverlayZOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, IDirectDrawSurface7*, int>)(lpVtbl[35]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetDDInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.PageLock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT PageLock([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.PageUnlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT PageUnlock([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetSurfaceDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, uint, int>)(lpVtbl[39]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetPrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, void*, uint, uint, int>)(lpVtbl[40]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetPrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, void*, uint*, int>)(lpVtbl[41]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.FreePrivateData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, Guid*, int>)(lpVtbl[42]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetUniquenessValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint*, int>)(lpVtbl[43]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.ChangeUniquenessValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT ChangeUniquenessValue()
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, int>)(lpVtbl[44]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT SetPriority([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[45]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT GetPriority([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint*, int>)(lpVtbl[46]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.SetLOD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT SetLOD([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint, int>)(lpVtbl[47]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface7.xml' path='doc/member[@name="IDirectDrawSurface7.GetLOD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetLOD([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface7*, uint*, int>)(lpVtbl[48]))((IDirectDrawSurface7*)Unsafe.AsPointer(ref this), param0);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0);

        [VtblIndex(4)]
        HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0);

        [VtblIndex(5)]
        HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4);

        [VtblIndex(6)]
        HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(7)]
        HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4);

        [VtblIndex(8)]
        HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1);

        [VtblIndex(11)]
        HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(12)]
        HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1);

        [VtblIndex(13)]
        HRESULT GetBltStatus([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(14)]
        HRESULT GetCaps([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0);

        [VtblIndex(15)]
        HRESULT GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0);

        [VtblIndex(16)]
        HRESULT GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1);

        [VtblIndex(17)]
        HRESULT GetDC(HDC* param0);

        [VtblIndex(18)]
        HRESULT GetFlipStatus([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(19)]
        HRESULT GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1);

        [VtblIndex(20)]
        HRESULT GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0);

        [VtblIndex(21)]
        HRESULT GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0);

        [VtblIndex(22)]
        HRESULT GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0);

        [VtblIndex(23)]
        HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1);

        [VtblIndex(24)]
        HRESULT IsLost();

        [VtblIndex(25)]
        HRESULT Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("DWORD")] uint param2, HANDLE param3);

        [VtblIndex(26)]
        HRESULT ReleaseDC(HDC param0);

        [VtblIndex(27)]
        HRESULT Restore();

        [VtblIndex(28)]
        HRESULT SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0);

        [VtblIndex(29)]
        HRESULT SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1);

        [VtblIndex(30)]
        HRESULT SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1);

        [VtblIndex(31)]
        HRESULT SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0);

        [VtblIndex(32)]
        HRESULT Unlock([NativeTypeName("LPRECT")] RECT* param0);

        [VtblIndex(33)]
        HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4);

        [VtblIndex(34)]
        HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(35)]
        HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param1);

        [VtblIndex(36)]
        HRESULT GetDDInterface([NativeTypeName("LPVOID *")] void** param0);

        [VtblIndex(37)]
        HRESULT PageLock([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(38)]
        HRESULT PageUnlock([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(39)]
        HRESULT SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(40)]
        HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [VtblIndex(41)]
        HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2);

        [VtblIndex(42)]
        HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* param0);

        [VtblIndex(43)]
        HRESULT GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(44)]
        HRESULT ChangeUniquenessValue();

        [VtblIndex(45)]
        HRESULT SetPriority([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(46)]
        HRESULT GetPriority([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(47)]
        HRESULT SetLOD([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(48)]
        HRESULT GetLOD([NativeTypeName("LPDWORD")] uint* param0);
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

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface7*, int> AddAttachedSurface;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> AddOverlayDirtyRect;

        [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE7, LPRECT, DWORD, LPDDBLTFX) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IDirectDrawSurface7*, RECT*, uint, DDBLTFX*, int> Blt;

        [NativeTypeName("HRESULT (LPDDBLTBATCH, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDBLTBATCH*, uint, uint, int> BltBatch;

        [NativeTypeName("HRESULT (DWORD, DWORD, LPDIRECTDRAWSURFACE7, LPRECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDirectDrawSurface7*, RECT*, uint, int> BltFast;

        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE7) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawSurface7*, int> DeleteAttachedSurface;

        [NativeTypeName("HRESULT (LPVOID, LPDDENUMSURFACESCALLBACK7) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, delegate* unmanaged<TSelf*, DDSURFACEDESC2*, void*, HRESULT>, int> EnumAttachedSurfaces;

        [NativeTypeName("HRESULT (DWORD, LPVOID, LPDDENUMSURFACESCALLBACK7) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, delegate* unmanaged<TSelf*, DDSURFACEDESC2*, void*, HRESULT>, int> EnumOverlayZOrders;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface7*, uint, int> Flip;

        [NativeTypeName("HRESULT (LPDDSCAPS2, LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSCAPS2*, IDirectDrawSurface7**, int> GetAttachedSurface;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> GetBltStatus;

        [NativeTypeName("HRESULT (LPDDSCAPS2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSCAPS2*, int> GetCaps;

        [NativeTypeName("HRESULT (LPDIRECTDRAWCLIPPER *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawClipper**, int> GetClipper;

        [NativeTypeName("HRESULT (DWORD, LPDDCOLORKEY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDCOLORKEY*, int> GetColorKey;

        [NativeTypeName("HRESULT (HDC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC*, int> GetDC;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> GetFlipStatus;

        [NativeTypeName("HRESULT (LPLONG, LPLONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetOverlayPosition;

        [NativeTypeName("HRESULT (LPDIRECTDRAWPALETTE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawPalette**, int> GetPalette;

        [NativeTypeName("HRESULT (LPDDPIXELFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDPIXELFORMAT*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC2*, int> GetSurfaceDesc;

        [NativeTypeName("HRESULT (LPDIRECTDRAW, LPDDSURFACEDESC2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw*, DDSURFACEDESC2*, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsLost;

        [NativeTypeName("HRESULT (LPRECT, LPDDSURFACEDESC2, DWORD, HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, DDSURFACEDESC2*, uint, HANDLE, int> Lock;

        [NativeTypeName("HRESULT (HDC) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int> ReleaseDC;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Restore;

        [NativeTypeName("HRESULT (LPDIRECTDRAWCLIPPER) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawClipper*, int> SetClipper;

        [NativeTypeName("HRESULT (DWORD, LPDDCOLORKEY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDCOLORKEY*, int> SetColorKey;

        [NativeTypeName("HRESULT (LONG, LONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetOverlayPosition;

        [NativeTypeName("HRESULT (LPDIRECTDRAWPALETTE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawPalette*, int> SetPalette;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> Unlock;

        [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE7, LPRECT, DWORD, LPDDOVERLAYFX) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IDirectDrawSurface7*, RECT*, uint, DDOVERLAYFX*, int> UpdateOverlay;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UpdateOverlayDisplay;

        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE7) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawSurface7*, int> UpdateOverlayZOrder;

        [NativeTypeName("HRESULT (LPVOID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void**, int> GetDDInterface;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PageLock;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PageUnlock;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC2, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC2*, uint, int> SetSurfaceDesc;

        [NativeTypeName("HRESULT (const GUID &, LPVOID, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint, uint, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, LPVOID, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> FreePrivateData;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUniquenessValue;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ChangeUniquenessValue;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPriority;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPriority;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetLOD;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLOD;
    }
}
