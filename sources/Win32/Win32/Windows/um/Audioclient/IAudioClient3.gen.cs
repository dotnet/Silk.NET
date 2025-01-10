// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7ED4EE07-8E67-4CD4-8C1A-2B7A5987AD42")]
[NativeTypeName("struct IAudioClient3 : IAudioClient2")]
[NativeInheritance("IAudioClient2")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAudioClient3 : IAudioClient3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioClient3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioClient3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioClient3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClient3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        AUDCLNT_SHAREMODE ShareMode,
        [NativeTypeName("DWORD")] uint StreamFlags,
        [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration,
        [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
        [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid
    )
    {
        return (
            (delegate* unmanaged<
                IAudioClient3,
                AUDCLNT_SHAREMODE,
                uint,
                long,
                long,
                WAVEFORMATEX*,
                Guid*,
                int>)((*lpVtbl)[3])
        )(
            this,
            ShareMode,
            StreamFlags,
            hnsBufferDuration,
            hnsPeriodicity,
            pFormat,
            AudioSessionGuid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
    {
        return ((delegate* unmanaged<IAudioClient3, uint*, int>)((*lpVtbl)[4]))(
            this,
            pNumBufferFrames
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
    {
        return ((delegate* unmanaged<IAudioClient3, long*, int>)((*lpVtbl)[5]))(this, phnsLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
    {
        return ((delegate* unmanaged<IAudioClient3, uint*, int>)((*lpVtbl)[6]))(
            this,
            pNumPaddingFrames
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsFormatSupported(
        AUDCLNT_SHAREMODE ShareMode,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
        WAVEFORMATEX** ppClosestMatch
    )
    {
        return (
            (delegate* unmanaged<
                IAudioClient3,
                AUDCLNT_SHAREMODE,
                WAVEFORMATEX*,
                WAVEFORMATEX**,
                int>)((*lpVtbl)[7])
        )(this, ShareMode, pFormat, ppClosestMatch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMixFormat(WAVEFORMATEX** ppDeviceFormat)
    {
        return ((delegate* unmanaged<IAudioClient3, WAVEFORMATEX**, int>)((*lpVtbl)[8]))(
            this,
            ppDeviceFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDevicePeriod(
        [NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod,
        [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod
    )
    {
        return ((delegate* unmanaged<IAudioClient3, long*, long*, int>)((*lpVtbl)[9]))(
            this,
            phnsDefaultDevicePeriod,
            phnsMinimumDevicePeriod
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IAudioClient3, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IAudioClient3, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IAudioClient3, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetEventHandle(HANDLE eventHandle)
    {
        return ((delegate* unmanaged<IAudioClient3, HANDLE, int>)((*lpVtbl)[13]))(
            this,
            eventHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IAudioClient3, Guid*, void**, int>)((*lpVtbl)[14]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, BOOL* pbOffloadCapable)
    {
        return (
            (delegate* unmanaged<IAudioClient3, AUDIO_STREAM_CATEGORY, BOOL*, int>)((*lpVtbl)[15])
        )(this, Category, pbOffloadCapable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetClientProperties(
        [NativeTypeName("const AudioClientProperties *")] AudioClientProperties* pProperties
    )
    {
        return ((delegate* unmanaged<IAudioClient3, AudioClientProperties*, int>)((*lpVtbl)[16]))(
            this,
            pProperties
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetBufferSizeLimits(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
        BOOL bEventDriven,
        [NativeTypeName("REFERENCE_TIME *")] long* phnsMinBufferDuration,
        [NativeTypeName("REFERENCE_TIME *")] long* phnsMaxBufferDuration
    )
    {
        return (
            (delegate* unmanaged<IAudioClient3, WAVEFORMATEX*, BOOL, long*, long*, int>)(
                (*lpVtbl)[17]
            )
        )(this, pFormat, bEventDriven, phnsMinBufferDuration, phnsMaxBufferDuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSharedModeEnginePeriod(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
        [NativeTypeName("UINT32 *")] uint* pDefaultPeriodInFrames,
        [NativeTypeName("UINT32 *")] uint* pFundamentalPeriodInFrames,
        [NativeTypeName("UINT32 *")] uint* pMinPeriodInFrames,
        [NativeTypeName("UINT32 *")] uint* pMaxPeriodInFrames
    )
    {
        return (
            (delegate* unmanaged<IAudioClient3, WAVEFORMATEX*, uint*, uint*, uint*, uint*, int>)(
                (*lpVtbl)[18]
            )
        )(
            this,
            pFormat,
            pDefaultPeriodInFrames,
            pFundamentalPeriodInFrames,
            pMinPeriodInFrames,
            pMaxPeriodInFrames
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetCurrentSharedModeEnginePeriod(
        WAVEFORMATEX** ppFormat,
        [NativeTypeName("UINT32 *")] uint* pCurrentPeriodInFrames
    )
    {
        return ((delegate* unmanaged<IAudioClient3, WAVEFORMATEX**, uint*, int>)((*lpVtbl)[19]))(
            this,
            ppFormat,
            pCurrentPeriodInFrames
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT InitializeSharedAudioStream(
        [NativeTypeName("DWORD")] uint StreamFlags,
        [NativeTypeName("UINT32")] uint PeriodInFrames,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
        [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid
    )
    {
        return (
            (delegate* unmanaged<IAudioClient3, uint, uint, WAVEFORMATEX*, Guid*, int>)(
                (*lpVtbl)[20]
            )
        )(this, StreamFlags, PeriodInFrames, pFormat, AudioSessionGuid);
    }

    public interface Interface : IAudioClient2.Interface
    {
        [VtblIndex(18)]
        HRESULT GetSharedModeEnginePeriod(
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
            [NativeTypeName("UINT32 *")] uint* pDefaultPeriodInFrames,
            [NativeTypeName("UINT32 *")] uint* pFundamentalPeriodInFrames,
            [NativeTypeName("UINT32 *")] uint* pMinPeriodInFrames,
            [NativeTypeName("UINT32 *")] uint* pMaxPeriodInFrames
        );

        [VtblIndex(19)]
        HRESULT GetCurrentSharedModeEnginePeriod(
            WAVEFORMATEX** ppFormat,
            [NativeTypeName("UINT32 *")] uint* pCurrentPeriodInFrames
        );

        [VtblIndex(20)]
        HRESULT InitializeSharedAudioStream(
            [NativeTypeName("DWORD")] uint StreamFlags,
            [NativeTypeName("UINT32")] uint PeriodInFrames,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat,
            [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid
        );
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

        [NativeTypeName(
            "HRESULT (AUDCLNT_SHAREMODE, DWORD, REFERENCE_TIME, REFERENCE_TIME, const WAVEFORMATEX *, LPCGUID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AUDCLNT_SHAREMODE,
            uint,
            long,
            long,
            WAVEFORMATEX*,
            Guid*,
            int> Initialize;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBufferSize;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStreamLatency;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentPadding;

        [NativeTypeName(
            "HRESULT (AUDCLNT_SHAREMODE, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AUDCLNT_SHAREMODE,
            WAVEFORMATEX*,
            WAVEFORMATEX**,
            int> IsFormatSupported;

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

        [NativeTypeName(
            "HRESULT (const WAVEFORMATEX *, BOOL, REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WAVEFORMATEX*,
            BOOL,
            long*,
            long*,
            int> GetBufferSizeLimits;

        [NativeTypeName(
            "HRESULT (const WAVEFORMATEX *, UINT32 *, UINT32 *, UINT32 *, UINT32 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WAVEFORMATEX*,
            uint*,
            uint*,
            uint*,
            uint*,
            int> GetSharedModeEnginePeriod;

        [NativeTypeName("HRESULT (WAVEFORMATEX **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            WAVEFORMATEX**,
            uint*,
            int> GetCurrentSharedModeEnginePeriod;

        [NativeTypeName(
            "HRESULT (DWORD, UINT32, const WAVEFORMATEX *, LPCGUID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            WAVEFORMATEX*,
            Guid*,
            int> InitializeSharedAudioStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioClient3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioClient3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAudioClient2"/> to <see cref = "IAudioClient3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAudioClient2"/> instance to be converted </param>
    public static explicit operator IAudioClient3(Silk.NET.Windows.IAudioClient2 value)
    {
        return new IAudioClient3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioClient3"/> to <see cref = "Silk.NET.Windows.IAudioClient2"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioClient3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAudioClient2(IAudioClient3 value)
    {
        return new Silk.NET.Windows.IAudioClient2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAudioClient"/> to <see cref = "IAudioClient3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAudioClient"/> instance to be converted </param>
    public static explicit operator IAudioClient3(Silk.NET.Windows.IAudioClient value)
    {
        return new IAudioClient3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioClient3"/> to <see cref = "Silk.NET.Windows.IAudioClient"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioClient3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAudioClient(IAudioClient3 value)
    {
        return new Silk.NET.Windows.IAudioClient(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioClient3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioClient3(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioClient3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioClient3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioClient3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioClient3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
