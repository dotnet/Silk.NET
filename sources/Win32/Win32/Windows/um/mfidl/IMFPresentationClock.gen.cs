// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("868CE85C-8EA9-4F55-AB82-B009A910A805")]
[NativeTypeName("struct IMFPresentationClock : IMFClock")]
[NativeInheritance("IMFClock")]
public unsafe partial struct IMFPresentationClock : IMFPresentationClock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPresentationClock));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPresentationClock, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPresentationClock, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPresentationClock, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFPresentationClock, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwCharacteristics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCorrelatedTime(
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("LONGLONG *")] long* pllClockTime,
        [NativeTypeName("MFTIME *")] long* phnsSystemTime
    )
    {
        return ((delegate* unmanaged<IMFPresentationClock, uint, long*, long*, int>)((*lpVtbl)[4]))(
            this,
            dwReserved,
            pllClockTime,
            phnsSystemTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
    {
        return ((delegate* unmanaged<IMFPresentationClock, uint*, int>)((*lpVtbl)[5]))(
            this,
            pdwContinuityKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState)
    {
        return (
            (delegate* unmanaged<IMFPresentationClock, uint, MFCLOCK_STATE*, int>)((*lpVtbl)[6])
        )(this, dwReserved, peClockState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProperties(MFCLOCK_PROPERTIES* pClockProperties)
    {
        return (
            (delegate* unmanaged<IMFPresentationClock, MFCLOCK_PROPERTIES*, int>)((*lpVtbl)[7])
        )(this, pClockProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTimeSource(IMFPresentationTimeSource pTimeSource)
    {
        return (
            (delegate* unmanaged<IMFPresentationClock, IMFPresentationTimeSource, int>)(
                (*lpVtbl)[8]
            )
        )(this, pTimeSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTimeSource(IMFPresentationTimeSource* ppTimeSource)
    {
        return (
            (delegate* unmanaged<IMFPresentationClock, IMFPresentationTimeSource*, int>)(
                (*lpVtbl)[9]
            )
        )(this, ppTimeSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetTime([NativeTypeName("MFTIME *")] long* phnsClockTime)
    {
        return ((delegate* unmanaged<IMFPresentationClock, long*, int>)((*lpVtbl)[10]))(
            this,
            phnsClockTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddClockStateSink(IMFClockStateSink pStateSink)
    {
        return ((delegate* unmanaged<IMFPresentationClock, IMFClockStateSink, int>)((*lpVtbl)[11]))(
            this,
            pStateSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveClockStateSink(IMFClockStateSink pStateSink)
    {
        return ((delegate* unmanaged<IMFPresentationClock, IMFClockStateSink, int>)((*lpVtbl)[12]))(
            this,
            pStateSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Start([NativeTypeName("LONGLONG")] long llClockStartOffset)
    {
        return ((delegate* unmanaged<IMFPresentationClock, long, int>)((*lpVtbl)[13]))(
            this,
            llClockStartOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFPresentationClock, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFPresentationClock, int>)((*lpVtbl)[15]))(this);
    }

    public interface Interface : IMFClock.Interface
    {
        [VtblIndex(8)]
        HRESULT SetTimeSource(IMFPresentationTimeSource pTimeSource);

        [VtblIndex(9)]
        HRESULT GetTimeSource(IMFPresentationTimeSource* ppTimeSource);

        [VtblIndex(10)]
        HRESULT GetTime([NativeTypeName("MFTIME *")] long* phnsClockTime);

        [VtblIndex(11)]
        HRESULT AddClockStateSink(IMFClockStateSink pStateSink);

        [VtblIndex(12)]
        HRESULT RemoveClockStateSink(IMFClockStateSink pStateSink);

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
        public delegate* unmanaged<TSelf*, IMFPresentationTimeSource, int> SetTimeSource;

        [NativeTypeName("HRESULT (IMFPresentationTimeSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationTimeSource*, int> GetTimeSource;

        [NativeTypeName("HRESULT (MFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetTime;

        [NativeTypeName("HRESULT (IMFClockStateSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFClockStateSink, int> AddClockStateSink;

        [NativeTypeName("HRESULT (IMFClockStateSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFClockStateSink, int> RemoveClockStateSink;

        [NativeTypeName("HRESULT (LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFPresentationClock"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFPresentationClock(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFClock"/> to <see cref = "IMFPresentationClock"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFClock"/> instance to be converted </param>
    public static explicit operator IMFPresentationClock(Silk.NET.Windows.IMFClock value)
    {
        return new IMFPresentationClock(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPresentationClock"/> to <see cref = "Silk.NET.Windows.IMFClock"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPresentationClock"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFClock(IMFPresentationClock value)
    {
        return new Silk.NET.Windows.IMFClock(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFPresentationClock"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFPresentationClock(Silk.NET.Windows.IUnknown value)
    {
        return new IMFPresentationClock(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPresentationClock"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPresentationClock"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFPresentationClock value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
