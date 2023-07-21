// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMTunerNotification.xml' path='doc/member[@name="IAMTunerNotification"]/*' />
[Guid("211A8760-03AC-11D1-8D13-00AA00BD8339")]
[NativeTypeName("struct IAMTunerNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTunerNotification : IAMTunerNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTunerNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTunerNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAMTunerNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMTunerNotification*, uint>)(lpVtbl[1]))((IAMTunerNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTunerNotification*, uint>)(lpVtbl[2]))((IAMTunerNotification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMTunerNotification.xml' path='doc/member[@name="IAMTunerNotification.OnEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnEvent(AMTunerEventType Event)
    {
        return ((delegate* unmanaged<IAMTunerNotification*, AMTunerEventType, int>)(lpVtbl[3]))((IAMTunerNotification*)Unsafe.AsPointer(ref this), Event);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnEvent(AMTunerEventType Event);
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

        [NativeTypeName("HRESULT (AMTunerEventType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMTunerEventType, int> OnEvent;
    }
}
