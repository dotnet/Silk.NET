// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl"]/*'/>
[Guid("0EB1088C-4DCD-46F0-878F-39DAE86A51B7")]
[NativeTypeName("struct IVMRWindowlessControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRWindowlessControl : IVMRWindowlessControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRWindowlessControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, Guid*, void**, int> )(lpVtbl[0]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, uint> )(lpVtbl[1]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, uint> )(lpVtbl[2]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetNativeVideoSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNativeVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight, [NativeTypeName("LONG *")] int* lpARWidth, [NativeTypeName("LONG *")] int* lpARHeight)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, int*, int*, int*, int*, int> )(lpVtbl[3]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight, lpARWidth, lpARHeight);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetMinIdealVideoSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMinIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, int*, int*, int> )(lpVtbl[4]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetMaxIdealVideoSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaxIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, int*, int*, int> )(lpVtbl[5]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpWidth, lpHeight);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.SetVideoPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetVideoPosition([NativeTypeName("const LPRECT")] RECT* lpSRCRect, [NativeTypeName("const LPRECT")] RECT* lpDSTRect)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, RECT*, RECT*, int> )(lpVtbl[6]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpSRCRect, lpDSTRect);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetVideoPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVideoPosition([NativeTypeName("LPRECT")] RECT* lpSRCRect, [NativeTypeName("LPRECT")] RECT* lpDSTRect)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, RECT*, RECT*, int> )(lpVtbl[7]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpSRCRect, lpDSTRect);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetAspectRatioMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAspectRatioMode([NativeTypeName("DWORD *")] uint* lpAspectRatioMode)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, uint*, int> )(lpVtbl[8]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpAspectRatioMode);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.SetAspectRatioMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint AspectRatioMode)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, uint, int> )(lpVtbl[9]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), AspectRatioMode);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.SetVideoClippingWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetVideoClippingWindow(HWND hwnd)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, HWND, int> )(lpVtbl[10]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.RepaintVideo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RepaintVideo(HWND hwnd, HDC hdc)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, HWND, HDC, int> )(lpVtbl[11]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), hwnd, hdc);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.DisplayModeChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DisplayModeChanged()
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, int> )(lpVtbl[12]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetCurrentImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCurrentImage(byte** lpDib)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, byte**, int> )(lpVtbl[13]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpDib);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.SetBorderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetBorderColor(COLORREF Clr)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF, int> )(lpVtbl[14]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), Clr);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetBorderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetBorderColor(COLORREF* lpClr)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF*, int> )(lpVtbl[15]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpClr);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.SetColorKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetColorKey(COLORREF Clr)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF, int> )(lpVtbl[16]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), Clr);
    }

    /// <include file='IVMRWindowlessControl.xml' path='doc/member[@name="IVMRWindowlessControl.GetColorKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetColorKey(COLORREF* lpClr)
    {
        return ((delegate* unmanaged<IVMRWindowlessControl*, COLORREF*, int> )(lpVtbl[17]))((IVMRWindowlessControl*)Unsafe.AsPointer(ref this), lpClr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNativeVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight, [NativeTypeName("LONG *")] int* lpARWidth, [NativeTypeName("LONG *")] int* lpARHeight);
        [VtblIndex(4)]
        HRESULT GetMinIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight);
        [VtblIndex(5)]
        HRESULT GetMaxIdealVideoSize([NativeTypeName("LONG *")] int* lpWidth, [NativeTypeName("LONG *")] int* lpHeight);
        [VtblIndex(6)]
        HRESULT SetVideoPosition([NativeTypeName("const LPRECT")] RECT* lpSRCRect, [NativeTypeName("const LPRECT")] RECT* lpDSTRect);
        [VtblIndex(7)]
        HRESULT GetVideoPosition([NativeTypeName("LPRECT")] RECT* lpSRCRect, [NativeTypeName("LPRECT")] RECT* lpDSTRect);
        [VtblIndex(8)]
        HRESULT GetAspectRatioMode([NativeTypeName("DWORD *")] uint* lpAspectRatioMode);
        [VtblIndex(9)]
        HRESULT SetAspectRatioMode([NativeTypeName("DWORD")] uint AspectRatioMode);
        [VtblIndex(10)]
        HRESULT SetVideoClippingWindow(HWND hwnd);
        [VtblIndex(11)]
        HRESULT RepaintVideo(HWND hwnd, HDC hdc);
        [VtblIndex(12)]
        HRESULT DisplayModeChanged();
        [VtblIndex(13)]
        HRESULT GetCurrentImage(byte** lpDib);
        [VtblIndex(14)]
        HRESULT SetBorderColor(COLORREF Clr);
        [VtblIndex(15)]
        HRESULT GetBorderColor(COLORREF* lpClr);
        [VtblIndex(16)]
        HRESULT SetColorKey(COLORREF Clr);
        [VtblIndex(17)]
        HRESULT GetColorKey(COLORREF* lpClr);
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
        [NativeTypeName("HRESULT (LONG *, LONG *, LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetNativeVideoSize;
        [NativeTypeName("HRESULT (LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetMinIdealVideoSize;
        [NativeTypeName("HRESULT (LONG *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetMaxIdealVideoSize;
        [NativeTypeName("HRESULT (const LPRECT, const LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> SetVideoPosition;
        [NativeTypeName("HRESULT (LPRECT, LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> GetVideoPosition;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAspectRatioMode;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetAspectRatioMode;
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetVideoClippingWindow;
        [NativeTypeName("HRESULT (HWND, HDC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HDC, int> RepaintVideo;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisplayModeChanged;
        [NativeTypeName("HRESULT (BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> GetCurrentImage;
        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetBorderColor;
        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF*, int> GetBorderColor;
        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetColorKey;
        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF*, int> GetColorKey;
    }
}