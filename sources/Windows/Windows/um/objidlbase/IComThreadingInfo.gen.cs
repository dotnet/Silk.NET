// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IComThreadingInfo.xml' path='doc/member[@name="IComThreadingInfo"]/*'/>
[Guid("000001CE-0000-0000-C000-000000000046")]
[NativeTypeName("struct IComThreadingInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IComThreadingInfo : IComThreadingInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IComThreadingInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IComThreadingInfo*, Guid*, void**, int> )(lpVtbl[0]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IComThreadingInfo*, uint> )(lpVtbl[1]))((IComThreadingInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IComThreadingInfo*, uint> )(lpVtbl[2]))((IComThreadingInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IComThreadingInfo.xml' path='doc/member[@name="IComThreadingInfo.GetCurrentApartmentType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentApartmentType(APTTYPE* pAptType)
    {
        return ((delegate* unmanaged<IComThreadingInfo*, APTTYPE*, int> )(lpVtbl[3]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pAptType);
    }

    /// <include file='IComThreadingInfo.xml' path='doc/member[@name="IComThreadingInfo.GetCurrentThreadType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentThreadType(THDTYPE* pThreadType)
    {
        return ((delegate* unmanaged<IComThreadingInfo*, THDTYPE*, int> )(lpVtbl[4]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pThreadType);
    }

    /// <include file='IComThreadingInfo.xml' path='doc/member[@name="IComThreadingInfo.GetCurrentLogicalThreadId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentLogicalThreadId(Guid* pguidLogicalThreadId)
    {
        return ((delegate* unmanaged<IComThreadingInfo*, Guid*, int> )(lpVtbl[5]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), pguidLogicalThreadId);
    }

    /// <include file='IComThreadingInfo.xml' path='doc/member[@name="IComThreadingInfo.SetCurrentLogicalThreadId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid)
    {
        return ((delegate* unmanaged<IComThreadingInfo*, Guid*, int> )(lpVtbl[6]))((IComThreadingInfo*)Unsafe.AsPointer(ref this), rguid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentApartmentType(APTTYPE* pAptType);
        [VtblIndex(4)]
        HRESULT GetCurrentThreadType(THDTYPE* pThreadType);
        [VtblIndex(5)]
        HRESULT GetCurrentLogicalThreadId(Guid* pguidLogicalThreadId);
        [VtblIndex(6)]
        HRESULT SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid);
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
        [NativeTypeName("HRESULT (APTTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APTTYPE*, int> GetCurrentApartmentType;
        [NativeTypeName("HRESULT (THDTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, THDTYPE*, int> GetCurrentThreadType;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetCurrentLogicalThreadId;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetCurrentLogicalThreadId;
    }
}