// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation;

public unsafe static class MFMediaEngineVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngine> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngine> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngine> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngine> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaEngine> thisVtbl, IMFMediaError** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppError);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaEngine> thisVtbl, ref IMFMediaError* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaError** ppErrorPtr = &ppError)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppErrorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetErrorCode(this ComPtr<IMFMediaEngine> thisVtbl, MediaEngineError error)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, MediaEngineError, int>)@this->LpVtbl[4])(@this, error);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceElements(this ComPtr<IMFMediaEngine> thisVtbl, IMFMediaEngineSrcElements* pSrcElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElements);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceElements(this ComPtr<IMFMediaEngine> thisVtbl, ref IMFMediaEngineSrcElements pSrcElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaEngineSrcElements* pSrcElementsPtr = &pSrcElements)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElementsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSource(this ComPtr<IMFMediaEngine> thisVtbl, char* pUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, int>)@this->LpVtbl[6])(@this, pUrl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSource(this ComPtr<IMFMediaEngine> thisVtbl, ref char pUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pUrlPtr = &pUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSource(this ComPtr<IMFMediaEngine> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pUrlPtr = (byte*) SilkMarshal.StringToPtr(pUrl, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, byte*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
        SilkMarshal.Free((nint)pUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentSource(this ComPtr<IMFMediaEngine> thisVtbl, char** ppUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char**, int>)@this->LpVtbl[7])(@this, ppUrl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentSource(this ComPtr<IMFMediaEngine> thisVtbl, ref char* ppUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppUrlPtr = &ppUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char**, int>)@this->LpVtbl[7])(@this, ppUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ushort GetNetworkState(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, ushort>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static MediaEnginePreload GetPreload(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        MediaEnginePreload ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, MediaEnginePreload>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPreload(this ComPtr<IMFMediaEngine> thisVtbl, MediaEnginePreload Preload)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, MediaEnginePreload, int>)@this->LpVtbl[10])(@this, Preload);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffered(this ComPtr<IMFMediaEngine> thisVtbl, IMFMediaTimeRange** ppBuffered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBuffered);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffered(this ComPtr<IMFMediaEngine> thisVtbl, ref IMFMediaTimeRange* ppBuffered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppBufferedPtr = &ppBuffered)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBufferedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, char* type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, char* type, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, ref char type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, ref char type, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswerPtr);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ushort GetReadyState(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, ushort>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSeeking(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetCurrentTime(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTime(this ComPtr<IMFMediaEngine> thisVtbl, double seekTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[17])(@this, seekTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetStartTime(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetDuration(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[19])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsPaused(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetDefaultPlaybackRate(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[21])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDefaultPlaybackRate(this ComPtr<IMFMediaEngine> thisVtbl, double Rate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[22])(@this, Rate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetPlaybackRate(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPlaybackRate(this ComPtr<IMFMediaEngine> thisVtbl, double Rate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[24])(@this, Rate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPlayed(this ComPtr<IMFMediaEngine> thisVtbl, IMFMediaTimeRange** ppPlayed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPlayed(this ComPtr<IMFMediaEngine> thisVtbl, ref IMFMediaTimeRange* ppPlayed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppPlayedPtr = &ppPlayed)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSeekable(this ComPtr<IMFMediaEngine> thisVtbl, IMFMediaTimeRange** ppSeekable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSeekable(this ComPtr<IMFMediaEngine> thisVtbl, ref IMFMediaTimeRange* ppSeekable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppSeekablePtr = &ppSeekable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsEnded(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetAutoPlay(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[28])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAutoPlay(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Bool32 AutoPlay)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[29])(@this, AutoPlay);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetLoop(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLoop(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Bool32 Loop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[31])(@this, Loop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Play(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[32])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Pause(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetMuted(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[34])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMuted(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Bool32 Muted)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[35])(@this, Muted);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetVolume(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[36])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVolume(this ComPtr<IMFMediaEngine> thisVtbl, double Volume)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[37])(@this, Volume);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVideo(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[38])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasAudio(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[39])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, uint* cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cy);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, uint* cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cyPtr = &cy)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, ref uint cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cxPtr, cy);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, ref uint cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cxPtr, cyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, uint* cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cy);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, uint* cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cyPtr = &cy)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, ref uint cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cxPtr, cy);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, ref uint cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cxPtr, cyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Shutdown(this ComPtr<IMFMediaEngine> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDstPtr, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDst, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDst, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OnVideoStreamTick(this ComPtr<IMFMediaEngine> thisVtbl, long* pPts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, long*, int>)@this->LpVtbl[44])(@this, pPts);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OnVideoStreamTick(this ComPtr<IMFMediaEngine> thisVtbl, ref long pPts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (long* pPtsPtr = &pPts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, long*, int>)@this->LpVtbl[44])(@this, pPtsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngine> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngine> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetError<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetError((IMFMediaError**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceElements<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pSrcElements) where TI0 : unmanaged, IComVtbl<IMFMediaEngineSrcElements>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetSourceElements((IMFMediaEngineSrcElements*) pSrcElements.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceElements(this ComPtr<IMFMediaEngine> thisVtbl, Span<IMFMediaEngineSrcElements> pSrcElements)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceElements(ref pSrcElements.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetSource(this ComPtr<IMFMediaEngine> thisVtbl, Span<char> pUrl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSource(ref pUrl.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentSource(this ComPtr<IMFMediaEngine> thisVtbl, string[] ppUrlSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppUrl = (char**) SilkMarshal.StringArrayToPtr(ppUrlSa);
        var ret = @this->GetCurrentSource(ppUrl);
        SilkMarshal.CopyPtrToStringArray((nint) ppUrl, ppUrlSa);
        SilkMarshal.Free((nint) ppUrl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffered<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ref ComPtr<TI0> ppBuffered) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBuffered((IMFMediaTimeRange**) ppBuffered.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, char* type, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(type, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, Span<char> type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(ref type.GetPinnableReference(), pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, Span<char> type, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(ref type.GetPinnableReference(), ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngine> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(type, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPlayed<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ref ComPtr<TI0> ppPlayed) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPlayed((IMFMediaTimeRange**) ppPlayed.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetSeekable<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ref ComPtr<TI0> ppSeekable) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSeekable((IMFMediaTimeRange**) ppSeekable.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, uint* cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNativeVideoSize(cx, ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, Span<uint> cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNativeVideoSize(ref cx.GetPinnableReference(), cy);
    }

    /// <summary>To be documented.</summary>
    public static int GetNativeVideoSize(this ComPtr<IMFMediaEngine> thisVtbl, Span<uint> cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNativeVideoSize(ref cx.GetPinnableReference(), ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, uint* cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoAspectRatio(cx, ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, Span<uint> cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoAspectRatio(ref cx.GetPinnableReference(), cy);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoAspectRatio(this ComPtr<IMFMediaEngine> thisVtbl, Span<uint> cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoAspectRatio(ref cx.GetPinnableReference(), ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngine> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame(this ComPtr<IMFMediaEngine> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int OnVideoStreamTick(this ComPtr<IMFMediaEngine> thisVtbl, Span<long> pPts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OnVideoStreamTick(ref pPts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngine> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
