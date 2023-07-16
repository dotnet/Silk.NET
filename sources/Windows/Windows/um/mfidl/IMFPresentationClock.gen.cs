// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock"]/*'/>
[Guid("868CE85C-8EA9-4F55-AB82-B009A910A805")]
[NativeTypeName("struct IMFPresentationClock : IMFClock")]
[NativeInheritance("IMFClock")]
public unsafe partial struct IMFPresentationClock : IMFPresentationClock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPresentationClock));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, Guid*, void**, int> )(lpVtbl[0]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPresentationClock*, uint> )(lpVtbl[1]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPresentationClock*, uint> )(lpVtbl[2]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFClock.GetClockCharacteristics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, uint*, int> )(lpVtbl[3]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    /// <inheritdoc cref = "IMFClock.GetCorrelatedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCorrelatedTime([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LONGLONG *")] long* pllClockTime, [NativeTypeName("MFTIME *")] long* phnsSystemTime)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, uint, long*, long*, int> )(lpVtbl[4]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), dwReserved, pllClockTime, phnsSystemTime);
    }

    /// <inheritdoc cref = "IMFClock.GetContinuityKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, uint*, int> )(lpVtbl[5]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pdwContinuityKey);
    }

    /// <inheritdoc cref = "IMFClock.GetState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, uint, MFCLOCK_STATE*, int> )(lpVtbl[6]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), dwReserved, peClockState);
    }

    /// <inheritdoc cref = "IMFClock.GetProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProperties(MFCLOCK_PROPERTIES* pClockProperties)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, MFCLOCK_PROPERTIES*, int> )(lpVtbl[7]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pClockProperties);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.SetTimeSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTimeSource(IMFPresentationTimeSource* pTimeSource)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, IMFPresentationTimeSource*, int> )(lpVtbl[8]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pTimeSource);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.GetTimeSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTimeSource(IMFPresentationTimeSource** ppTimeSource)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, IMFPresentationTimeSource**, int> )(lpVtbl[9]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), ppTimeSource);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.GetTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetTime([NativeTypeName("MFTIME *")] long* phnsClockTime)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, long*, int> )(lpVtbl[10]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), phnsClockTime);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.AddClockStateSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddClockStateSink(IMFClockStateSink* pStateSink)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, IMFClockStateSink*, int> )(lpVtbl[11]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pStateSink);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.RemoveClockStateSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveClockStateSink(IMFClockStateSink* pStateSink)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, IMFClockStateSink*, int> )(lpVtbl[12]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), pStateSink);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.Start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Start([NativeTypeName("LONGLONG")] long llClockStartOffset)
    {
        return ((delegate* unmanaged<IMFPresentationClock*, long, int> )(lpVtbl[13]))((IMFPresentationClock*)Unsafe.AsPointer(ref this), llClockStartOffset);
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFPresentationClock*, int> )(lpVtbl[14]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPresentationClock.xml' path='doc/member[@name="IMFPresentationClock.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFPresentationClock*, int> )(lpVtbl[15]))((IMFPresentationClock*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFClock.Interface
    {
        [VtblIndex(8)]
        HRESULT SetTimeSource(IMFPresentationTimeSource* pTimeSource);
        [VtblIndex(9)]
        HRESULT GetTimeSource(IMFPresentationTimeSource** ppTimeSource);
        [VtblIndex(10)]
        HRESULT GetTime([NativeTypeName("MFTIME *")] long* phnsClockTime);
        [VtblIndex(11)]
        HRESULT AddClockStateSink(IMFClockStateSink* pStateSink);
        [VtblIndex(12)]
        HRESULT RemoveClockStateSink(IMFClockStateSink* pStateSink);
        [VtblIndex(13)]
        HRESULT Start([NativeTypeName("LONGLONG")] long llClockStartOffset);
        [VtblIndex(14)]
        HRESULT Stop();
        [VtblIndex(15)]
        HRESULT Pause();
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetClockCharacteristics;
        [NativeTypeName("HRESULT (DWORD, LONGLONG *, MFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, long*, long*, int> GetCorrelatedTime;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetContinuityKey;
        [NativeTypeName("HRESULT (DWORD, MFCLOCK_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MFCLOCK_STATE*, int> GetState;
        [NativeTypeName("HRESULT (MFCLOCK_PROPERTIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFCLOCK_PROPERTIES*, int> GetProperties;
        [NativeTypeName("HRESULT (IMFPresentationTimeSource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationTimeSource*, int> SetTimeSource;
        [NativeTypeName("HRESULT (IMFPresentationTimeSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationTimeSource**, int> GetTimeSource;
        [NativeTypeName("HRESULT (MFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetTime;
        [NativeTypeName("HRESULT (IMFClockStateSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFClockStateSink*, int> AddClockStateSink;
        [NativeTypeName("HRESULT (IMFClockStateSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFClockStateSink*, int> RemoveClockStateSink;
        [NativeTypeName("HRESULT (LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> Start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;
    }
}