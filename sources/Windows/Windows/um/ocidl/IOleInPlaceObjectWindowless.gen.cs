// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IOleInPlaceObjectWindowless.xml' path='doc/member[@name="IOleInPlaceObjectWindowless"]/*'/>
[Guid("1C2056CC-5EF4-101B-8BC8-00AA003E3B29")]
[NativeTypeName("struct IOleInPlaceObjectWindowless : IOleInPlaceObject")]
[NativeInheritance("IOleInPlaceObject")]
public unsafe partial struct IOleInPlaceObjectWindowless : IOleInPlaceObjectWindowless.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceObjectWindowless));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, Guid*, void**, int> )(lpVtbl[0]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, uint> )(lpVtbl[1]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, uint> )(lpVtbl[2]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleWindow.GetWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, HWND*, int> )(lpVtbl[3]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref = "IOleWindow.ContextSensitiveHelp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, BOOL, int> )(lpVtbl[4]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <inheritdoc cref = "IOleInPlaceObject.InPlaceDeactivate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InPlaceDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, int> )(lpVtbl[5]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleInPlaceObject.UIDeactivate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UIDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, int> )(lpVtbl[6]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleInPlaceObject.SetObjectRects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetObjectRects([NativeTypeName("LPCRECT")] RECT* lprcPosRect, [NativeTypeName("LPCRECT")] RECT* lprcClipRect)
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, RECT*, RECT*, int> )(lpVtbl[7]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), lprcPosRect, lprcClipRect);
    }

    /// <inheritdoc cref = "IOleInPlaceObject.ReactivateAndUndo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReactivateAndUndo()
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, int> )(lpVtbl[8]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceObjectWindowless.xml' path='doc/member[@name="IOleInPlaceObjectWindowless.OnWindowMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnWindowMessage(uint msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult)
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, uint, WPARAM, LPARAM, LRESULT*, int> )(lpVtbl[9]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), msg, wParam, lParam, plResult);
    }

    /// <include file='IOleInPlaceObjectWindowless.xml' path='doc/member[@name="IOleInPlaceObjectWindowless.GetDropTarget"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDropTarget(IDropTarget** ppDropTarget)
    {
        return ((delegate* unmanaged<IOleInPlaceObjectWindowless*, IDropTarget**, int> )(lpVtbl[10]))((IOleInPlaceObjectWindowless*)Unsafe.AsPointer(ref this), ppDropTarget);
    }

    public interface Interface : IOleInPlaceObject.Interface
    {
        [VtblIndex(9)]
        HRESULT OnWindowMessage(uint msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult);
        [VtblIndex(10)]
        HRESULT GetDropTarget(IDropTarget** ppDropTarget);
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
        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, LRESULT*, int> OnWindowMessage;
        [NativeTypeName("HRESULT (IDropTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDropTarget**, int> GetDropTarget;
    }
}