// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfTextLayoutSink.xml' path='doc/member[@name="ITfTextLayoutSink"]/*' />
[Guid("2AF2D06A-DD5B-4927-A0B4-54F19C91FADE")]
[NativeTypeName("struct ITfTextLayoutSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfTextLayoutSink : ITfTextLayoutSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfTextLayoutSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfTextLayoutSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfTextLayoutSink*, uint>)(lpVtbl[1]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfTextLayoutSink*, uint>)(lpVtbl[2]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfTextLayoutSink.xml' path='doc/member[@name="ITfTextLayoutSink.OnLayoutChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnLayoutChange(ITfContext* pic, TfLayoutCode lcode, ITfContextView* pView)
    {
        return ((delegate* unmanaged<ITfTextLayoutSink*, ITfContext*, TfLayoutCode, ITfContextView*, int>)(lpVtbl[3]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this), pic, lcode, pView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnLayoutChange(ITfContext* pic, TfLayoutCode lcode, ITfContextView* pView);
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

        [NativeTypeName("HRESULT (ITfContext *, TfLayoutCode, ITfContextView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, TfLayoutCode, ITfContextView*, int> OnLayoutChange;
    }
}
