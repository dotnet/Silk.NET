// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo"]/*'/>
[Guid("36D39EB0-DD75-11CE-BF0E-00AA0055595A")]
[NativeTypeName("struct IDirectDrawVideo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawVideo : IDirectDrawVideo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawVideo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, Guid*, void**, int> )(lpVtbl[0]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, uint> )(lpVtbl[1]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, uint> )(lpVtbl[2]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetSwitches"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSwitches([NativeTypeName("DWORD *")] uint* pSwitches)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, uint*, int> )(lpVtbl[3]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pSwitches);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.SetSwitches"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSwitches([NativeTypeName("DWORD")] uint Switches)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, uint, int> )(lpVtbl[4]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), Switches);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetCaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, DDCAPS_DX7*, int> )(lpVtbl[5]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pCaps);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetEmulatedCaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEmulatedCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, DDCAPS_DX7*, int> )(lpVtbl[6]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pCaps);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetSurfaceDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSurfaceDesc(DDSURFACEDESC* pSurfaceDesc)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, DDSURFACEDESC*, int> )(lpVtbl[7]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pSurfaceDesc);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetFourCCCodes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFourCCCodes([NativeTypeName("DWORD *")] uint* pCount, [NativeTypeName("DWORD *")] uint* pCodes)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, uint*, uint*, int> )(lpVtbl[8]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pCount, pCodes);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.SetDirectDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetDirectDraw([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* pDirectDraw)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, IDirectDraw*, int> )(lpVtbl[9]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pDirectDraw);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetDirectDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDirectDraw([NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** ppDirectDraw)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, IDirectDraw**, int> )(lpVtbl[10]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), ppDirectDraw);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.GetSurfaceType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSurfaceType([NativeTypeName("DWORD *")] uint* pSurfaceType)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, uint*, int> )(lpVtbl[11]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), pSurfaceType);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.SetDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetDefault()
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int> )(lpVtbl[12]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.UseScanLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UseScanLine([NativeTypeName("long")] int UseScanLine)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int, int> )(lpVtbl[13]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseScanLine);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.CanUseScanLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CanUseScanLine([NativeTypeName("long *")] int* UseScanLine)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int*, int> )(lpVtbl[14]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseScanLine);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.UseOverlayStretch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UseOverlayStretch([NativeTypeName("long")] int UseOverlayStretch)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int, int> )(lpVtbl[15]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseOverlayStretch);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.CanUseOverlayStretch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CanUseOverlayStretch([NativeTypeName("long *")] int* UseOverlayStretch)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int*, int> )(lpVtbl[16]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseOverlayStretch);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.UseWhenFullScreen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UseWhenFullScreen([NativeTypeName("long")] int UseWhenFullScreen)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int, int> )(lpVtbl[17]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseWhenFullScreen);
    }

    /// <include file='IDirectDrawVideo.xml' path='doc/member[@name="IDirectDrawVideo.WillUseFullScreen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WillUseFullScreen([NativeTypeName("long *")] int* UseWhenFullScreen)
    {
        return ((delegate* unmanaged<IDirectDrawVideo*, int*, int> )(lpVtbl[18]))((IDirectDrawVideo*)Unsafe.AsPointer(ref this), UseWhenFullScreen);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSwitches([NativeTypeName("DWORD *")] uint* pSwitches);
        [VtblIndex(4)]
        HRESULT SetSwitches([NativeTypeName("DWORD")] uint Switches);
        [VtblIndex(5)]
        HRESULT GetCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps);
        [VtblIndex(6)]
        HRESULT GetEmulatedCaps([NativeTypeName("DDCAPS *")] DDCAPS_DX7* pCaps);
        [VtblIndex(7)]
        HRESULT GetSurfaceDesc(DDSURFACEDESC* pSurfaceDesc);
        [VtblIndex(8)]
        HRESULT GetFourCCCodes([NativeTypeName("DWORD *")] uint* pCount, [NativeTypeName("DWORD *")] uint* pCodes);
        [VtblIndex(9)]
        HRESULT SetDirectDraw([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* pDirectDraw);
        [VtblIndex(10)]
        HRESULT GetDirectDraw([NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** ppDirectDraw);
        [VtblIndex(11)]
        HRESULT GetSurfaceType([NativeTypeName("DWORD *")] uint* pSurfaceType);
        [VtblIndex(12)]
        HRESULT SetDefault();
        [VtblIndex(13)]
        HRESULT UseScanLine([NativeTypeName("long")] int UseScanLine);
        [VtblIndex(14)]
        HRESULT CanUseScanLine([NativeTypeName("long *")] int* UseScanLine);
        [VtblIndex(15)]
        HRESULT UseOverlayStretch([NativeTypeName("long")] int UseOverlayStretch);
        [VtblIndex(16)]
        HRESULT CanUseOverlayStretch([NativeTypeName("long *")] int* UseOverlayStretch);
        [VtblIndex(17)]
        HRESULT UseWhenFullScreen([NativeTypeName("long")] int UseWhenFullScreen);
        [VtblIndex(18)]
        HRESULT WillUseFullScreen([NativeTypeName("long *")] int* UseWhenFullScreen);
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSwitches;
        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSwitches;
        [NativeTypeName("HRESULT (DDCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCAPS_DX7*, int> GetCaps;
        [NativeTypeName("HRESULT (DDCAPS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCAPS_DX7*, int> GetEmulatedCaps;
        [NativeTypeName("HRESULT (DDSURFACEDESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC*, int> GetSurfaceDesc;
        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetFourCCCodes;
        [NativeTypeName("HRESULT (LPDIRECTDRAW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw*, int> SetDirectDraw;
        [NativeTypeName("HRESULT (LPDIRECTDRAW *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw**, int> GetDirectDraw;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSurfaceType;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefault;
        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> UseScanLine;
        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanUseScanLine;
        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> UseOverlayStretch;
        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanUseOverlayStretch;
        [NativeTypeName("HRESULT (long) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> UseWhenFullScreen;
        [NativeTypeName("HRESULT (long *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> WillUseFullScreen;
    }
}