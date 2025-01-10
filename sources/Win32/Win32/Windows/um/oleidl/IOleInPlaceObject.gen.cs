// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000113-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceObject : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IOleInPlaceObject : IOleInPlaceObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleInPlaceObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceObject, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceObject, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnterMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InPlaceDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceObject, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UIDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceObject, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetObjectRects(
        [NativeTypeName("LPCRECT")] RECT* lprcPosRect,
        [NativeTypeName("LPCRECT")] RECT* lprcClipRect
    )
    {
        return ((delegate* unmanaged<IOleInPlaceObject, RECT*, RECT*, int>)((*lpVtbl)[7]))(
            this,
            lprcPosRect,
            lprcClipRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReactivateAndUndo()
    {
        return ((delegate* unmanaged<IOleInPlaceObject, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT InPlaceDeactivate();

        [VtblIndex(6)]
        HRESULT UIDeactivate();

        [VtblIndex(7)]
        HRESULT SetObjectRects(
            [NativeTypeName("LPCRECT")] RECT* lprcPosRect,
            [NativeTypeName("LPCRECT")] RECT* lprcClipRect
        );

        [VtblIndex(8)]
        HRESULT ReactivateAndUndo();
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
        public delegate* unmanaged<TSelf*, int> InPlaceDeactivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UIDeactivate;

        [NativeTypeName("HRESULT (LPCRECT, LPCRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> SetObjectRects;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReactivateAndUndo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleInPlaceObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleInPlaceObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IOleInPlaceObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IOleInPlaceObject(Silk.NET.Windows.IOleWindow value)
    {
        return new IOleInPlaceObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceObject"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IOleInPlaceObject value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleInPlaceObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleInPlaceObject(Silk.NET.Windows.IUnknown value)
    {
        return new IOleInPlaceObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleInPlaceObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleInPlaceObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleInPlaceObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
