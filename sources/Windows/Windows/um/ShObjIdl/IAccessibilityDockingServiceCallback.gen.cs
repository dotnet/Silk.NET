// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAccessibilityDockingServiceCallback.xml' path='doc/member[@name="IAccessibilityDockingServiceCallback"]/*' />
[Guid("157733FD-A592-42E5-B594-248468C5A81B")]
[NativeTypeName("struct IAccessibilityDockingServiceCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccessibilityDockingServiceCallback : IAccessibilityDockingServiceCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccessibilityDockingServiceCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, uint>)(lpVtbl[1]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, uint>)(lpVtbl[2]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAccessibilityDockingServiceCallback.xml' path='doc/member[@name="IAccessibilityDockingServiceCallback.Undocked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Undocked(UNDOCK_REASON undockReason)
    {
        return ((delegate* unmanaged<IAccessibilityDockingServiceCallback*, UNDOCK_REASON, int>)(lpVtbl[3]))((IAccessibilityDockingServiceCallback*)Unsafe.AsPointer(ref this), undockReason);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Undocked(UNDOCK_REASON undockReason);
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

        [NativeTypeName("HRESULT (UNDOCK_REASON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UNDOCK_REASON, int> Undocked;
    }
}
