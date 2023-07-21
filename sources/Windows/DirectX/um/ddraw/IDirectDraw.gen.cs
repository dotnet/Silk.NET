// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw"]/*' />
[Guid("6C14DB80-A733-11CE-A521-0020AF0BE560")]
[NativeTypeName("struct IDirectDraw : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDraw : IDirectDraw.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDraw));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDraw*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDraw*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDraw*, uint>)(lpVtbl[1]))((IDirectDraw*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDraw*, uint>)(lpVtbl[2]))((IDirectDraw*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.Compact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Compact()
    {
        return ((delegate* unmanaged<IDirectDraw*, int>)(lpVtbl[3]))((IDirectDraw*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.CreateClipper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateClipper([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param1, IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint, IDirectDrawClipper**, IUnknown*, int>)(lpVtbl[4]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.CreatePalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreatePalette([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param1, [NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param2, IUnknown* param3)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint, PALETTEENTRY*, IDirectDrawPalette**, IUnknown*, int>)(lpVtbl[5]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.CreateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1, IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectDraw*, DDSURFACEDESC*, IDirectDrawSurface**, IUnknown*, int>)(lpVtbl[6]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.DuplicateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1)
    {
        return ((delegate* unmanaged<IDirectDraw*, IDirectDrawSurface*, IDirectDrawSurface**, int>)(lpVtbl[7]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.EnumDisplayModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumDisplayModes([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMMODESCALLBACK")] delegate* unmanaged<DDSURFACEDESC*, void*, HRESULT> param3)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[8]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.EnumSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumSurfaces([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT> param3)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.FlipToGDISurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FlipToGDISurface()
    {
        return ((delegate* unmanaged<IDirectDraw*, int>)(lpVtbl[10]))((IDirectDraw*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1)
    {
        return ((delegate* unmanaged<IDirectDraw*, DDCAPS_DX7*, DDCAPS_DX7*, int>)(lpVtbl[11]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
    {
        return ((delegate* unmanaged<IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[12]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetFourCCCodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint*, uint*, int>)(lpVtbl[13]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetGDISurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param0)
    {
        return ((delegate* unmanaged<IDirectDraw*, IDirectDrawSurface**, int>)(lpVtbl[14]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetMonitorFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetMonitorFrequency([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint*, int>)(lpVtbl[15]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetScanLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetScanLine([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint*, int>)(lpVtbl[16]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.GetVerticalBlankStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetVerticalBlankStatus([NativeTypeName("LPBOOL")] BOOL* param0)
    {
        return ((delegate* unmanaged<IDirectDraw*, BOOL*, int>)(lpVtbl[17]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Initialize(Guid* param0)
    {
        return ((delegate* unmanaged<IDirectDraw*, Guid*, int>)(lpVtbl[18]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.RestoreDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RestoreDisplayMode()
    {
        return ((delegate* unmanaged<IDirectDraw*, int>)(lpVtbl[19]))((IDirectDraw*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.SetCooperativeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDraw*, HWND, uint, int>)(lpVtbl[20]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.SetDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint, uint, uint, int>)(lpVtbl[21]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDraw.xml' path='doc/member[@name="IDirectDraw.WaitForVerticalBlank"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, HANDLE param1)
    {
        return ((delegate* unmanaged<IDirectDraw*, uint, HANDLE, int>)(lpVtbl[22]))((IDirectDraw*)Unsafe.AsPointer(ref this), param0, param1);
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
        HRESULT CreateSurface([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1, IUnknown* param2);

        [VtblIndex(7)]
        HRESULT DuplicateSurface([NativeTypeName("LPDIRECTDRAWSURFACE")] IDirectDrawSurface* param0, [NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param1);

        [VtblIndex(10)]
        HRESULT FlipToGDISurface();

        [VtblIndex(11)]
        HRESULT GetCaps([NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param0, [NativeTypeName("LPDDCAPS")] DDCAPS_DX7* param1);

        [VtblIndex(12)]
        HRESULT GetDisplayMode([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0);

        [VtblIndex(13)]
        HRESULT GetFourCCCodes([NativeTypeName("LPDWORD")] uint* param0, [NativeTypeName("LPDWORD")] uint* param1);

        [VtblIndex(14)]
        HRESULT GetGDISurface([NativeTypeName("LPDIRECTDRAWSURFACE *")] IDirectDrawSurface** param0);

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
        HRESULT SetDisplayMode([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(22)]
        HRESULT WaitForVerticalBlank([NativeTypeName("DWORD")] uint param0, HANDLE param1);
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

        [NativeTypeName("HRESULT (LPDDSURFACEDESC, LPDIRECTDRAWSURFACE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC*, IDirectDrawSurface**, IUnknown*, int> CreateSurface;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE, LPDIRECTDRAWSURFACE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface*, IDirectDrawSurface**, int> DuplicateSurface;

        [NativeTypeName("HRESULT (DWORD, LPDDSURFACEDESC, LPVOID, LPDDENUMMODESCALLBACK) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<DDSURFACEDESC*, void*, HRESULT>, int> EnumDisplayModes;

        [NativeTypeName("HRESULT (DWORD, LPDDSURFACEDESC, LPVOID, LPDDENUMSURFACESCALLBACK) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDSURFACEDESC*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int> EnumSurfaces;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FlipToGDISurface;

        [NativeTypeName("HRESULT (LPDDCAPS, LPDDCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCAPS_DX7*, DDCAPS_DX7*, int> GetCaps;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC*, int> GetDisplayMode;

        [NativeTypeName("HRESULT (LPDWORD, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetFourCCCodes;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface**, int> GetGDISurface;

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

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> SetDisplayMode;

        [NativeTypeName("HRESULT (DWORD, HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HANDLE, int> WaitForVerticalBlank;
    }
}
