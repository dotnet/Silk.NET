// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2EB1E945-18B8-4139-9B1A-D5D584818530")]
[NativeTypeName("struct IMFClock : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFClock : IMFClock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFClock));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFClock, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFClock, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFClock, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFClock, uint*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IMFClock, uint, long*, long*, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IMFClock, uint*, int>)((*lpVtbl)[5]))(this, pdwContinuityKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState)
    {
        return ((delegate* unmanaged<IMFClock, uint, MFCLOCK_STATE*, int>)((*lpVtbl)[6]))(
            this,
            dwReserved,
            peClockState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProperties(MFCLOCK_PROPERTIES* pClockProperties)
    {
        return ((delegate* unmanaged<IMFClock, MFCLOCK_PROPERTIES*, int>)((*lpVtbl)[7]))(
            this,
            pClockProperties
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClockCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics);

        [VtblIndex(4)]
        HRESULT GetCorrelatedTime(
            [NativeTypeName("DWORD")] uint dwReserved,
            [NativeTypeName("LONGLONG *")] long* pllClockTime,
            [NativeTypeName("MFTIME *")] long* phnsSystemTime
        );

        [VtblIndex(5)]
        HRESULT GetContinuityKey([NativeTypeName("DWORD *")] uint* pdwContinuityKey);

        [VtblIndex(6)]
        HRESULT GetState([NativeTypeName("DWORD")] uint dwReserved, MFCLOCK_STATE* peClockState);

        [VtblIndex(7)]
        HRESULT GetProperties(MFCLOCK_PROPERTIES* pClockProperties);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFClock"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFClock(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFClock"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFClock(Silk.NET.Windows.IUnknown value)
    {
        return new IMFClock(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFClock"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFClock"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFClock value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
