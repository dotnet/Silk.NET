// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfCompositionSink.xml' path='doc/member[@name="ITfCompositionSink"]/*'/>
[Guid("A781718C-579A-4B15-A280-32B8577ACC5E")]
[NativeTypeName("struct ITfCompositionSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCompositionSink : ITfCompositionSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCompositionSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCompositionSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfCompositionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCompositionSink*, uint> )(lpVtbl[1]))((ITfCompositionSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCompositionSink*, uint> )(lpVtbl[2]))((ITfCompositionSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCompositionSink.xml' path='doc/member[@name="ITfCompositionSink.OnCompositionTerminated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnCompositionTerminated([NativeTypeName("TfEditCookie")] uint ecWrite, ITfComposition* pComposition)
    {
        return ((delegate* unmanaged<ITfCompositionSink*, uint, ITfComposition*, int> )(lpVtbl[3]))((ITfCompositionSink*)Unsafe.AsPointer(ref this), ecWrite, pComposition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnCompositionTerminated([NativeTypeName("TfEditCookie")] uint ecWrite, ITfComposition* pComposition);
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
        [NativeTypeName("HRESULT (TfEditCookie, ITfComposition *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfComposition*, int> OnCompositionTerminated;
    }
}