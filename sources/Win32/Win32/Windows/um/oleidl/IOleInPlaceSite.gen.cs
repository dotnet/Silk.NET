// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000119-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceSite : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IOleInPlaceSite : IOleInPlaceSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleInPlaceSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceSite, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceSite, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CanInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnUIActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, int>)((*lpVtbl)[7]))(this);
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
                IOleInPlaceSite,
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
        return ((delegate* unmanaged<IOleInPlaceSite, SIZE, int>)((*lpVtbl)[9]))(
            this,
            scrollExtant
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnUIDeactivate(BOOL fUndoable)
    {
        return ((delegate* unmanaged<IOleInPlaceSite, BOOL, int>)((*lpVtbl)[10]))(this, fUndoable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnInPlaceDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DiscardUndoState()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeactivateAndUndo()
    {
        return ((delegate* unmanaged<IOleInPlaceSite, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
    {
        return ((delegate* unmanaged<IOleInPlaceSite, RECT*, int>)((*lpVtbl)[14]))(
            this,
            lprcPosRect
        );
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT CanInPlaceActivate();

        [VtblIndex(6)]
        HRESULT OnInPlaceActivate();

        [VtblIndex(7)]
        HRESULT OnUIActivate();

        [VtblIndex(8)]
        HRESULT GetWindowContext(
            IOleInPlaceFrame* ppFrame,
            IOleInPlaceUIWindow* ppDoc,
            [NativeTypeName("LPRECT")] RECT* lprcPosRect,
            [NativeTypeName("LPRECT")] RECT* lprcClipRect,
            [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo
        );

        [VtblIndex(9)]
        HRESULT Scroll(SIZE scrollExtant);

        [VtblIndex(10)]
        HRESULT OnUIDeactivate(BOOL fUndoable);

        [VtblIndex(11)]
        HRESULT OnInPlaceDeactivate();

        [VtblIndex(12)]
        HRESULT DiscardUndoState();

        [VtblIndex(13)]
        HRESULT DeactivateAndUndo();

        [VtblIndex(14)]
        HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleInPlaceSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleInPlaceSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IOleInPlaceSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSite(Silk.NET.Windows.IOleWindow value)
    {
        return new IOleInPlaceSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSite"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IOleInPlaceSite value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleInPlaceSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleInPlaceSite(Silk.NET.Windows.IUnknown value)
    {
        return new IOleInPlaceSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleInPlaceSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
