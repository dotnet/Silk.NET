// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaSharingEngine.xml' path='doc/member[@name="IMFMediaSharingEngine"]/*' />
[Guid("8D3CE1BF-2367-40E0-9EEE-40D377CC1B46")]
[NativeTypeName("struct IMFMediaSharingEngine : IMFMediaEngine")]
[NativeInheritance("IMFMediaEngine")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaSharingEngine : IMFMediaSharingEngine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSharingEngine));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, uint>)(lpVtbl[1]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, uint>)(lpVtbl[2]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetError" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetError(IMFMediaError** ppError)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppError);
    }

    /// <inheritdoc cref="IMFMediaEngine.SetErrorCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), error);
    }

    /// <inheritdoc cref="IMFMediaEngine.SetSourceElements" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pSrcElements);
    }

    /// <inheritdoc cref="IMFMediaEngine.SetSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSource([NativeTypeName("BSTR")] ushort* pUrl)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, ushort*, int>)(lpVtbl[6]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pUrl);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetCurrentSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, ushort**, int>)(lpVtbl[7]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppUrl);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetNetworkState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ushort GetNetworkState()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, ushort>)(lpVtbl[8]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetPreload" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public MF_MEDIA_ENGINE_PRELOAD GetPreload()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, MF_MEDIA_ENGINE_PRELOAD>)(lpVtbl[9]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetPreload" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Preload);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetBuffered" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppBuffered);
    }

    /// <inheritdoc cref="IMFMediaEngine.Load" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Load()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[12]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.CanPlayType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CanPlayType([NativeTypeName("BSTR")] ushort* type, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), type, pAnswer);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetReadyState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public ushort GetReadyState()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, ushort>)(lpVtbl[14]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.IsSeeking" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL IsSeeking()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[15]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetCurrentTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public double GetCurrentTime()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double>)(lpVtbl[16]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetCurrentTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetCurrentTime(double seekTime)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double, int>)(lpVtbl[17]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), seekTime);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetStartTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public double GetStartTime()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double>)(lpVtbl[18]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetDuration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public double GetDuration()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double>)(lpVtbl[19]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.IsPaused" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL IsPaused()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[20]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetDefaultPlaybackRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public double GetDefaultPlaybackRate()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double>)(lpVtbl[21]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetDefaultPlaybackRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultPlaybackRate(double Rate)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double, int>)(lpVtbl[22]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Rate);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetPlaybackRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public double GetPlaybackRate()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double>)(lpVtbl[23]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetPlaybackRate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetPlaybackRate(double Rate)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double, int>)(lpVtbl[24]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Rate);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetPlayed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetPlayed(IMFMediaTimeRange** ppPlayed)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppPlayed);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetSeekable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetSeekable(IMFMediaTimeRange** ppSeekable)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, IMFMediaTimeRange**, int>)(lpVtbl[26]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), ppSeekable);
    }

    /// <inheritdoc cref="IMFMediaEngine.IsEnded" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public BOOL IsEnded()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[27]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetAutoPlay" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public BOOL GetAutoPlay()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[28]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetAutoPlay" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetAutoPlay(BOOL AutoPlay)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, BOOL, int>)(lpVtbl[29]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), AutoPlay);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetLoop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public BOOL GetLoop()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[30]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetLoop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetLoop(BOOL Loop)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, BOOL, int>)(lpVtbl[31]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Loop);
    }

    /// <inheritdoc cref="IMFMediaEngine.Play" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Play()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[32]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.Pause" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[33]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetMuted" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public BOOL GetMuted()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[34]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetMuted" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetMuted(BOOL Muted)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, BOOL, int>)(lpVtbl[35]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Muted);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetVolume" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public double GetVolume()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double>)(lpVtbl[36]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.SetVolume" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetVolume(double Volume)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, double, int>)(lpVtbl[37]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), Volume);
    }

    /// <inheritdoc cref="IMFMediaEngine.HasVideo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public BOOL HasVideo()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[38]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.HasAudio" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public BOOL HasAudio()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[39]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.GetNativeVideoSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), cx, cy);
    }

    /// <inheritdoc cref="IMFMediaEngine.GetVideoAspectRatio" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), cx, cy);
    }

    /// <inheritdoc cref="IMFMediaEngine.Shutdown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, int>)(lpVtbl[42]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngine.TransferVideoFrame" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
    }

    /// <inheritdoc cref="IMFMediaEngine.OnVideoStreamTick" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, long*, int>)(lpVtbl[44]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pPts);
    }

    /// <include file='IMFMediaSharingEngine.xml' path='doc/member[@name="IMFMediaSharingEngine.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT GetDevice(DEVICE_INFO* pDevice)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngine*, DEVICE_INFO*, int>)(lpVtbl[45]))((IMFMediaSharingEngine*)Unsafe.AsPointer(ref this), pDevice);
    }

    public interface Interface : IMFMediaEngine.Interface
    {
        [VtblIndex(45)]
        HRESULT GetDevice(DEVICE_INFO* pDevice);
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

        [NativeTypeName("HRESULT (IMFMediaError **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaError**, int> GetError;

        [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_ERR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MEDIA_ENGINE_ERR, int> SetErrorCode;

        [NativeTypeName("HRESULT (IMFMediaEngineSrcElements *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEngineSrcElements*, int> SetSourceElements;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSource;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCurrentSource;

        [NativeTypeName("USHORT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort> GetNetworkState;

        [NativeTypeName("MF_MEDIA_ENGINE_PRELOAD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MEDIA_ENGINE_PRELOAD> GetPreload;

        [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_PRELOAD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MEDIA_ENGINE_PRELOAD, int> SetPreload;

        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTimeRange**, int> GetBuffered;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Load;

        [NativeTypeName("HRESULT (BSTR, MF_MEDIA_ENGINE_CANPLAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int> CanPlayType;

        [NativeTypeName("USHORT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort> GetReadyState;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSeeking;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetCurrentTime;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetCurrentTime;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetStartTime;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetDuration;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPaused;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetDefaultPlaybackRate;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetDefaultPlaybackRate;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetPlaybackRate;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetPlaybackRate;

        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTimeRange**, int> GetPlayed;

        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTimeRange**, int> GetSeekable;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEnded;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetAutoPlay;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAutoPlay;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetLoop;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetLoop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Play;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetMuted;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetMuted;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetVolume;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetVolume;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasVideo;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasAudio;

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetNativeVideoSize;

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetVideoAspectRatio;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;

        [NativeTypeName("HRESULT (IUnknown *, const MFVideoNormalizedRect *, const RECT *, const MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int> TransferVideoFrame;

        [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> OnVideoStreamTick;

        [NativeTypeName("HRESULT (DEVICE_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEVICE_INFO*, int> GetDevice;
    }
}
