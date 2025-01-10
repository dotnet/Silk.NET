// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000116-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceFrame : IOleInPlaceUIWindow")]
[NativeInheritance("IOleInPlaceUIWindow")]
public unsafe partial struct IOleInPlaceFrame : IOleInPlaceFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleInPlaceFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, BOOL, int>)((*lpVtbl)[4]))(this, fEnterMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, RECT*, int>)((*lpVtbl)[5]))(
            this,
            lprectBorder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, RECT*, int>)((*lpVtbl)[6]))(
            this,
            pborderwidths
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, RECT*, int>)((*lpVtbl)[7]))(
            this,
            pborderwidths
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveObject(
        IOleInPlaceActiveObject pActiveObject,
        [NativeTypeName("LPCOLESTR")] ushort* pszObjName
    )
    {
        return (
            (delegate* unmanaged<IOleInPlaceFrame, IOleInPlaceActiveObject, ushort*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pActiveObject, pszObjName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertMenus(
        HMENU hmenuShared,
        [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths
    )
    {
        return (
            (delegate* unmanaged<IOleInPlaceFrame, HMENU, OLEMENUGROUPWIDTHS*, int>)((*lpVtbl)[9])
        )(this, hmenuShared, lpMenuWidths);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetMenu(
        HMENU hmenuShared,
        [NativeTypeName("HOLEMENU")] HGLOBAL holemenu,
        HWND hwndActiveObject
    )
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, HMENU, HGLOBAL, HWND, int>)((*lpVtbl)[10]))(
            this,
            hmenuShared,
            holemenu,
            hwndActiveObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemoveMenus(HMENU hmenuShared)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, HMENU, int>)((*lpVtbl)[11]))(
            this,
            hmenuShared
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetStatusText([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, ushort*, int>)((*lpVtbl)[12]))(
            this,
            pszStatusText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, BOOL, int>)((*lpVtbl)[13]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT TranslateAccelerator(
        [NativeTypeName("LPMSG")] MSG* lpmsg,
        [NativeTypeName("WORD")] ushort wID
    )
    {
        return ((delegate* unmanaged<IOleInPlaceFrame, MSG*, ushort, int>)((*lpVtbl)[14]))(
            this,
            lpmsg,
            wID
        );
    }

    public interface Interface : IOleInPlaceUIWindow.Interface
    {
        [VtblIndex(9)]
        HRESULT InsertMenus(
            HMENU hmenuShared,
            [NativeTypeName("LPOLEMENUGROUPWIDTHS")] OLEMENUGROUPWIDTHS* lpMenuWidths
        );

        [VtblIndex(10)]
        HRESULT SetMenu(
            HMENU hmenuShared,
            [NativeTypeName("HOLEMENU")] HGLOBAL holemenu,
            HWND hwndActiveObject
        );

        [VtblIndex(11)]
        HRESULT RemoveMenus(HMENU hmenuShared);

        [VtblIndex(12)]
        HRESULT SetStatusText([NativeTypeName("LPCOLESTR")] ushort* pszStatusText);

        [VtblIndex(13)]
        HRESULT EnableModeless(BOOL fEnable);

        [VtblIndex(14)]
        HRESULT TranslateAccelerator(
            [NativeTypeName("LPMSG")] MSG* lpmsg,
            [NativeTypeName("WORD")] ushort wID
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetBorder;

        [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> RequestBorderSpace;

        [NativeTypeName("HRESULT (LPCBORDERWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetBorderSpace;

        [NativeTypeName("HRESULT (IOleInPlaceActiveObject *, LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleInPlaceActiveObject, ushort*, int> SetActiveObject;

        [NativeTypeName("HRESULT (HMENU, LPOLEMENUGROUPWIDTHS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, OLEMENUGROUPWIDTHS*, int> InsertMenus;

        [NativeTypeName("HRESULT (HMENU, HOLEMENU, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, HGLOBAL, HWND, int> SetMenu;

        [NativeTypeName("HRESULT (HMENU) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, int> RemoveMenus;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetStatusText;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableModeless;

        [NativeTypeName("HRESULT (LPMSG, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, ushort, int> TranslateAccelerator;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleInPlaceFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleInPlaceFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleInPlaceUIWindow"/> to <see cref = "IOleInPlaceFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleInPlaceUIWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceFrame(Silk.NET.Windows.IOleInPlaceUIWindow value)
    {
        return new IOleInPlaceFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceFrame"/> to <see cref = "Silk.NET.Windows.IOleInPlaceUIWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleInPlaceUIWindow(IOleInPlaceFrame value)
    {
        return new Silk.NET.Windows.IOleInPlaceUIWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IOleInPlaceFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceFrame(Silk.NET.Windows.IOleWindow value)
    {
        return new IOleInPlaceFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceFrame"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IOleInPlaceFrame value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleInPlaceFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleInPlaceFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IOleInPlaceFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleInPlaceFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
