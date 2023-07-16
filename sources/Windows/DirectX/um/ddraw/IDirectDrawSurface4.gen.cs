// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4"]/*'/>
[Guid("0B2B8630-AD35-11D0-8EA6-00609797EA5B")]
[NativeTypeName("struct IDirectDrawSurface4 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawSurface4 : IDirectDrawSurface4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawSurface4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, Guid*, void**, int> )(lpVtbl[0]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint> )(lpVtbl[1]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint> )(lpVtbl[2]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.AddAttachedSurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDrawSurface4*, int> )(lpVtbl[3]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.AddOverlayDirtyRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, RECT*, int> )(lpVtbl[4]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.Blt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, RECT*, IDirectDrawSurface4*, RECT*, uint, DDBLTFX*, int> )(lpVtbl[5]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.BltBatch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, DDBLTBATCH*, uint, uint, int> )(lpVtbl[6]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.BltFast"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, uint, IDirectDrawSurface4*, RECT*, uint, int> )(lpVtbl[7]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.DeleteAttachedSurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, IDirectDrawSurface4*, int> )(lpVtbl[8]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.EnumAttachedSurfaces"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, HRESULT> param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, void*, delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, HRESULT> , int> )(lpVtbl[9]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.EnumOverlayZOrders"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK2")] delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, HRESULT> param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, void*, delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, void*, HRESULT> , int> )(lpVtbl[10]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.Flip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDrawSurface4*, uint, int> )(lpVtbl[11]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetAttachedSurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, DDSCAPS2*, IDirectDrawSurface4**, int> )(lpVtbl[12]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetBltStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBltStatus([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, int> )(lpVtbl[13]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetCaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCaps([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, DDSCAPS2*, int> )(lpVtbl[14]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetClipper"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDrawClipper**, int> )(lpVtbl[15]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetColorKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, DDCOLORKEY*, int> )(lpVtbl[16]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetDC"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDC(HDC* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, HDC*, int> )(lpVtbl[17]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetFlipStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFlipStatus([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, int> )(lpVtbl[18]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetOverlayPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, int*, int*, int> )(lpVtbl[19]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDrawPalette**, int> )(lpVtbl[20]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetPixelFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, DDPIXELFORMAT*, int> )(lpVtbl[21]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetSurfaceDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, int> )(lpVtbl[22]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDraw*, DDSURFACEDESC2*, int> )(lpVtbl[23]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.IsLost"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT IsLost()
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, int> )(lpVtbl[24]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.Lock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("DWORD")] uint param2, HANDLE param3)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, RECT*, DDSURFACEDESC2*, uint, HANDLE, int> )(lpVtbl[25]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.ReleaseDC"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ReleaseDC(HDC param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, HDC, int> )(lpVtbl[26]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.Restore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Restore()
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, int> )(lpVtbl[27]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.SetClipper"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDrawClipper*, int> )(lpVtbl[28]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.SetColorKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, DDCOLORKEY*, int> )(lpVtbl[29]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.SetOverlayPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, int, int, int> )(lpVtbl[30]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.SetPalette"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, IDirectDrawPalette*, int> )(lpVtbl[31]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.Unlock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Unlock([NativeTypeName("LPRECT")] RECT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, RECT*, int> )(lpVtbl[32]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.UpdateOverlay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, RECT*, IDirectDrawSurface4*, RECT*, uint, DDOVERLAYFX*, int> )(lpVtbl[33]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.UpdateOverlayDisplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, int> )(lpVtbl[34]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.UpdateOverlayZOrder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, IDirectDrawSurface4*, int> )(lpVtbl[35]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetDDInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, void**, int> )(lpVtbl[36]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.PageLock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT PageLock([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, int> )(lpVtbl[37]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.PageUnlock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT PageUnlock([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint, int> )(lpVtbl[38]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.SetSurfaceDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, DDSURFACEDESC2*, uint, int> )(lpVtbl[39]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.SetPrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, Guid*, void*, uint, uint, int> )(lpVtbl[40]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetPrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDWORD")] uint* param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, Guid*, void*, uint*, int> )(lpVtbl[41]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.FreePrivateData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT FreePrivateData([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, Guid*, int> )(lpVtbl[42]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.GetUniquenessValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetUniquenessValue([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, uint*, int> )(lpVtbl[43]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface4.xml' path='doc/member[@name="IDirectDrawSurface4.ChangeUniquenessValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT ChangeUniquenessValue()
    {
        return ((delegate* unmanaged<IDirectDrawSurface4*, int> )(lpVtbl[44]))((IDirectDrawSurface4*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0);
        [VtblIndex(4)]
        HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0);
        [VtblIndex(5)]
        HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4);
        [VtblIndex(6)]
        HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);
        [VtblIndex(7)]
        HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4);
        [VtblIndex(8)]
        HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1);
        [VtblIndex(11)]
        HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param0, [NativeTypeName("DWORD")] uint param1);
        [VtblIndex(12)]
        HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4 *")] IDirectDrawSurface4** param1);
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
        HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4);
        [VtblIndex(34)]
        HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0);
        [VtblIndex(35)]
        HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE4")] IDirectDrawSurface4* param1);
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
        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE4) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface4*, int> AddAttachedSurface;
        [NativeTypeName("HRESULT (LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> AddOverlayDirtyRect;
        [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE4, LPRECT, DWORD, LPDDBLTFX) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IDirectDrawSurface4*, RECT*, uint, DDBLTFX*, int> Blt;
        [NativeTypeName("HRESULT (LPDDBLTBATCH, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDBLTBATCH*, uint, uint, int> BltBatch;
        [NativeTypeName("HRESULT (DWORD, DWORD, LPDIRECTDRAWSURFACE4, LPRECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDirectDrawSurface4*, RECT*, uint, int> BltFast;
        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE4) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawSurface4*, int> DeleteAttachedSurface;
        [NativeTypeName("HRESULT (LPVOID, LPDDENUMSURFACESCALLBACK2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, delegate* unmanaged<TSelf*, DDSURFACEDESC2*, void*, HRESULT> , int> EnumAttachedSurfaces;
        [NativeTypeName("HRESULT (DWORD, LPVOID, LPDDENUMSURFACESCALLBACK2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, delegate* unmanaged<TSelf*, DDSURFACEDESC2*, void*, HRESULT> , int> EnumOverlayZOrders;
        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE4, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface4*, uint, int> Flip;
        [NativeTypeName("HRESULT (LPDDSCAPS2, LPDIRECTDRAWSURFACE4 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSCAPS2*, IDirectDrawSurface4**, int> GetAttachedSurface;
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
        [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE4, LPRECT, DWORD, LPDDOVERLAYFX) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IDirectDrawSurface4*, RECT*, uint, DDOVERLAYFX*, int> UpdateOverlay;
        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UpdateOverlayDisplay;
        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE4) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawSurface4*, int> UpdateOverlayZOrder;
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
    }
}