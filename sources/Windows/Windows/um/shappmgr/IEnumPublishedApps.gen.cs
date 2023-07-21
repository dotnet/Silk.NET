// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumPublishedApps.xml' path='doc/member[@name="IEnumPublishedApps"]/*' />
[Guid("0B124F8C-91F0-11D1-B8B5-006008059382")]
[NativeTypeName("struct IEnumPublishedApps : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumPublishedApps : IEnumPublishedApps.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumPublishedApps));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumPublishedApps*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumPublishedApps*, uint>)(lpVtbl[1]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumPublishedApps*, uint>)(lpVtbl[2]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumPublishedApps.xml' path='doc/member[@name="IEnumPublishedApps.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next(IPublishedApp** pia)
    {
        return ((delegate* unmanaged<IEnumPublishedApps*, IPublishedApp**, int>)(lpVtbl[3]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this), pia);
    }

    /// <include file='IEnumPublishedApps.xml' path='doc/member[@name="IEnumPublishedApps.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumPublishedApps*, int>)(lpVtbl[4]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next(IPublishedApp** pia);

        [VtblIndex(4)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (IPublishedApp **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPublishedApp**, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }
}
