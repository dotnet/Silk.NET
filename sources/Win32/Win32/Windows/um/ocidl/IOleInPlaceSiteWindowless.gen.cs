// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("922EADA0-3424-11CF-B670-00AA004CD6D8")]
[NativeTypeName("struct IOleInPlaceSiteWindowless : IOleInPlaceSiteEx")]
[NativeInheritance("IOleInPlaceSiteEx")]
public unsafe partial struct IOleInPlaceSiteWindowless
    : IOleInPlaceSiteWindowless.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceSiteWindowless));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, HWND*, int>)((*lpVtbl)[3]))(
            this,
            phwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnterMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CanInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnUIActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWindowContext(
        IOleInPlaceFrame* ppFrame,
        IOleInPlaceUIWindow* ppDoc,
        [NativeTypeName("LPRECT")] RECT* lprcPosRect,
        [NativeTypeName("LPRECT")] RECT* lprcClipRect,
        [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo
    )
    {
        return (
            (delegate* unmanaged<
                IOleInPlaceSiteWindowless,
                IOleInPlaceFrame*,
                IOleInPlaceUIWindow*,
                RECT*,
                RECT*,
                OLEINPLACEFRAMEINFO*,
                int>)((*lpVtbl)[8])
        )(this, ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Scroll(SIZE scrollExtant)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, SIZE, int>)((*lpVtbl)[9]))(
            this,
            scrollExtant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnUIDeactivate(BOOL fUndoable)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, BOOL, int>)((*lpVtbl)[10]))(
            this,
            fUndoable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnInPlaceDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DiscardUndoState()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeactivateAndUndo()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, RECT*, int>)((*lpVtbl)[14]))(
            this,
            lprcPosRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT OnInPlaceActivateEx(BOOL* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, BOOL*, uint, int>)((*lpVtbl)[15]))(
            this,
            pfNoRedraw,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OnInPlaceDeactivateEx(BOOL fNoRedraw)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, BOOL, int>)((*lpVtbl)[16]))(
            this,
            fNoRedraw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RequestUIActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CanWindowlessActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetCapture()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetCapture(BOOL fCapture)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, BOOL, int>)((*lpVtbl)[20]))(
            this,
            fCapture
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFocus()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetFocus(BOOL fFocus)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, BOOL, int>)((*lpVtbl)[22]))(
            this,
            fFocus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDC(
        [NativeTypeName("LPCRECT")] RECT* pRect,
        [NativeTypeName("DWORD")] uint grfFlags,
        HDC* phDC
    )
    {
        return (
            (delegate* unmanaged<IOleInPlaceSiteWindowless, RECT*, uint, HDC*, int>)((*lpVtbl)[23])
        )(this, pRect, grfFlags, phDC);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ReleaseDC(HDC hDC)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, HDC, int>)((*lpVtbl)[24]))(
            this,
            hDC
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT InvalidateRect([NativeTypeName("LPCRECT")] RECT* pRect, BOOL fErase)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, RECT*, BOOL, int>)((*lpVtbl)[25]))(
            this,
            pRect,
            fErase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT InvalidateRgn(HRGN hRGN, BOOL fErase)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, HRGN, BOOL, int>)((*lpVtbl)[26]))(
            this,
            hRGN,
            fErase
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ScrollRect(
        int dx,
        int dy,
        [NativeTypeName("LPCRECT")] RECT* pRectScroll,
        [NativeTypeName("LPCRECT")] RECT* pRectClip
    )
    {
        return (
            (delegate* unmanaged<IOleInPlaceSiteWindowless, int, int, RECT*, RECT*, int>)(
                (*lpVtbl)[27]
            )
        )(this, dx, dy, pRectScroll, pRectClip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT AdjustRect([NativeTypeName("LPRECT")] RECT* prc)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteWindowless, RECT*, int>)((*lpVtbl)[28]))(
            this,
            prc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT OnDefWindowMessage(uint msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult)
    {
        return (
            (delegate* unmanaged<IOleInPlaceSiteWindowless, uint, WPARAM, LPARAM, LRESULT*, int>)(
                (*lpVtbl)[29]
            )
        )(this, msg, wParam, lParam, plResult);
    }

    public interface Interface : IOleInPlaceSiteEx.Interface
    {
        [VtblIndex(18)]
        HRESULT CanWindowlessActivate();

        [VtblIndex(19)]
        HRESULT GetCapture();

        [VtblIndex(20)]
        HRESULT SetCapture(BOOL fCapture);

        [VtblIndex(21)]
        HRESULT GetFocus();

        [VtblIndex(22)]
        HRESULT SetFocus(BOOL fFocus);

        [VtblIndex(23)]
        HRESULT GetDC(
            [NativeTypeName("LPCRECT")] RECT* pRect,
            [NativeTypeName("DWORD")] uint grfFlags,
            HDC* phDC
        );

        [VtblIndex(24)]
        HRESULT ReleaseDC(HDC hDC);

        [VtblIndex(25)]
        HRESULT InvalidateRect([NativeTypeName("LPCRECT")] RECT* pRect, BOOL fErase);

        [VtblIndex(26)]
        HRESULT InvalidateRgn(HRGN hRGN, BOOL fErase);

        [VtblIndex(27)]
        HRESULT ScrollRect(
            int dx,
            int dy,
            [NativeTypeName("LPCRECT")] RECT* pRectScroll,
            [NativeTypeName("LPCRECT")] RECT* pRectClip
        );

        [VtblIndex(28)]
        HRESULT AdjustRect([NativeTypeName("LPRECT")] RECT* prc);

        [VtblIndex(29)]
        HRESULT OnDefWindowMessage(uint msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult);
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CanInPlaceActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnInPlaceActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnUIActivate;

        [NativeTypeName(
            "HRESULT (IOleInPlaceFrame **, IOleInPlaceUIWindow **, LPRECT, LPRECT, LPOLEINPLACEFRAMEINFO) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IOleInPlaceFrame*,
            IOleInPlaceUIWindow*,
            RECT*,
            RECT*,
            OLEINPLACEFRAMEINFO*,
            int> GetWindowContext;

        [NativeTypeName("HRESULT (SIZE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE, int> Scroll;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> OnUIDeactivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnInPlaceDeactivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DiscardUndoState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DeactivateAndUndo;

        [NativeTypeName("HRESULT (LPCRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnPosRectChange;

        [NativeTypeName("HRESULT (BOOL *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, uint, int> OnInPlaceActivateEx;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> OnInPlaceDeactivateEx;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RequestUIActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CanWindowlessActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetCapture;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetCapture;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetFocus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetFocus;

        [NativeTypeName("HRESULT (LPCRECT, DWORD, HDC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, uint, HDC*, int> GetDC;

        [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int> ReleaseDC;

        [NativeTypeName("HRESULT (LPCRECT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, BOOL, int> InvalidateRect;

        [NativeTypeName("HRESULT (HRGN, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRGN, BOOL, int> InvalidateRgn;

        [NativeTypeName("HRESULT (INT, INT, LPCRECT, LPCRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, RECT*, RECT*, int> ScrollRect;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> AdjustRect;

        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, LRESULT*, int> OnDefWindowMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleInPlaceSiteWindowless"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleInPlaceSiteWindowless(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleInPlaceSiteEx"/> to <see cref = "IOleInPlaceSiteWindowless"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleInPlaceSiteEx"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteWindowless(
        Silk.NET.Windows.IOleInPlaceSiteEx value
    )
    {
        return new IOleInPlaceSiteWindowless(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteWindowless"/> to <see cref = "Silk.NET.Windows.IOleInPlaceSiteEx"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteWindowless"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleInPlaceSiteEx(
        IOleInPlaceSiteWindowless value
    )
    {
        return new Silk.NET.Windows.IOleInPlaceSiteEx(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleInPlaceSite"/> to <see cref = "IOleInPlaceSiteWindowless"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleInPlaceSite"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteWindowless(
        Silk.NET.Windows.IOleInPlaceSite value
    )
    {
        return new IOleInPlaceSiteWindowless(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteWindowless"/> to <see cref = "Silk.NET.Windows.IOleInPlaceSite"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteWindowless"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleInPlaceSite(
        IOleInPlaceSiteWindowless value
    )
    {
        return new Silk.NET.Windows.IOleInPlaceSite(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IOleInPlaceSiteWindowless"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteWindowless(Silk.NET.Windows.IOleWindow value)
    {
        return new IOleInPlaceSiteWindowless(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteWindowless"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteWindowless"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IOleInPlaceSiteWindowless value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleInPlaceSiteWindowless"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteWindowless(Silk.NET.Windows.IUnknown value)
    {
        return new IOleInPlaceSiteWindowless(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteWindowless"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteWindowless"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleInPlaceSiteWindowless value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
