// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7"]/*' />
[Guid("15E65EC0-3B9C-11D2-B92F-00609797EA5B")]
[NativeTypeName("struct IDirectDraw7 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDraw7 : IDirectDraw7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDraw7));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDraw7*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint>)(lpVtbl[1]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint>)(lpVtbl[2]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.Compact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Compact()
    {
        return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[3]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.CreateClipper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.CreatePalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.CreateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1, IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectDraw7*, DDSURFACEDESC2*, IDirectDrawSurface7**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.DuplicateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, IDirectDrawSurface7*, IDirectDrawSurface7**, int>)(lpVtbl[7]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.EnumDisplayModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK2")] delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT> param3)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[8]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.EnumSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK7")] delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT> param3)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.FlipToGDISurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FlipToGDISurface()
    {
        return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[10]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0)
    {
        return ((delegate* unmanaged<IDirectDraw7*, DDSURFACEDESC2*, int>)(lpVtbl[12]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetFourCCCodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetGDISurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param0)
    {
        return ((delegate* unmanaged<IDirectDraw7*, IDirectDrawSurface7**, int>)(lpVtbl[14]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetMonitorFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint*, int>)(lpVtbl[15]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetScanLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint*, int>)(lpVtbl[16]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetVerticalBlankStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0)
    {
        return ((delegate* unmanaged<IDirectDraw7*, BOOL*, int>)(lpVtbl[17]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Initialize(Guid* param0)
    {
        return ((delegate* unmanaged<IDirectDraw7*, Guid*, int>)(lpVtbl[18]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.RestoreDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RestoreDisplayMode()
    {
        return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[19]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.SetCooperativeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, HWND, uint, int>)(lpVtbl[20]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.SetDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, uint, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.WaitForVerticalBlank"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, HANDLE param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, HANDLE, int>)(lpVtbl[22]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetAvailableVidMem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2)
    {
        return ((delegate* unmanaged<IDirectDraw7*, DDSCAPS2*, uint*, uint*, int>)(lpVtbl[23]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetSurfaceFromDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetSurfaceFromDC(HDC param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, HDC, IDirectDrawSurface7**, int>)(lpVtbl[24]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.RestoreAllSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT RestoreAllSurfaces()
    {
        return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[25]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.TestCooperativeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT TestCooperativeLevel()
    {
        return ((delegate* unmanaged<IDirectDraw7*, int>)(lpVtbl[26]))((IDirectDraw7*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.GetDeviceIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER2")] DDDEVICEIDENTIFIER2* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, DDDEVICEIDENTIFIER2*, uint, int>)(lpVtbl[27]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.StartModeTest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT StartModeTest([NativeTypeName("LPSIZE")] SIZE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectDraw7*, SIZE*, uint, uint, int>)(lpVtbl[28]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw7.xml' path='doc/member[@name="IDirectDraw7.EvaluateMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT EvaluateMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD *")] uint* param1)
    {
        return ((delegate* unmanaged<IDirectDraw7*, uint, uint*, int>)(lpVtbl[29]))((IDirectDraw7*)Unsafe.AsPointer(ref this), param0, param1);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Compact();

        [VtblIndex(4)]
        HRESULT CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2);

        [VtblIndex(5)]
        HRESULT CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3);

        [VtblIndex(6)]
        HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1, IUnknown* param2);

        [VtblIndex(7)]
        HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1);

        [VtblIndex(10)]
        HRESULT FlipToGDISurface();

        [VtblIndex(11)]
        HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1);

        [VtblIndex(12)]
        HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC2")] DDSURFACEDESC2* param0);

        [VtblIndex(13)]
        HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1);

        [VtblIndex(14)]
        HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param0);

        [VtblIndex(15)]
        HRESULT GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(16)]
        HRESULT GetScanLine([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(17)]
        HRESULT GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0);

        [VtblIndex(18)]
        HRESULT Initialize(Guid* param0);

        [VtblIndex(19)]
        HRESULT RestoreDisplayMode();

        [VtblIndex(20)]
        HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(21)]
        HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("DWORD")] uint param4);

        [VtblIndex(22)]
        HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, HANDLE param1);

        [VtblIndex(23)]
        HRESULT GetAvailableVidMem([NativeTypeName("LPDDSCAPS2")] DDSCAPS2* param0, [NativeTypeName("LPDWORD")] uint* param1, [NativeTypeName("LPDWORD")] uint* param2);

        [VtblIndex(24)]
        HRESULT GetSurfaceFromDC(HDC param0, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** param1);

        [VtblIndex(25)]
        HRESULT RestoreAllSurfaces();

        [VtblIndex(26)]
        HRESULT TestCooperativeLevel();

        [VtblIndex(27)]
        HRESULT GetDeviceIdentifier([NativeTypeName("LPDDDEVICEIDENTIFIER2")] DDDEVICEIDENTIFIER2* param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(28)]
        HRESULT StartModeTest([NativeTypeName("LPSIZE")] SIZE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(29)]
        HRESULT EvaluateMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD *")] uint* param1);
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
        public delegate* unmanaged<TSelf*, int> Compact;

        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWCLIPPER *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawClipper**, IUnknown*, int> CreateClipper;

        [NativeTypeName("HRESULT (DWORD, LPPALETTEENTRY, LPDIRECTDRAWPALETTE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int> CreatePalette;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC2, LPDIRECTDRAWSURFACE7 *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC2*, IDirectDrawSurface7**, IUnknown*, int> CreateSurface;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7, LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface7*, IDirectDrawSurface7**, int> DuplicateSurface;

        [NativeTypeName("HRESULT (DWORD, LPDDSURFACEDESC2, LPVOID, LPDDENUMMODESCALLBACK2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<DDSURFACEDESC2*, void*, HRESULT>, int> EnumDisplayModes;

        [NativeTypeName("HRESULT (DWORD, LPDDSURFACEDESC2, LPVOID, LPDDENUMSURFACESCALLBACK7) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDSURFACEDESC2*, void*, delegate* unmanaged<IDirectDrawSurface7*, DDSURFACEDESC2*, void*, HRESULT>, int> EnumSurfaces;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FlipToGDISurface;

        [NativeTypeName("HRESULT (LPDDCAPS, LPDDCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCAPS_DX7*, DDCAPS_DX7*, int> GetCaps;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC2) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC2*, int> GetDisplayMode;

        [NativeTypeName("HRESULT (LPDWORD, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetFourCCCodes;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface7**, int> GetGDISurface;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMonitorFrequency;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetScanLine;

        [NativeTypeName("HRESULT (LPBOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetVerticalBlankStatus;

        [NativeTypeName("HRESULT (GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestoreDisplayMode;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> SetCooperativeLevel;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, uint, int> SetDisplayMode;

        [NativeTypeName("HRESULT (DWORD, HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HANDLE, int> WaitForVerticalBlank;

        [NativeTypeName("HRESULT (LPDDSCAPS2, LPDWORD, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSCAPS2*, uint*, uint*, int> GetAvailableVidMem;

        [NativeTypeName("HRESULT (HDC, LPDIRECTDRAWSURFACE7 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, IDirectDrawSurface7**, int> GetSurfaceFromDC;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestoreAllSurfaces;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> TestCooperativeLevel;

        [NativeTypeName("HRESULT (LPDDDEVICEIDENTIFIER2, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDDEVICEIDENTIFIER2*, uint, int> GetDeviceIdentifier;

        [NativeTypeName("HRESULT (LPSIZE, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, uint, uint, int> StartModeTest;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> EvaluateMode;
    }
}
