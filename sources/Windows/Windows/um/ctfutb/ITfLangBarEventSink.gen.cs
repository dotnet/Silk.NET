// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink"]/*' />
[Guid("18A4E900-E0AE-11D2-AFDD-00105A2799B5")]
[NativeTypeName("struct ITfLangBarEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLangBarEventSink : ITfLangBarEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLangBarEventSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint>)(lpVtbl[1]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint>)(lpVtbl[2]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink.OnSetFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSetFocus([NativeTypeName("DWORD")] uint dwThreadId)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[3]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId);
    }

    /// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink.OnThreadTerminate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnThreadTerminate([NativeTypeName("DWORD")] uint dwThreadId)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[4]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId);
    }

    /// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink.OnThreadItemChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnThreadItemChange([NativeTypeName("DWORD")] uint dwThreadId)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[5]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId);
    }

    /// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink.OnModalInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnModalInput([NativeTypeName("DWORD")] uint dwThreadId, uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint, uint, WPARAM, LPARAM, int>)(lpVtbl[6]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId, uMsg, wParam, lParam);
    }

    /// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink.ShowFloating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowFloating([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[7]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='ITfLangBarEventSink.xml' path='doc/member[@name="ITfLangBarEventSink.GetItemFloatingRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetItemFloatingRect([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const GUID &")] Guid* rguid, RECT* prc)
    {
        return ((delegate* unmanaged<ITfLangBarEventSink*, uint, Guid*, RECT*, int>)(lpVtbl[8]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId, rguid, prc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnSetFocus([NativeTypeName("DWORD")] uint dwThreadId);

        [VtblIndex(4)]
        HRESULT OnThreadTerminate([NativeTypeName("DWORD")] uint dwThreadId);

        [VtblIndex(5)]
        HRESULT OnThreadItemChange([NativeTypeName("DWORD")] uint dwThreadId);

        [VtblIndex(6)]
        HRESULT OnModalInput([NativeTypeName("DWORD")] uint dwThreadId, uint uMsg, WPARAM wParam, LPARAM lParam);

        [VtblIndex(7)]
        HRESULT ShowFloating([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(8)]
        HRESULT GetItemFloatingRect([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const GUID &")] Guid* rguid, RECT* prc);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnSetFocus;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnThreadTerminate;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnThreadItemChange;

        [NativeTypeName("HRESULT (DWORD, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, WPARAM, LPARAM, int> OnModalInput;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ShowFloating;

        [NativeTypeName("HRESULT (DWORD, const GUID &, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, RECT*, int> GetItemFloatingRect;
    }
}
