// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBPCSatelliteTuner.xml' path='doc/member[@name="IBPCSatelliteTuner"]/*' />
[Guid("211A8765-03AC-11D1-8D13-00AA00BD8339")]
[NativeTypeName("struct IBPCSatelliteTuner : IAMTuner")]
[NativeInheritance("IAMTuner")]
public unsafe partial struct IBPCSatelliteTuner : IBPCSatelliteTuner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBPCSatelliteTuner));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, Guid*, void**, int>)(lpVtbl[0]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, uint>)(lpVtbl[1]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, uint>)(lpVtbl[2]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAMTuner.put_Channel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int, int, int, int>)(lpVtbl[3]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lChannel, lVideoSubChannel, lAudioSubChannel);
    }

    /// <inheritdoc cref="IAMTuner.get_Channel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int*, int*, int>)(lpVtbl[4]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plChannel, plVideoSubChannel, plAudioSubChannel);
    }

    /// <inheritdoc cref="IAMTuner.ChannelMinMax" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int*, int>)(lpVtbl[5]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lChannelMin, lChannelMax);
    }

    /// <inheritdoc cref="IAMTuner.put_CountryCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_CountryCode([NativeTypeName("long")] int lCountryCode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int, int>)(lpVtbl[6]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lCountryCode);
    }

    /// <inheritdoc cref="IAMTuner.get_CountryCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int>)(lpVtbl[7]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plCountryCode);
    }

    /// <inheritdoc cref="IAMTuner.put_TuningSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int, int>)(lpVtbl[8]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lTuningSpace);
    }

    /// <inheritdoc cref="IAMTuner.get_TuningSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int>)(lpVtbl[9]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plTuningSpace);
    }

    /// <inheritdoc cref="IAMTuner.Logon" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Logon(HANDLE hCurrentUser)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, HANDLE, int>)(lpVtbl[10]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), hCurrentUser);
    }

    /// <inheritdoc cref="IAMTuner.Logout" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Logout()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int>)(lpVtbl[11]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAMTuner.SignalPresent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int>)(lpVtbl[12]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plSignalStrength);
    }

    /// <inheritdoc cref="IAMTuner.put_Mode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Mode(AMTunerModeType lMode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, AMTunerModeType, int>)(lpVtbl[13]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lMode);
    }

    /// <inheritdoc cref="IAMTuner.get_Mode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Mode(AMTunerModeType* plMode)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, AMTunerModeType*, int>)(lpVtbl[14]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plMode);
    }

    /// <inheritdoc cref="IAMTuner.GetAvailableModes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetAvailableModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int>)(lpVtbl[15]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plModes);
    }

    /// <inheritdoc cref="IAMTuner.RegisterNotificationCallBack" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, IAMTunerNotification*, int, int>)(lpVtbl[16]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), pNotify, lEvents);
    }

    /// <inheritdoc cref="IAMTuner.UnRegisterNotificationCallBack" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, IAMTunerNotification*, int>)(lpVtbl[17]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), pNotify);
    }

    /// <include file='IBPCSatelliteTuner.xml' path='doc/member[@name="IBPCSatelliteTuner.get_DefaultSubChannelTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DefaultSubChannelTypes([NativeTypeName("long *")] int* plDefaultVideoType, [NativeTypeName("long *")] int* plDefaultAudioType)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int*, int*, int>)(lpVtbl[18]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), plDefaultVideoType, plDefaultAudioType);
    }

    /// <include file='IBPCSatelliteTuner.xml' path='doc/member[@name="IBPCSatelliteTuner.put_DefaultSubChannelTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_DefaultSubChannelTypes([NativeTypeName("long")] int lDefaultVideoType, [NativeTypeName("long")] int lDefaultAudioType)
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int, int, int>)(lpVtbl[19]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this), lDefaultVideoType, lDefaultAudioType);
    }

    /// <include file='IBPCSatelliteTuner.xml' path='doc/member[@name="IBPCSatelliteTuner.IsTapingPermitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsTapingPermitted()
    {
        return ((delegate* unmanaged<IBPCSatelliteTuner*, int>)(lpVtbl[20]))((IBPCSatelliteTuner*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IAMTuner.Interface
    {
        [VtblIndex(18)]
        HRESULT get_DefaultSubChannelTypes([NativeTypeName("long *")] int* plDefaultVideoType, [NativeTypeName("long *")] int* plDefaultAudioType);

        [VtblIndex(19)]
        HRESULT put_DefaultSubChannelTypes([NativeTypeName("long")] int lDefaultVideoType, [NativeTypeName("long")] int lDefaultAudioType);

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
        public delegate* unmanaged<TSelf*, IAMTunerNotification*, int, int> RegisterNotificationCallBack;

        [NativeTypeName("HRESULT (IAMTunerNotification *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAMTunerNotification*, int> UnRegisterNotificationCallBack;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> get_DefaultSubChannelTypes;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> put_DefaultSubChannelTypes;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsTapingPermitted;
    }
}
