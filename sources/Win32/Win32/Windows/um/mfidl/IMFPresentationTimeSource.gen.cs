// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7FF12CCE-F76F-41C2-863B-1666C8E5E139")]
[NativeTypeName("struct IMFPresentationTimeSource : IMFClock")]
[NativeInheritance("IMFClock")]
public unsafe partial struct IMFPresentationTimeSource
    : IMFPresentationTimeSource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPresentationTimeSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPresentationTimeSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFPresentationTimeSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPresentationTimeSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFPresentationTimeSource, uint*, int>)((*lpVtbl)[3]))(
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
        return (
            (delegate* unmanaged<IMFPresentationTimeSource, uint, long*, long*, int>)((*lpVtbl)[4])
        )(this, dwReserved, pllClockTime, phnsSystemTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey)
    {
        return ((delegate* unmanaged<IMFPresentationTimeSource, uint*, int>)((*lpVtbl)[5]))(
            this,
            pdwContinuityKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState)
    {
        return (
            (delegate* unmanaged<IMFPresentationTimeSource, uint, MFCLOCK_STATE*, int>)(
                (*lpVtbl)[6]
            )
        )(this, dwReserved, peClockState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProperties(MFCLOCK_PROPERTIES* pClockProperties)
    {
        return (
            (delegate* unmanaged<IMFPresentationTimeSource, MFCLOCK_PROPERTIES*, int>)((*lpVtbl)[7])
        )(this, pClockProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUnderlyingClock(IMFClock* ppClock)
    {
        return ((delegate* unmanaged<IMFPresentationTimeSource, IMFClock*, int>)((*lpVtbl)[8]))(
            this,
            ppClock
        );
    }

    public interface Interface : IMFClock.Interface
    {
        [VtblIndex(8)]
        HRESULT GetUnderlyingClock(IMFClock* ppClock);
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

        [NativeTypeName("HRESULT (IMFClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFClock*, int> GetUnderlyingClock;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFPresentationTimeSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFPresentationTimeSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFClock"/> to <see cref = "IMFPresentationTimeSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFClock"/> instance to be converted </param>
    public static explicit operator IMFPresentationTimeSource(Silk.NET.Windows.IMFClock value)
    {
        return new IMFPresentationTimeSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPresentationTimeSource"/> to <see cref = "Silk.NET.Windows.IMFClock"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPresentationTimeSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFClock(IMFPresentationTimeSource value)
    {
        return new Silk.NET.Windows.IMFClock(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFPresentationTimeSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFPresentationTimeSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMFPresentationTimeSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFPresentationTimeSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFPresentationTimeSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFPresentationTimeSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
