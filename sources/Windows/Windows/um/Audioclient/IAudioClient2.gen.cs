// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioClient2.xml' path='doc/member[@name="IAudioClient2"]/*'/>
[Guid("726778CD-F60A-4EDA-82DE-E47610CD78AA")]
[NativeTypeName("struct IAudioClient2 : IAudioClient")]
[NativeInheritance("IAudioClient")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAudioClient2 : IAudioClient2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioClient2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioClient2*, Guid*, void**, int> )(lpVtbl[0]))((IAudioClient2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioClient2*, uint> )(lpVtbl[1]))((IAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClient2*, uint> )(lpVtbl[2]))((IAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAudioClient.Initialize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
    {
        return ((delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int> )(lpVtbl[3]))((IAudioClient2*)Unsafe.AsPointer(ref this), ShareMode, StreamFlags, hnsBufferDuration, hnsPeriodicity, pFormat, AudioSessionGuid);
    }

    /// <inheritdoc cref = "IAudioClient.GetBufferSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
    {
        return ((delegate* unmanaged<IAudioClient2*, uint*, int> )(lpVtbl[4]))((IAudioClient2*)Unsafe.AsPointer(ref this), pNumBufferFrames);
    }

    /// <inheritdoc cref = "IAudioClient.GetStreamLatency"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
    {
        return ((delegate* unmanaged<IAudioClient2*, long*, int> )(lpVtbl[5]))((IAudioClient2*)Unsafe.AsPointer(ref this), phnsLatency);
    }

    /// <inheritdoc cref = "IAudioClient.GetCurrentPadding"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
    {
        return ((delegate* unmanaged<IAudioClient2*, uint*, int> )(lpVtbl[6]))((IAudioClient2*)Unsafe.AsPointer(ref this), pNumPaddingFrames);
    }

    /// <inheritdoc cref = "IAudioClient.IsFormatSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, WAVEFORMATEX** ppClosestMatch)
    {
        return ((delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int> )(lpVtbl[7]))((IAudioClient2*)Unsafe.AsPointer(ref this), ShareMode, pFormat, ppClosestMatch);
    }

    /// <inheritdoc cref = "IAudioClient.GetMixFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMixFormat(WAVEFORMATEX** ppDeviceFormat)
    {
        return ((delegate* unmanaged<IAudioClient2*, WAVEFORMATEX**, int> )(lpVtbl[8]))((IAudioClient2*)Unsafe.AsPointer(ref this), ppDeviceFormat);
    }

    /// <inheritdoc cref = "IAudioClient.GetDevicePeriod"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod)
    {
        return ((delegate* unmanaged<IAudioClient2*, long*, long*, int> )(lpVtbl[9]))((IAudioClient2*)Unsafe.AsPointer(ref this), phnsDefaultDevicePeriod, phnsMinimumDevicePeriod);
    }

    /// <inheritdoc cref = "IAudioClient.Start"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IAudioClient2*, int> )(lpVtbl[10]))((IAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAudioClient.Stop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IAudioClient2*, int> )(lpVtbl[11]))((IAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAudioClient.Reset"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IAudioClient2*, int> )(lpVtbl[12]))((IAudioClient2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAudioClient.SetEventHandle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetEventHandle(HANDLE eventHandle)
    {
        return ((delegate* unmanaged<IAudioClient2*, HANDLE, int> )(lpVtbl[13]))((IAudioClient2*)Unsafe.AsPointer(ref this), eventHandle);
    }

    /// <inheritdoc cref = "IAudioClient.GetService"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IAudioClient2*, Guid*, void**, int> )(lpVtbl[14]))((IAudioClient2*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IAudioClient2.xml' path='doc/member[@name="IAudioClient2.IsOffloadCapable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, BOOL* pbOffloadCapable)
    {
        return ((delegate* unmanaged<IAudioClient2*, AUDIO_STREAM_CATEGORY, BOOL*, int> )(lpVtbl[15]))((IAudioClient2*)Unsafe.AsPointer(ref this), Category, pbOffloadCapable);
    }

    /// <include file='IAudioClient2.xml' path='doc/member[@name="IAudioClient2.SetClientProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetClientProperties([NativeTypeName("const AudioClientProperties *")] AudioClientProperties* pProperties)
    {
        return ((delegate* unmanaged<IAudioClient2*, AudioClientProperties*, int> )(lpVtbl[16]))((IAudioClient2*)Unsafe.AsPointer(ref this), pProperties);
    }

    /// <include file='IAudioClient2.xml' path='doc/member[@name="IAudioClient2.GetBufferSizeLimits"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetBufferSizeLimits([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, BOOL bEventDriven, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinBufferDuration, [NativeTypeName("REFERENCE_TIME *")] long* phnsMaxBufferDuration)
    {
        return ((delegate* unmanaged<IAudioClient2*, WAVEFORMATEX*, BOOL, long*, long*, int> )(lpVtbl[17]))((IAudioClient2*)Unsafe.AsPointer(ref this), pFormat, bEventDriven, phnsMinBufferDuration, phnsMaxBufferDuration);
    }

    public interface Interface : IAudioClient.Interface
    {
        [VtblIndex(15)]
        HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, BOOL* pbOffloadCapable);
        [VtblIndex(16)]
        HRESULT SetClientProperties([NativeTypeName("const AudioClientProperties *")] AudioClientProperties* pProperties);
        [VtblIndex(17)]
        HRESULT GetBufferSizeLimits([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, BOOL bEventDriven, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinBufferDuration, [NativeTypeName("REFERENCE_TIME *")] long* phnsMaxBufferDuration);
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
        [NativeTypeName("HRESULT (AUDCLNT_SHAREMODE, DWORD, REFERENCE_TIME, REFERENCE_TIME, const WAVEFORMATEX *, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int> Initialize;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBufferSize;
        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStreamLatency;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentPadding;
        [NativeTypeName("HRESULT (AUDCLNT_SHAREMODE, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int> IsFormatSupported;
        [NativeTypeName("HRESULT (WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX**, int> GetMixFormat;
        [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> GetDevicePeriod;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetEventHandle;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetService;
        [NativeTypeName("HRESULT (AUDIO_STREAM_CATEGORY, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_STREAM_CATEGORY, BOOL*, int> IsOffloadCapable;
        [NativeTypeName("HRESULT (const AudioClientProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioClientProperties*, int> SetClientProperties;
        [NativeTypeName("HRESULT (const WAVEFORMATEX *, BOOL, REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX*, BOOL, long*, long*, int> GetBufferSizeLimits;
    }
}