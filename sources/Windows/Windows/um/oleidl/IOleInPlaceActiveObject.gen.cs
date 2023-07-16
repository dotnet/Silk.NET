// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IOleInPlaceActiveObject.xml' path='doc/member[@name="IOleInPlaceActiveObject"]/*'/>
[Guid("00000117-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceActiveObject : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IOleInPlaceActiveObject : IOleInPlaceActiveObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceActiveObject));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, Guid*, void**, int> )(lpVtbl[0]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, uint> )(lpVtbl[1]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, uint> )(lpVtbl[2]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleWindow.GetWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, HWND*, int> )(lpVtbl[3]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref = "IOleWindow.ContextSensitiveHelp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> )(lpVtbl[4]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <include file='IOleInPlaceActiveObject.xml' path='doc/member[@name="IOleInPlaceActiveObject.TranslateAccelerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TranslateAccelerator([NativeTypeName("LPMSG")] MSG* lpmsg)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, MSG*, int> )(lpVtbl[5]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), lpmsg);
    }

    /// <include file='IOleInPlaceActiveObject.xml' path='doc/member[@name="IOleInPlaceActiveObject.OnFrameWindowActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnFrameWindowActivate(BOOL fActivate)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> )(lpVtbl[6]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
    }

    /// <include file='IOleInPlaceActiveObject.xml' path='doc/member[@name="IOleInPlaceActiveObject.OnDocWindowActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnDocWindowActivate(BOOL fActivate)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> )(lpVtbl[7]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fActivate);
    }

    /// <include file='IOleInPlaceActiveObject.xml' path='doc/member[@name="IOleInPlaceActiveObject.ResizeBorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResizeBorder([NativeTypeName("LPCRECT")] RECT* prcBorder, IOleInPlaceUIWindow* pUIWindow, BOOL fFrameWindow)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, RECT*, IOleInPlaceUIWindow*, BOOL, int> )(lpVtbl[8]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), prcBorder, pUIWindow, fFrameWindow);
    }

    /// <include file='IOleInPlaceActiveObject.xml' path='doc/member[@name="IOleInPlaceActiveObject.EnableModeless"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged<IOleInPlaceActiveObject*, BOOL, int> )(lpVtbl[9]))((IOleInPlaceActiveObject*)Unsafe.AsPointer(ref this), fEnable);
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
        HRESULT ResizeBorder([NativeTypeName("LPCRECT")] RECT* prcBorder, IOleInPlaceUIWindow* pUIWindow, BOOL fFrameWindow);
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
        public delegate* unmanaged<TSelf*, RECT*, IOleInPlaceUIWindow*, BOOL, int> ResizeBorder;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableModeless;
    }
}