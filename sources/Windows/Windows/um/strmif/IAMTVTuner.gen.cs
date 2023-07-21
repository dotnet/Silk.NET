// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner"]/*' />
[Guid("211A8766-03AC-11D1-8D13-00AA00BD8339")]
[NativeTypeName("struct IAMTVTuner : IAMTuner")]
[NativeInheritance("IAMTuner")]
public unsafe partial struct IAMTVTuner : IAMTVTuner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTVTuner));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTVTuner*, Guid*, void**, int>)(lpVtbl[0]))((IAMTVTuner*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMTVTuner*, uint>)(lpVtbl[1]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTVTuner*, uint>)(lpVtbl[2]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAMTuner.put_Channel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, int, int, int>)(lpVtbl[3]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lChannel, lVideoSubChannel, lAudioSubChannel);
    }

    /// <inheritdoc cref="IAMTuner.get_Channel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int*, int*, int>)(lpVtbl[4]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plChannel, plVideoSubChannel, plAudioSubChannel);
    }

    /// <inheritdoc cref="IAMTuner.ChannelMinMax" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int*, int>)(lpVtbl[5]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lChannelMin, lChannelMax);
    }

    /// <inheritdoc cref="IAMTuner.put_CountryCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_CountryCode([NativeTypeName("long")] int lCountryCode)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, int>)(lpVtbl[6]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lCountryCode);
    }

    /// <inheritdoc cref="IAMTuner.get_CountryCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[7]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plCountryCode);
    }

    /// <inheritdoc cref="IAMTuner.put_TuningSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, int>)(lpVtbl[8]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lTuningSpace);
    }

    /// <inheritdoc cref="IAMTuner.get_TuningSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[9]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plTuningSpace);
    }

    /// <inheritdoc cref="IAMTuner.Logon" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Logon(HANDLE hCurrentUser)
    {
        return ((delegate* unmanaged<IAMTVTuner*, HANDLE, int>)(lpVtbl[10]))((IAMTVTuner*)Unsafe.AsPointer(ref this), hCurrentUser);
    }

    /// <inheritdoc cref="IAMTuner.Logout" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Logout()
    {
        return ((delegate* unmanaged<IAMTVTuner*, int>)(lpVtbl[11]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAMTuner.SignalPresent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[12]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plSignalStrength);
    }

    /// <inheritdoc cref="IAMTuner.put_Mode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Mode(AMTunerModeType lMode)
    {
        return ((delegate* unmanaged<IAMTVTuner*, AMTunerModeType, int>)(lpVtbl[13]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lMode);
    }

    /// <inheritdoc cref="IAMTuner.get_Mode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Mode(AMTunerModeType* plMode)
    {
        return ((delegate* unmanaged<IAMTVTuner*, AMTunerModeType*, int>)(lpVtbl[14]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plMode);
    }

    /// <inheritdoc cref="IAMTuner.GetAvailableModes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetAvailableModes([NativeTypeName("long *")] int* plModes)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[15]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plModes);
    }

    /// <inheritdoc cref="IAMTuner.RegisterNotificationCallBack" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
    {
        return ((delegate* unmanaged<IAMTVTuner*, IAMTunerNotification*, int, int>)(lpVtbl[16]))((IAMTVTuner*)Unsafe.AsPointer(ref this), pNotify, lEvents);
    }

    /// <inheritdoc cref="IAMTuner.UnRegisterNotificationCallBack" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify)
    {
        return ((delegate* unmanaged<IAMTVTuner*, IAMTunerNotification*, int>)(lpVtbl[17]))((IAMTVTuner*)Unsafe.AsPointer(ref this), pNotify);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_AvailableTVFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[18]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_TVFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[19]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plAnalogVideoStandard);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.AutoTune"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AutoTune([NativeTypeName("long")] int lChannel, [NativeTypeName("long *")] int* plFoundSignal)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, int*, int>)(lpVtbl[20]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lChannel, plFoundSignal);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.StoreAutoTune"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT StoreAutoTune()
    {
        return ((delegate* unmanaged<IAMTVTuner*, int>)(lpVtbl[21]))((IAMTVTuner*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_NumInputConnections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_NumInputConnections([NativeTypeName("long *")] int* plNumInputConnections)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[22]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plNumInputConnections);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.put_InputType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_InputType([NativeTypeName("long")] int lIndex, TunerInputType InputType)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, TunerInputType, int>)(lpVtbl[23]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lIndex, InputType);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_InputType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_InputType([NativeTypeName("long")] int lIndex, TunerInputType* pInputType)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, TunerInputType*, int>)(lpVtbl[24]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lIndex, pInputType);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.put_ConnectInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_ConnectInput([NativeTypeName("long")] int lIndex)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int, int>)(lpVtbl[25]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lIndex);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_ConnectInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ConnectInput([NativeTypeName("long *")] int* plIndex)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[26]))((IAMTVTuner*)Unsafe.AsPointer(ref this), plIndex);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_VideoFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_VideoFrequency([NativeTypeName("long *")] int* lFreq)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[27]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lFreq);
    }

    /// <include file='IAMTVTuner.xml' path='doc/member[@name="IAMTVTuner.get_AudioFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_AudioFrequency([NativeTypeName("long *")] int* lFreq)
    {
        return ((delegate* unmanaged<IAMTVTuner*, int*, int>)(lpVtbl[28]))((IAMTVTuner*)Unsafe.AsPointer(ref this), lFreq);
    }

    public interface Interface : IAMTuner.Interface
    {
        [VtblIndex(18)]
        HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard);

        [VtblIndex(19)]
        HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard);

        [VtblIndex(20)]
        HRESULT AutoTune([NativeTypeName("long")] int lChannel, [NativeTypeName("long *")] int* plFoundSignal);

        [VtblIndex(21)]
        HRESULT StoreAutoTune();

        [VtblIndex(22)]
        HRESULT get_NumInputConnections([NativeTypeName("long *")] int* plNumInputConnections);

        [VtblIndex(23)]
        HRESULT put_InputType([NativeTypeName("long")] int lIndex, TunerInputType InputType);

        [VtblIndex(24)]
        HRESULT get_InputType([NativeTypeName("long")] int lIndex, TunerInputType* pInputType);

        [VtblIndex(25)]
        HRESULT put_ConnectInput([NativeTypeName("long")] int lIndex);

        [VtblIndex(26)]
        HRESULT get_ConnectInput([NativeTypeName("long *")] int* plIndex);

        [VtblIndex(27)]
        HRESULT get_VideoFrequency([NativeTypeName("long *")] int* lFreq);

        [VtblIndex(28)]
        HRESULT get_AudioFrequency([NativeTypeName("long *")] int* lFreq);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AvailableTVFormats;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TVFormat;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> AutoTune;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StoreAutoTune;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumInputConnections;

        [NativeTypeName("HRESULT (long, TunerInputType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, TunerInputType, int> put_InputType;

        [NativeTypeName("HRESULT (long, TunerInputType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, TunerInputType*, int> get_InputType;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ConnectInput;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ConnectInput;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VideoFrequency;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AudioFrequency;
    }
}
