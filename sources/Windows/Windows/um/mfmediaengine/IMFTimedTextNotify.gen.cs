// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify"]/*' />
[Guid("DF6B87B6-CE12-45DB-ABA7-432FE054E57D")]
[NativeTypeName("struct IMFTimedTextNotify : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextNotify : IMFTimedTextNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextNotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextNotify*, uint>)(lpVtbl[1]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextNotify*, uint>)(lpVtbl[2]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.TrackAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void TrackAdded([NativeTypeName("DWORD")] uint trackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[3]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.TrackRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void TrackRemoved([NativeTypeName("DWORD")] uint trackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[4]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.TrackSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void TrackSelected([NativeTypeName("DWORD")] uint trackId, BOOL selected)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, BOOL, void>)(lpVtbl[5]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId, selected);
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.TrackReadyStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void TrackReadyStateChanged([NativeTypeName("DWORD")] uint trackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[6]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, HRESULT extendedErrorCode, [NativeTypeName("DWORD")] uint sourceTrackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_ERROR_CODE, HRESULT, uint, void>)(lpVtbl[7]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), errorCode, extendedErrorCode, sourceTrackId);
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.Cue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, IMFTimedTextCue* cue)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue*, void>)(lpVtbl[8]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), cueEvent, currentTime, cue);
    }

    /// <include file='IMFTimedTextNotify.xml' path='doc/member[@name="IMFTimedTextNotify.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Reset()
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, void>)(lpVtbl[9]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void TrackAdded([NativeTypeName("DWORD")] uint trackId);

        [VtblIndex(4)]
        void TrackRemoved([NativeTypeName("DWORD")] uint trackId);

        [VtblIndex(5)]
        void TrackSelected([NativeTypeName("DWORD")] uint trackId, BOOL selected);

        [VtblIndex(6)]
        void TrackReadyStateChanged([NativeTypeName("DWORD")] uint trackId);

        [VtblIndex(7)]
        void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, HRESULT extendedErrorCode, [NativeTypeName("DWORD")] uint sourceTrackId);

        [VtblIndex(8)]
        void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, IMFTimedTextCue* cue);

        [VtblIndex(9)]
        void Reset();
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

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> TrackAdded;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> TrackRemoved;

        [NativeTypeName("void (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, void> TrackSelected;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> TrackReadyStateChanged;

        [NativeTypeName("void (MF_TIMED_TEXT_ERROR_CODE, HRESULT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_ERROR_CODE, HRESULT, uint, void> Error;

        [NativeTypeName("void (MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue*, void> Cue;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Reset;
    }
}
