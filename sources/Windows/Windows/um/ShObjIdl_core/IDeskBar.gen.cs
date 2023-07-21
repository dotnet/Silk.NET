// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDeskBar.xml' path='doc/member[@name="IDeskBar"]/*' />
[Guid("EB0FE173-1A3A-11D0-89B3-00A0C90A90AC")]
[NativeTypeName("struct IDeskBar : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IDeskBar : IDeskBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBar));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBar*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeskBar*, uint>)(lpVtbl[1]))((IDeskBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBar*, uint>)(lpVtbl[2]))((IDeskBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOleWindow.GetWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDeskBar*, HWND*, int>)(lpVtbl[3]))((IDeskBar*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref="IOleWindow.ContextSensitiveHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDeskBar*, BOOL, int>)(lpVtbl[4]))((IDeskBar*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <include file='IDeskBar.xml' path='doc/member[@name="IDeskBar.SetClient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetClient(IUnknown* punkClient)
    {
        return ((delegate* unmanaged<IDeskBar*, IUnknown*, int>)(lpVtbl[5]))((IDeskBar*)Unsafe.AsPointer(ref this), punkClient);
    }

    /// <include file='IDeskBar.xml' path='doc/member[@name="IDeskBar.GetClient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetClient(IUnknown** ppunkClient)
    {
        return ((delegate* unmanaged<IDeskBar*, IUnknown**, int>)(lpVtbl[6]))((IDeskBar*)Unsafe.AsPointer(ref this), ppunkClient);
    }

    /// <include file='IDeskBar.xml' path='doc/member[@name="IDeskBar.OnPosRectChangeDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPosRectChangeDB(RECT* prc)
    {
        return ((delegate* unmanaged<IDeskBar*, RECT*, int>)(lpVtbl[7]))((IDeskBar*)Unsafe.AsPointer(ref this), prc);
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT SetClient(IUnknown* punkClient);

        [VtblIndex(6)]
        HRESULT GetClient(IUnknown** ppunkClient);

        [VtblIndex(7)]
        HRESULT OnPosRectChangeDB(RECT* prc);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetClient;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> GetClient;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnPosRectChangeDB;
    }
}
