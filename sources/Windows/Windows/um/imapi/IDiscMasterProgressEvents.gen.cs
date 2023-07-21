// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents"]/*' />
[Guid("EC9E51C1-4E5D-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IDiscMasterProgressEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiscMasterProgressEvents : IDiscMasterProgressEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscMasterProgressEvents));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, Guid*, void**, int>)(lpVtbl[0]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, uint>)(lpVtbl[1]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, uint>)(lpVtbl[2]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.QueryCancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryCancel([NativeTypeName("boolean *")] byte* pbCancel)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, byte*, int>)(lpVtbl[3]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), pbCancel);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyPnPActivity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyPnPActivity()
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, int>)(lpVtbl[4]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyAddProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NotifyAddProgress([NativeTypeName("long")] int nCompletedSteps, [NativeTypeName("long")] int nTotalSteps)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int, int>)(lpVtbl[5]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nCompletedSteps, nTotalSteps);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyBlockProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT NotifyBlockProgress([NativeTypeName("long")] int nCompleted, [NativeTypeName("long")] int nTotal)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int, int>)(lpVtbl[6]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nCompleted, nTotal);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyTrackProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NotifyTrackProgress([NativeTypeName("long")] int nCurrentTrack, [NativeTypeName("long")] int nTotalTracks)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int, int>)(lpVtbl[7]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nCurrentTrack, nTotalTracks);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyPreparingBurn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT NotifyPreparingBurn([NativeTypeName("long")] int nEstimatedSeconds)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int>)(lpVtbl[8]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nEstimatedSeconds);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyClosingDisc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT NotifyClosingDisc([NativeTypeName("long")] int nEstimatedSeconds)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, int, int>)(lpVtbl[9]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), nEstimatedSeconds);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyBurnComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT NotifyBurnComplete(HRESULT status)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, HRESULT, int>)(lpVtbl[10]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IDiscMasterProgressEvents.xml' path='doc/member[@name="IDiscMasterProgressEvents.NotifyEraseComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT NotifyEraseComplete(HRESULT status)
    {
        return ((delegate* unmanaged<IDiscMasterProgressEvents*, HRESULT, int>)(lpVtbl[11]))((IDiscMasterProgressEvents*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryCancel([NativeTypeName("boolean *")] byte* pbCancel);

        [VtblIndex(4)]
        HRESULT NotifyPnPActivity();

        [VtblIndex(5)]
        HRESULT NotifyAddProgress([NativeTypeName("long")] int nCompletedSteps, [NativeTypeName("long")] int nTotalSteps);

        [VtblIndex(6)]
        HRESULT NotifyBlockProgress([NativeTypeName("long")] int nCompleted, [NativeTypeName("long")] int nTotal);

        [VtblIndex(7)]
        HRESULT NotifyTrackProgress([NativeTypeName("long")] int nCurrentTrack, [NativeTypeName("long")] int nTotalTracks);

        [VtblIndex(8)]
        HRESULT NotifyPreparingBurn([NativeTypeName("long")] int nEstimatedSeconds);

        [VtblIndex(9)]
        HRESULT NotifyClosingDisc([NativeTypeName("long")] int nEstimatedSeconds);

        [VtblIndex(10)]
        HRESULT NotifyBurnComplete(HRESULT status);

        [VtblIndex(11)]
        HRESULT NotifyEraseComplete(HRESULT status);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> QueryCancel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyPnPActivity;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> NotifyAddProgress;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> NotifyBlockProgress;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> NotifyTrackProgress;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> NotifyPreparingBurn;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> NotifyClosingDisc;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> NotifyBurnComplete;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> NotifyEraseComplete;
    }
}
