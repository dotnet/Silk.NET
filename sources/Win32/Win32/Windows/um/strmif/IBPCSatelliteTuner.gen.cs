// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("211A8765-03AC-11D1-8D13-00AA00BD8339")]
[NativeTypeName("struct IBPCSatelliteTuner : IAMTuner")]
[NativeInheritance("IAMTuner")]
public unsafe partial struct IBPCSatelliteTuner : IBPCSatelliteTuner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBPCSatelliteTuner));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBPCSatelliteTuner, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_Channel(
        [NativeTypeName("long")] int lChannel,
        [NativeTypeName("long")] int lVideoSubChannel,
        [NativeTypeName("long")] int lAudioSubChannel
    )
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int, int, int, int>)((*lpVtbl)[3]))(
            this,
            lChannel,
            lVideoSubChannel,
            lAudioSubChannel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Channel(
        [NativeTypeName("long *")] int* plChannel,
        [NativeTypeName("long *")] int* plVideoSubChannel,
        [NativeTypeName("long *")] int* plAudioSubChannel
    )
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int*, int*, int>)((*lpVtbl)[4]))(
            this,
            plChannel,
            plVideoSubChannel,
            plAudioSubChannel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ChannelMinMax(
        [NativeTypeName("long *")] int* lChannelMin,
        [NativeTypeName("long *")] int* lChannelMax
    )
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int*, int>)((*lpVtbl)[5]))(
            this,
            lChannelMin,
            lChannelMax
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_CountryCode([NativeTypeName("long")] int lCountryCode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int, int>)((*lpVtbl)[6]))(
            this,
            lCountryCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int>)((*lpVtbl)[7]))(
            this,
            plCountryCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int, int>)((*lpVtbl)[8]))(
            this,
            lTuningSpace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int>)((*lpVtbl)[9]))(
            this,
            plTuningSpace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Logon(HANDLE hCurrentUser)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, HANDLE, int>)((*lpVtbl)[10]))(
            this,
            hCurrentUser
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Logout()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int>)((*lpVtbl)[12]))(
            this,
            plSignalStrength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Mode(AMTunerModeType lMode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, AMTunerModeType, int>)((*lpVtbl)[13]))(
            this,
            lMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Mode(AMTunerModeType* plMode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, AMTunerModeType*, int>)((*lpVtbl)[14]))(
            this,
            plMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetAvailableModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int>)((*lpVtbl)[15]))(this, plModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterNotificationCallBack(
        IAMTunerNotification pNotify,
        [NativeTypeName("long")] int lEvents
    )
    {
        return (
            (delegate* unmanaged<IBPCSatelliteTuner, IAMTunerNotification, int, int>)((*lpVtbl)[16])
        )(this, pNotify, lEvents);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification pNotify)
    {
        return (
            (delegate* unmanaged<IBPCSatelliteTuner, IAMTunerNotification, int>)((*lpVtbl)[17])
        )(this, pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DefaultSubChannelTypes(
        [NativeTypeName("long *")] int* plDefaultVideoType,
        [NativeTypeName("long *")] int* plDefaultAudioType
    )
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int*, int*, int>)((*lpVtbl)[18]))(
            this,
            plDefaultVideoType,
            plDefaultAudioType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_DefaultSubChannelTypes(
        [NativeTypeName("long")] int lDefaultVideoType,
        [NativeTypeName("long")] int lDefaultAudioType
    )
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int, int, int>)((*lpVtbl)[19]))(
            this,
            lDefaultVideoType,
            lDefaultAudioType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsTapingPermitted()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner, int>)((*lpVtbl)[20]))(this);
    }

    public interface Interface : IAMTuner.Interface
    {
        [VtblIndex(18)]
        HRESULT get_DefaultSubChannelTypes(
            [NativeTypeName("long *")] int* plDefaultVideoType,
            [NativeTypeName("long *")] int* plDefaultAudioType
        );

        [VtblIndex(19)]
        HRESULT put_DefaultSubChannelTypes(
            [NativeTypeName("long")] int lDefaultVideoType,
            [NativeTypeName("long")] int lDefaultAudioType
        );

        [VtblIndex(20)]
        HRESULT IsTapingPermitted();
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

        [NativeTypeName("HRESULT (long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int> put_Channel;

        [NativeTypeName("HRESULT (long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int> get_Channel;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> ChannelMinMax;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_CountryCode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CountryCode;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_TuningSpace;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TuningSpace;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> Logon;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Logout;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> SignalPresent;

        [NativeTypeName("HRESULT (AMTunerModeType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMTunerModeType, int> put_Mode;

        [NativeTypeName("HRESULT (AMTunerModeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMTunerModeType*, int> get_Mode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetAvailableModes;

        [NativeTypeName("HRESULT (IAMTunerNotification *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAMTunerNotification,
            int,
            int> RegisterNotificationCallBack;

        [NativeTypeName("HRESULT (IAMTunerNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IAMTunerNotification,
            int> UnRegisterNotificationCallBack;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> get_DefaultSubChannelTypes;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> put_DefaultSubChannelTypes;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsTapingPermitted;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBPCSatelliteTuner"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBPCSatelliteTuner(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAMTuner"/> to <see cref = "IBPCSatelliteTuner"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAMTuner"/> instance to be converted </param>
    public static explicit operator IBPCSatelliteTuner(Silk.NET.Windows.IAMTuner value)
    {
        return new IBPCSatelliteTuner(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBPCSatelliteTuner"/> to <see cref = "Silk.NET.Windows.IAMTuner"/>.</summary>
    /// <param name = "value">The <see cref = "IBPCSatelliteTuner"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAMTuner(IBPCSatelliteTuner value)
    {
        return new Silk.NET.Windows.IAMTuner(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBPCSatelliteTuner"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBPCSatelliteTuner(Silk.NET.Windows.IUnknown value)
    {
        return new IBPCSatelliteTuner(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBPCSatelliteTuner"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBPCSatelliteTuner"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBPCSatelliteTuner value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
