// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite"]/*'/>
[Guid("00000119-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceSite : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IOleInPlaceSite : IOleInPlaceSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, Guid*, void**, int> )(lpVtbl[0]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, uint> )(lpVtbl[1]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, uint> )(lpVtbl[2]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleWindow.GetWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, HWND*, int> )(lpVtbl[3]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref = "IOleWindow.ContextSensitiveHelp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, BOOL, int> )(lpVtbl[4]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.CanInPlaceActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CanInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, int> )(lpVtbl[5]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.OnInPlaceActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnInPlaceActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, int> )(lpVtbl[6]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.OnUIActivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnUIActivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, int> )(lpVtbl[7]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.GetWindowContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWindowContext(IOleInPlaceFrame** ppFrame, IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int> )(lpVtbl[8]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), ppFrame, ppDoc, lprcPosRect, lprcClipRect, lpFrameInfo);
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.Scroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Scroll(SIZE scrollExtant)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, SIZE, int> )(lpVtbl[9]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), scrollExtant);
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.OnUIDeactivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnUIDeactivate(BOOL fUndoable)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, BOOL, int> )(lpVtbl[10]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), fUndoable);
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.OnInPlaceDeactivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnInPlaceDeactivate()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, int> )(lpVtbl[11]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.DiscardUndoState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DiscardUndoState()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, int> )(lpVtbl[12]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.DeactivateAndUndo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeactivateAndUndo()
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, int> )(lpVtbl[13]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleInPlaceSite.xml' path='doc/member[@name="IOleInPlaceSite.OnPosRectChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OnPosRectChange([NativeTypeName("LPCRECT")] RECT* lprcPosRect)
    {
        return ((delegate* unmanaged<IOleInPlaceSite*, RECT*, int> )(lpVtbl[14]))((IOleInPlaceSite*)Unsafe.AsPointer(ref this), lprcPosRect);
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
        HRESULT GetWindowContext(IOleInPlaceFrame** ppFrame, IOleInPlaceUIWindow** ppDoc, [NativeTypeName("LPRECT")] RECT* lprcPosRect, [NativeTypeName("LPRECT")] RECT* lprcClipRect, [NativeTypeName("LPOLEINPLACEFRAMEINFO")] OLEINPLACEFRAMEINFO* lpFrameInfo);
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
        [NativeTypeName("HRESULT (IOleInPlaceFrame **, IOleInPlaceUIWindow **, LPRECT, LPRECT, LPOLEINPLACEFRAMEINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleInPlaceFrame**, IOleInPlaceUIWindow**, RECT*, RECT*, OLEINPLACEFRAMEINFO*, int> GetWindowContext;
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
}