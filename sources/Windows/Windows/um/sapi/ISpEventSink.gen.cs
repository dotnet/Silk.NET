// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpEventSink.xml' path='doc/member[@name="ISpEventSink"]/*'/>
[Guid("BE7A9CC9-5F9E-11D2-960F-00C04F8EE628")]
[NativeTypeName("struct ISpEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpEventSink : ISpEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpEventSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpEventSink*, Guid*, void**, int> )(lpVtbl[0]))((ISpEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpEventSink*, uint> )(lpVtbl[1]))((ISpEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpEventSink*, uint> )(lpVtbl[2]))((ISpEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpEventSink.xml' path='doc/member[@name="ISpEventSink.AddEvents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddEvents([NativeTypeName("const SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<ISpEventSink*, SPEVENT*, uint, int> )(lpVtbl[3]))((ISpEventSink*)Unsafe.AsPointer(ref this), pEventArray, ulCount);
    }

    /// <include file='ISpEventSink.xml' path='doc/member[@name="ISpEventSink.GetEventInterest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEventInterest([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest)
    {
        return ((delegate* unmanaged<ISpEventSink*, ulong*, int> )(lpVtbl[4]))((ISpEventSink*)Unsafe.AsPointer(ref this), pullEventInterest);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddEvents([NativeTypeName("const SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG")] uint ulCount);
        [VtblIndex(4)]
        HRESULT GetEventInterest([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest);
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
        [NativeTypeName("HRESULT (const SPEVENT *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPEVENT*, uint, int> AddEvents;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetEventInterest;
    }
}