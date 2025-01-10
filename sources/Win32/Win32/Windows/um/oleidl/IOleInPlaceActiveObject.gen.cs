// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000117-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceActiveObject : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IOleInPlaceActiveObject
    : IOleInPlaceActiveObject.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceActiveObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleInPlaceActiveObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, HWND*, int>)((*lpVtbl)[3]))(
            this,
            phwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnterMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, MSG*, int>)((*lpVtbl)[5]))(
            this,
            lpmsg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnFrameWindowActivate(BOOL fActivate)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, BOOL, int>)((*lpVtbl)[6]))(
            this,
            fActivate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnDocWindowActivate(BOOL fActivate)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, BOOL, int>)((*lpVtbl)[7]))(
            this,
            fActivate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResizeBorder(
        [NativeTypeName("LPCRECT")] RECT* prcBorder,
        IOleInPlaceUIWindow pUIWindow,
        BOOL fFrameWindow
    )
    {
        return (
            (delegate* unmanaged<IOleInPlaceActiveObject, RECT*, IOleInPlaceUIWindow, BOOL, int>)(
                (*lpVtbl)[8]
            )
        )(this, prcBorder, pUIWindow, fFrameWindow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject, BOOL, int>)((*lpVtbl)[9]))(
            this,
            fEnable
        );
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg);

        [VtblIndex(6)]
        HRESULT OnFrameWindowActivate(BOOL fActivate);

        [VtblIndex(7)]
        HRESULT OnDocWindowActivate(BOOL fActivate);

        [VtblIndex(8)]
        HRESULT ResizeBorder(
            [NativeTypeName("LPCRECT")] RECT* prcBorder,
            IOleInPlaceUIWindow pUIWindow,
            BOOL fFrameWindow
        );

        [VtblIndex(9)]
        HRESULT EnableModeless(BOOL fEnable);
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

        [NativeTypeName("HRESULT (LPMSG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAccelerator;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> OnFrameWindowActivate;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> OnDocWindowActivate;

        [NativeTypeName("HRESULT (LPCRECT, IOleInPlaceUIWindow *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IOleInPlaceUIWindow, BOOL, int> ResizeBorder;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableModeless;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleInPlaceActiveObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleInPlaceActiveObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IOleInPlaceActiveObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceActiveObject(Silk.NET.Windows.IOleWindow value)
    {
        return new IOleInPlaceActiveObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceActiveObject"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceActiveObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IOleInPlaceActiveObject value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleInPlaceActiveObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleInPlaceActiveObject(Silk.NET.Windows.IUnknown value)
    {
        return new IOleInPlaceActiveObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceActiveObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceActiveObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleInPlaceActiveObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
