// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9C2CAD80-3424-11CF-B670-00AA004CD6D8")]
[NativeTypeName("struct IOleInPlaceSiteEx : IOleInPlaceSite")]
[NativeInheritance("IOleInPlaceSite")]
public unsafe partial struct IOleInPlaceSiteEx : IOleInPlaceSiteEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceSiteEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleInPlaceSiteEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnterMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CanInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnUIActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[7]))(this);
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
                IOleInPlaceSiteEx,
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
        return ((delegate* unmanaged<IOleInPlaceSiteEx, SIZE, int>)((*lpVtbl)[9]))(
            this,
            scrollExtant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnUIDeactivate(BOOL fUndoable)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, BOOL, int>)((*lpVtbl)[10]))(
            this,
            fUndoable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnInPlaceDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DiscardUndoState()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeactivateAndUndo()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, RECT*, int>)((*lpVtbl)[14]))(
            this,
            lprcPosRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT OnInPlaceActivateEx(BOOL* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, BOOL*, uint, int>)((*lpVtbl)[15]))(
            this,
            pfNoRedraw,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OnInPlaceDeactivateEx(BOOL fNoRedraw)
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, BOOL, int>)((*lpVtbl)[16]))(
            this,
            fNoRedraw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RequestUIActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSiteEx, int>)((*lpVtbl)[17]))(this);
    }

    public interface Interface : IOleInPlaceSite.Interface
    {
        [VtblIndex(15)]
        HRESULT OnInPlaceActivateEx(BOOL* pfNoRedraw, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(16)]
        HRESULT OnInPlaceDeactivateEx(BOOL fNoRedraw);

        [VtblIndex(17)]
        HRESULT RequestUIActivate();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleInPlaceSiteEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleInPlaceSiteEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleInPlaceSite"/> to <see cref = "IOleInPlaceSiteEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleInPlaceSite"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteEx(Silk.NET.Windows.IOleInPlaceSite value)
    {
        return new IOleInPlaceSiteEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteEx"/> to <see cref = "Silk.NET.Windows.IOleInPlaceSite"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleInPlaceSite(IOleInPlaceSiteEx value)
    {
        return new Silk.NET.Windows.IOleInPlaceSite(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IOleInPlaceSiteEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteEx(Silk.NET.Windows.IOleWindow value)
    {
        return new IOleInPlaceSiteEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteEx"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IOleInPlaceSiteEx value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleInPlaceSiteEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSiteEx(Silk.NET.Windows.IUnknown value)
    {
        return new IOleInPlaceSiteEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSiteEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSiteEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleInPlaceSiteEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
