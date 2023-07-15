// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfKeyTraceEventSink.xml' path='doc/member[@name="ITfKeyTraceEventSink"]/*'/>
[Guid("1CD4C13B-1C36-4191-A70A-7F3E611F367D")]
[NativeTypeName("struct ITfKeyTraceEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfKeyTraceEventSink : ITfKeyTraceEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfKeyTraceEventSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfKeyTraceEventSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfKeyTraceEventSink*, uint> )(lpVtbl[1]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfKeyTraceEventSink*, uint> )(lpVtbl[2]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfKeyTraceEventSink.xml' path='doc/member[@name="ITfKeyTraceEventSink.OnKeyTraceDown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnKeyTraceDown(WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ITfKeyTraceEventSink*, WPARAM, LPARAM, int> )(lpVtbl[3]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this), wParam, lParam);
    }

    /// <include file='ITfKeyTraceEventSink.xml' path='doc/member[@name="ITfKeyTraceEventSink.OnKeyTraceUp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnKeyTraceUp(WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<ITfKeyTraceEventSink*, WPARAM, LPARAM, int> )(lpVtbl[4]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this), wParam, lParam);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnKeyTraceDown(WPARAM wParam, LPARAM lParam);
        [VtblIndex(4)]
        HRESULT OnKeyTraceUp(WPARAM wParam, LPARAM lParam);
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
        [NativeTypeName("HRESULT (WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, int> OnKeyTraceDown;
        [NativeTypeName("HRESULT (WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, int> OnKeyTraceUp;
    }
}