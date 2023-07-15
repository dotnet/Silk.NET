// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfCleanupContextSink.xml' path='doc/member[@name="ITfCleanupContextSink"]/*'/>
[Guid("01689689-7ACB-4E9B-AB7C-7EA46B12B522")]
[NativeTypeName("struct ITfCleanupContextSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCleanupContextSink : ITfCleanupContextSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCleanupContextSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCleanupContextSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCleanupContextSink*, uint> )(lpVtbl[1]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCleanupContextSink*, uint> )(lpVtbl[2]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCleanupContextSink.xml' path='doc/member[@name="ITfCleanupContextSink.OnCleanupContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnCleanupContext([NativeTypeName("TfEditCookie")] uint ecWrite, ITfContext* pic)
    {
        return ((delegate* unmanaged<ITfCleanupContextSink*, uint, ITfContext*, int> )(lpVtbl[3]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this), ecWrite, pic);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnCleanupContext([NativeTypeName("TfEditCookie")] uint ecWrite, ITfContext* pic);
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
        [NativeTypeName("HRESULT (TfEditCookie, ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfContext*, int> OnCleanupContext;
    }
}