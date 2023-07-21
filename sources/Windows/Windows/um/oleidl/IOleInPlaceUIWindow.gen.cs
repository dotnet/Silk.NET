// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IOleInPlaceUIWindow.xml' path='doc/member[@name="IOleInPlaceUIWindow"]/*' />
[Guid("00000115-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleInPlaceUIWindow : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IOleInPlaceUIWindow : IOleInPlaceUIWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleInPlaceUIWindow));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, Guid*, void**, int>)(lpVtbl[0]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, uint>)(lpVtbl[1]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, uint>)(lpVtbl[2]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOleWindow.GetWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, HWND*, int>)(lpVtbl[3]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref="IOleWindow.ContextSensitiveHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, BOOL, int>)(lpVtbl[4]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <include file='IOleInPlaceUIWindow.xml' path='doc/member[@name="IOleInPlaceUIWindow.GetBorder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, RECT*, int>)(lpVtbl[5]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), lprectBorder);
    }

    /// <include file='IOleInPlaceUIWindow.xml' path='doc/member[@name="IOleInPlaceUIWindow.RequestBorderSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, RECT*, int>)(lpVtbl[6]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
    }

    /// <include file='IOleInPlaceUIWindow.xml' path='doc/member[@name="IOleInPlaceUIWindow.SetBorderSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, RECT*, int>)(lpVtbl[7]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pborderwidths);
    }

    /// <include file='IOleInPlaceUIWindow.xml' path='doc/member[@name="IOleInPlaceUIWindow.SetActiveObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveObject(IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName)
    {
        return ((delegate* unmanaged<IOleInPlaceUIWindow*, IOleInPlaceActiveObject*, ushort*, int>)(lpVtbl[8]))((IOleInPlaceUIWindow*)Unsafe.AsPointer(ref this), pActiveObject, pszObjName);
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT GetBorder([NativeTypeName("LPRECT")] RECT* lprectBorder);

        [VtblIndex(6)]
        HRESULT RequestBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths);

        [VtblIndex(7)]
        HRESULT SetBorderSpace([NativeTypeName("LPCBORDERWIDTHS")] RECT* pborderwidths);

        [VtblIndex(8)]
        HRESULT SetActiveObject(IOleInPlaceActiveObject* pActiveObject, [NativeTypeName("LPCOLESTR")] ushort* pszObjName);
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
        public delegate* unmanaged<TSelf*, IOleInPlaceActiveObject*, ushort*, int> SetActiveObject;
    }
}
