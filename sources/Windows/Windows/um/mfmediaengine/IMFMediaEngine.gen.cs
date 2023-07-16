// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine"]/*'/>
[Guid("98A1B0BB-03EB-4935-AE7C-93C1FA0E1C93")]
[NativeTypeName("struct IMFMediaEngine : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngine : IMFMediaEngine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngine));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, uint> )(lpVtbl[1]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, uint> )(lpVtbl[2]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetError"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetError(IMFMediaError** ppError)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaError**, int> )(lpVtbl[3]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppError);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetErrorCode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, MF_MEDIA_ENGINE_ERR, int> )(lpVtbl[4]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), error);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetSourceElements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaEngineSrcElements*, int> )(lpVtbl[5]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pSrcElements);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSource([NativeTypeName("BSTR")] ushort* pUrl)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, ushort*, int> )(lpVtbl[6]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pUrl);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetCurrentSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, ushort**, int> )(lpVtbl[7]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppUrl);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetNetworkState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ushort GetNetworkState()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, ushort> )(lpVtbl[8]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetPreload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public MF_MEDIA_ENGINE_PRELOAD GetPreload()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, MF_MEDIA_ENGINE_PRELOAD> )(lpVtbl[9]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetPreload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, MF_MEDIA_ENGINE_PRELOAD, int> )(lpVtbl[10]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Preload);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetBuffered"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaTimeRange**, int> )(lpVtbl[11]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppBuffered);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.Load"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Load()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[12]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.CanPlayType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CanPlayType([NativeTypeName("BSTR")] ushort* type, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int> )(lpVtbl[13]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), type, pAnswer);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetReadyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public ushort GetReadyState()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, ushort> )(lpVtbl[14]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.IsSeeking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL IsSeeking()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[15]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetCurrentTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public double GetCurrentTime()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double> )(lpVtbl[16]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetCurrentTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetCurrentTime(double seekTime)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double, int> )(lpVtbl[17]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), seekTime);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetStartTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public double GetStartTime()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double> )(lpVtbl[18]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetDuration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public double GetDuration()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double> )(lpVtbl[19]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.IsPaused"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL IsPaused()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[20]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetDefaultPlaybackRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public double GetDefaultPlaybackRate()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double> )(lpVtbl[21]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetDefaultPlaybackRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultPlaybackRate(double Rate)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double, int> )(lpVtbl[22]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Rate);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetPlaybackRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public double GetPlaybackRate()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double> )(lpVtbl[23]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetPlaybackRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetPlaybackRate(double Rate)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double, int> )(lpVtbl[24]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Rate);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetPlayed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetPlayed(IMFMediaTimeRange** ppPlayed)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaTimeRange**, int> )(lpVtbl[25]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppPlayed);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetSeekable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetSeekable(IMFMediaTimeRange** ppSeekable)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaTimeRange**, int> )(lpVtbl[26]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppSeekable);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.IsEnded"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public BOOL IsEnded()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[27]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetAutoPlay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public BOOL GetAutoPlay()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[28]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetAutoPlay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetAutoPlay(BOOL AutoPlay)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, BOOL, int> )(lpVtbl[29]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), AutoPlay);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetLoop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public BOOL GetLoop()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[30]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetLoop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetLoop(BOOL Loop)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, BOOL, int> )(lpVtbl[31]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Loop);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.Play"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Play()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[32]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[33]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetMuted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public BOOL GetMuted()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[34]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetMuted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetMuted(BOOL Muted)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, BOOL, int> )(lpVtbl[35]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Muted);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public double GetVolume()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double> )(lpVtbl[36]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.SetVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetVolume(double Volume)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, double, int> )(lpVtbl[37]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Volume);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.HasVideo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public BOOL HasVideo()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[38]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.HasAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public BOOL HasAudio()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[39]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetNativeVideoSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, uint*, uint*, int> )(lpVtbl[40]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), cx, cy);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.GetVideoAspectRatio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, uint*, uint*, int> )(lpVtbl[41]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), cx, cy);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.Shutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaEngine*, int> )(lpVtbl[42]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.TransferVideoFrame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int> )(lpVtbl[43]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
    }

    /// <include file='IMFMediaEngine.xml' path='doc/member[@name="IMFMediaEngine.OnVideoStreamTick"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
    {
        return ((delegate* unmanaged<IMFMediaEngine*, long*, int> )(lpVtbl[44]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pPts);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetError(IMFMediaError** ppError);
        [VtblIndex(4)]
        HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error);
        [VtblIndex(5)]
        HRESULT SetSourceElements(IMFMediaEngineSrcElements* pSrcElements);
        [VtblIndex(6)]
        HRESULT SetSource([NativeTypeName("BSTR")] ushort* pUrl);
        [VtblIndex(7)]
        HRESULT GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl);
        [VtblIndex(8)]
        ushort GetNetworkState();
        [VtblIndex(9)]
        MF_MEDIA_ENGINE_PRELOAD GetPreload();
        [VtblIndex(10)]
        HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload);
        [VtblIndex(11)]
        HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered);
        [VtblIndex(12)]
        HRESULT Load();
        [VtblIndex(13)]
        HRESULT CanPlayType([NativeTypeName("BSTR")] ushort* type, MF_MEDIA_ENGINE_CANPLAY* pAnswer);
        [VtblIndex(14)]
        ushort GetReadyState();
        [VtblIndex(15)]
        BOOL IsSeeking();
        [VtblIndex(16)]
        double GetCurrentTime();
        [VtblIndex(17)]
        HRESULT SetCurrentTime(double seekTime);
        [VtblIndex(18)]
        double GetStartTime();
        [VtblIndex(19)]
        double GetDuration();
        [VtblIndex(20)]
        BOOL IsPaused();
        [VtblIndex(21)]
        double GetDefaultPlaybackRate();
        [VtblIndex(22)]
        HRESULT SetDefaultPlaybackRate(double Rate);
        [VtblIndex(23)]
        double GetPlaybackRate();
        [VtblIndex(24)]
        HRESULT SetPlaybackRate(double Rate);
        [VtblIndex(25)]
        HRESULT GetPlayed(IMFMediaTimeRange** ppPlayed);
        [VtblIndex(26)]
        HRESULT GetSeekable(IMFMediaTimeRange** ppSeekable);
        [VtblIndex(27)]
        BOOL IsEnded();
        [VtblIndex(28)]
        BOOL GetAutoPlay();
        [VtblIndex(29)]
        HRESULT SetAutoPlay(BOOL AutoPlay);
        [VtblIndex(30)]
        BOOL GetLoop();
        [VtblIndex(31)]
        HRESULT SetLoop(BOOL Loop);
        [VtblIndex(32)]
        HRESULT Play();
        [VtblIndex(33)]
        HRESULT Pause();
        [VtblIndex(34)]
        BOOL GetMuted();
        [VtblIndex(35)]
        HRESULT SetMuted(BOOL Muted);
        [VtblIndex(36)]
        double GetVolume();
        [VtblIndex(37)]
        HRESULT SetVolume(double Volume);
        [VtblIndex(38)]
        BOOL HasVideo();
        [VtblIndex(39)]
        BOOL HasAudio();
        [VtblIndex(40)]
        HRESULT GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy);
        [VtblIndex(41)]
        HRESULT GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy);
        [VtblIndex(42)]
        HRESULT Shutdown();
        [VtblIndex(43)]
        HRESULT TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr);
        [VtblIndex(44)]
        HRESULT OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts);
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
    }
}