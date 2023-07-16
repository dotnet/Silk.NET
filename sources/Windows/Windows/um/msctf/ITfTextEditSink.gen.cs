// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfTextEditSink.xml' path='doc/member[@name="ITfTextEditSink"]/*'/>
[Guid("8127D409-CCD3-4683-967A-B43D5B482BF7")]
[NativeTypeName("struct ITfTextEditSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfTextEditSink : ITfTextEditSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfTextEditSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfTextEditSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfTextEditSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfTextEditSink*, uint> )(lpVtbl[1]))((ITfTextEditSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfTextEditSink*, uint> )(lpVtbl[2]))((ITfTextEditSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfTextEditSink.xml' path='doc/member[@name="ITfTextEditSink.OnEndEdit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnEndEdit(ITfContext* pic, [NativeTypeName("TfEditCookie")] uint ecReadOnly, ITfEditRecord* pEditRecord)
    {
        return ((delegate* unmanaged<ITfTextEditSink*, ITfContext*, uint, ITfEditRecord*, int> )(lpVtbl[3]))((ITfTextEditSink*)Unsafe.AsPointer(ref this), pic, ecReadOnly, pEditRecord);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnEndEdit(ITfContext* pic, [NativeTypeName("TfEditCookie")] uint ecReadOnly, ITfEditRecord* pEditRecord);
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
        [NativeTypeName("HRESULT (ITfContext *, TfEditCookie, ITfEditRecord *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, uint, ITfEditRecord*, int> OnEndEdit;
    }
}