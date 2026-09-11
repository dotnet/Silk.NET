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

public unsafe static class MFMediaEngineExVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEx> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEx> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFMediaError** ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppError);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFMediaError* ppError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaError** ppErrorPtr = &ppError)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppErrorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetErrorCode(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEngineError error)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineError, int>)@this->LpVtbl[4])(@this, error);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceElements(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFMediaEngineSrcElements* pSrcElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElements);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceElements(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFMediaEngineSrcElements pSrcElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaEngineSrcElements* pSrcElementsPtr = &pSrcElements)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElementsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSource(this ComPtr<IMFMediaEngineEx> thisVtbl, char* pUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, int>)@this->LpVtbl[6])(@this, pUrl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSource(this ComPtr<IMFMediaEngineEx> thisVtbl, ref char pUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pUrlPtr = &pUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSource(this ComPtr<IMFMediaEngineEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pUrlPtr = (byte*) SilkMarshal.StringToPtr(pUrl, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, byte*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
        SilkMarshal.Free((nint)pUrlPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentSource(this ComPtr<IMFMediaEngineEx> thisVtbl, char** ppUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char**, int>)@this->LpVtbl[7])(@this, ppUrl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentSource(this ComPtr<IMFMediaEngineEx> thisVtbl, ref char* ppUrl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppUrlPtr = &ppUrl)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char**, int>)@this->LpVtbl[7])(@this, ppUrlPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ushort GetNetworkState(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, ushort>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static MediaEnginePreload GetPreload(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        MediaEnginePreload ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEnginePreload>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPreload(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEnginePreload Preload)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEnginePreload, int>)@this->LpVtbl[10])(@this, Preload);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffered(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFMediaTimeRange** ppBuffered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBuffered);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffered(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFMediaTimeRange* ppBuffered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppBufferedPtr = &ppBuffered)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBufferedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, char* type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, char* type, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, ref char type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, ref char type, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswerPtr);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ushort GetReadyState(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, ushort>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSeeking(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetCurrentTime(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTime(this ComPtr<IMFMediaEngineEx> thisVtbl, double seekTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[17])(@this, seekTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetStartTime(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetDuration(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[19])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsPaused(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetDefaultPlaybackRate(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[21])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDefaultPlaybackRate(this ComPtr<IMFMediaEngineEx> thisVtbl, double Rate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[22])(@this, Rate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetPlaybackRate(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPlaybackRate(this ComPtr<IMFMediaEngineEx> thisVtbl, double Rate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[24])(@this, Rate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPlayed(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFMediaTimeRange** ppPlayed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPlayed(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFMediaTimeRange* ppPlayed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppPlayedPtr = &ppPlayed)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSeekable(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFMediaTimeRange** ppSeekable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSeekable(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFMediaTimeRange* ppSeekable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppSeekablePtr = &ppSeekable)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsEnded(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetAutoPlay(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[28])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAutoPlay(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 AutoPlay)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[29])(@this, AutoPlay);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetLoop(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLoop(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 Loop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[31])(@this, Loop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Play(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[32])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Pause(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetMuted(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[34])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMuted(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 Muted)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[35])(@this, Muted);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetVolume(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[36])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVolume(this ComPtr<IMFMediaEngineEx> thisVtbl, double Volume)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[37])(@this, Volume);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVideo(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[38])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasAudio(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[39])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cy);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cyPtr = &cy)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cxPtr, cy);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cxPtr, cyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cy);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cyPtr = &cy)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cxPtr, cy);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint cx, ref uint cy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* cxPtr = &cx)
        {
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cxPtr, cyPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Shutdown(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDstPtr, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDst, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDstPtr, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDst, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDstPtr, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDst, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
        {
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
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
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrcPtr, pDstPtr, pBorderClrPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OnVideoStreamTick(this ComPtr<IMFMediaEngineEx> thisVtbl, long* pPts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, long*, int>)@this->LpVtbl[44])(@this, pPts);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OnVideoStreamTick(this ComPtr<IMFMediaEngineEx> thisVtbl, ref long pPts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (long* pPtsPtr = &pPts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, long*, int>)@this->LpVtbl[44])(@this, pPtsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFByteStream* pByteStream, char* pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStream, pURL);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFByteStream* pByteStream, ref char pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pURLPtr = &pURL)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStream, pURLPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFByteStream* pByteStream, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, byte*, int>)@this->LpVtbl[45])(@this, pByteStream, pURLPtr);
        SilkMarshal.Free((nint)pURLPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFByteStream pByteStream, char* pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStreamPtr, pURL);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFByteStream pByteStream, ref char pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
            fixed (char* pURLPtr = &pURL)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStreamPtr, pURLPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, ref IMFByteStream pByteStream, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
        {
        var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, byte*, int>)@this->LpVtbl[45])(@this, pByteStreamPtr, pURLPtr);
        SilkMarshal.Free((nint)pURLPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatistics(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEngineStatistic StatisticID, tagPROPVARIANT* pStatistic)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineStatistic, tagPROPVARIANT*, int>)@this->LpVtbl[46])(@this, StatisticID, pStatistic);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStatistics(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEngineStatistic StatisticID, ref tagPROPVARIANT pStatistic)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (tagPROPVARIANT* pStatisticPtr = &pStatistic)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineStatistic, tagPROPVARIANT*, int>)@this->LpVtbl[46])(@this, StatisticID, pStatisticPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDst, pBorderClr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDst, pBorderClrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDstPtr, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDstPtr, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrcPtr, pDst, pBorderClr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrcPtr, pDst, pBorderClrPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrcPtr, pDstPtr, pBorderClr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrcPtr, pDstPtr, pBorderClrPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetBalance(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[48])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBalance(this ComPtr<IMFMediaEngineEx> thisVtbl, double balance)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[49])(@this, balance);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsPlaybackRateSupported(this ComPtr<IMFMediaEngineEx> thisVtbl, double rate)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, Silk.NET.Core.Bool32>)@this->LpVtbl[50])(@this, rate);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FrameStep(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 Forward)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[51])(@this, Forward);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceCharacteristics(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* pCharacteristics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[52])(@this, pCharacteristics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceCharacteristics(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint pCharacteristics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCharacteristicsPtr = &pCharacteristics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[52])(@this, pCharacteristicsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, Guid* guidMFAttribute, tagPROPVARIANT* pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttribute, pvValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, Guid* guidMFAttribute, ref tagPROPVARIANT pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (tagPROPVARIANT* pvValuePtr = &pvValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttribute, pvValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Guid guidMFAttribute, tagPROPVARIANT* pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMFAttributePtr = &guidMFAttribute)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttributePtr, pvValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Guid guidMFAttribute, ref tagPROPVARIANT pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMFAttributePtr = &guidMFAttribute)
        {
            fixed (tagPROPVARIANT* pvValuePtr = &pvValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttributePtr, pvValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberOfStreams(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* pdwStreamCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[54])(@this, pdwStreamCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetNumberOfStreams(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint pdwStreamCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwStreamCountPtr = &pdwStreamCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[54])(@this, pdwStreamCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Guid* guidMFAttribute, tagPROPVARIANT* pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttribute, pvValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Guid* guidMFAttribute, ref tagPROPVARIANT pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (tagPROPVARIANT* pvValuePtr = &pvValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttribute, pvValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, ref Guid guidMFAttribute, tagPROPVARIANT* pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMFAttributePtr = &guidMFAttribute)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttributePtr, pvValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, ref Guid guidMFAttribute, ref tagPROPVARIANT pvValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidMFAttributePtr = &guidMFAttribute)
        {
            fixed (tagPROPVARIANT* pvValuePtr = &pvValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttributePtr, pvValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSelection(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, int* pEnabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int*, int>)@this->LpVtbl[56])(@this, dwStreamIndex, pEnabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSelection(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, ref int pEnabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int*, int>)@this->LpVtbl[56])(@this, dwStreamIndex, pEnabledPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSelection(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Silk.NET.Core.Bool32 Enabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[57])(@this, dwStreamIndex, Enabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ApplyStreamSelections(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[58])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsProtected(this ComPtr<IMFMediaEngineEx> thisVtbl, int* pProtected)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[59])(@this, pProtected);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsProtected(this ComPtr<IMFMediaEngineEx> thisVtbl, ref int pProtected)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pProtectedPtr = &pProtected)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[59])(@this, pProtectedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertVideoEffect(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pEffect, Silk.NET.Core.Bool32 fOptional)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[60])(@this, pEffect, fOptional);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InsertVideoEffect(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pEffect, Silk.NET.Core.Bool32 fOptional)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pEffectPtr = &pEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[60])(@this, pEffectPtr, fOptional);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InsertAudioEffect(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pEffect, Silk.NET.Core.Bool32 fOptional)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[61])(@this, pEffect, fOptional);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InsertAudioEffect(this ComPtr<IMFMediaEngineEx> thisVtbl, ref Silk.NET.Core.Native.IUnknown pEffect, Silk.NET.Core.Bool32 fOptional)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pEffectPtr = &pEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[61])(@this, pEffectPtr, fOptional);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAllEffects(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[62])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTimelineMarkerTimer(this ComPtr<IMFMediaEngineEx> thisVtbl, double timeToFire)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[63])(@this, timeToFire);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimelineMarkerTimer(this ComPtr<IMFMediaEngineEx> thisVtbl, double* pTimeToFire)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double*, int>)@this->LpVtbl[64])(@this, pTimeToFire);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTimelineMarkerTimer(this ComPtr<IMFMediaEngineEx> thisVtbl, ref double pTimeToFire)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pTimeToFirePtr = &pTimeToFire)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double*, int>)@this->LpVtbl[64])(@this, pTimeToFirePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CancelTimelineMarkerTimer(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[65])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsStereo3D(this ComPtr<IMFMediaEngineEx> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[66])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStereo3DFramePackingMode(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEngineS3DPackingMode* packMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineS3DPackingMode*, int>)@this->LpVtbl[67])(@this, packMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStereo3DFramePackingMode(this ComPtr<IMFMediaEngineEx> thisVtbl, ref MediaEngineS3DPackingMode packMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MediaEngineS3DPackingMode* packModePtr = &packMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineS3DPackingMode*, int>)@this->LpVtbl[67])(@this, packModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStereo3DFramePackingMode(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEngineS3DPackingMode packMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineS3DPackingMode, int>)@this->LpVtbl[68])(@this, packMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStereo3DRenderMode(this ComPtr<IMFMediaEngineEx> thisVtbl, _MF3DVideoOutputType* outputType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, _MF3DVideoOutputType*, int>)@this->LpVtbl[69])(@this, outputType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStereo3DRenderMode(this ComPtr<IMFMediaEngineEx> thisVtbl, ref _MF3DVideoOutputType outputType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MF3DVideoOutputType* outputTypePtr = &outputType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, _MF3DVideoOutputType*, int>)@this->LpVtbl[69])(@this, outputTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStereo3DRenderMode(this ComPtr<IMFMediaEngineEx> thisVtbl, _MF3DVideoOutputType outputType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, _MF3DVideoOutputType, int>)@this->LpVtbl[70])(@this, outputType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableWindowlessSwapchainMode(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 fEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[71])(@this, fEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoSwapchainHandle(this ComPtr<IMFMediaEngineEx> thisVtbl, void** phSwapchain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, void**, int>)@this->LpVtbl[72])(@this, phSwapchain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoSwapchainHandle(this ComPtr<IMFMediaEngineEx> thisVtbl, ref void* phSwapchain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** phSwapchainPtr = &phSwapchain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, void**, int>)@this->LpVtbl[72])(@this, phSwapchainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableHorizontalMirrorMode(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 fEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[73])(@this, fEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAudioStreamCategory(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* pCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[74])(@this, pCategory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAudioStreamCategory(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint pCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCategoryPtr = &pCategory)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[74])(@this, pCategoryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAudioStreamCategory(this ComPtr<IMFMediaEngineEx> thisVtbl, uint category)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int>)@this->LpVtbl[75])(@this, category);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAudioEndpointRole(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* pRole)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[76])(@this, pRole);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAudioEndpointRole(this ComPtr<IMFMediaEngineEx> thisVtbl, ref uint pRole)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pRolePtr = &pRole)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[76])(@this, pRolePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAudioEndpointRole(this ComPtr<IMFMediaEngineEx> thisVtbl, uint role)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int>)@this->LpVtbl[77])(@this, role);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRealTimeMode(this ComPtr<IMFMediaEngineEx> thisVtbl, int* pfEnabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[78])(@this, pfEnabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRealTimeMode(this ComPtr<IMFMediaEngineEx> thisVtbl, ref int pfEnabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfEnabledPtr = &pfEnabled)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[78])(@this, pfEnabledPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRealTimeMode(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 fEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[79])(@this, fEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTimeEx(this ComPtr<IMFMediaEngineEx> thisVtbl, double seekTime, MediaEngineSeekMode seekMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, MediaEngineSeekMode, int>)@this->LpVtbl[80])(@this, seekTime, seekMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableTimeUpdateTimer(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Bool32 fEnableTimer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[81])(@this, fEnableTimer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetError<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetError((IMFMediaError**) ppError.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceElements<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pSrcElements) where TI0 : unmanaged, IComVtbl<IMFMediaEngineSrcElements>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetSourceElements((IMFMediaEngineSrcElements*) pSrcElements.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceElements(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<IMFMediaEngineSrcElements> pSrcElements)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceElements(ref pSrcElements.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetSource(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<char> pUrl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSource(ref pUrl.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentSource(this ComPtr<IMFMediaEngineEx> thisVtbl, string[] ppUrlSa)
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
    public static int GetBuffered<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ref ComPtr<TI0> ppBuffered) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBuffered((IMFMediaTimeRange**) ppBuffered.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, char* type, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(type, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<char> type, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(ref type.GetPinnableReference(), pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<char> type, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(ref type.GetPinnableReference(), ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CanPlayType(this ComPtr<IMFMediaEngineEx> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CanPlayType(type, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPlayed<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ref ComPtr<TI0> ppPlayed) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPlayed((IMFMediaTimeRange**) ppPlayed.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetSeekable<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ref ComPtr<TI0> ppSeekable) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSeekable((IMFMediaTimeRange**) ppSeekable.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNativeVideoSize(cx, ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNativeVideoSize(ref cx.GetPinnableReference(), cy);
    }

    /// <summary>To be documented.</summary>
    public static int GetNativeVideoSize(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNativeVideoSize(ref cx.GetPinnableReference(), ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, uint* cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoAspectRatio(cx, ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> cx, uint* cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoAspectRatio(ref cx.GetPinnableReference(), cy);
    }

    /// <summary>To be documented.</summary>
    public static int GetVideoAspectRatio(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> cx, Span<uint> cy)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVideoAspectRatio(ref cx.GetPinnableReference(), ref cy.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(pDstSurf, in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static int TransferVideoFrame(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TransferVideoFrame(ref pDstSurf.GetPinnableReference(), in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int OnVideoStreamTick(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<long> pPts)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OnVideoStreamTick(ref pPts.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, IMFByteStream* pByteStream, Span<char> pURL)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceFromByteStream(pByteStream, ref pURL.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<IMFByteStream> pByteStream, char* pURL)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceFromByteStream(ref pByteStream.GetPinnableReference(), pURL);
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<IMFByteStream> pByteStream, Span<char> pURL)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceFromByteStream(ref pByteStream.GetPinnableReference(), ref pURL.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceFromByteStream(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<IMFByteStream> pByteStream, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceFromByteStream(ref pByteStream.GetPinnableReference(), pURL);
    }

    /// <summary>To be documented.</summary>
    public static int GetStatistics(this ComPtr<IMFMediaEngineEx> thisVtbl, MediaEngineStatistic StatisticID, Span<tagPROPVARIANT> pStatistic)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStatistics(StatisticID, ref pStatistic.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(pSrc, pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(pSrc, in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(pSrc, in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(in pSrc.GetPinnableReference(), pDst, pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(in pSrc.GetPinnableReference(), pDst, in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), pBorderClr);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateVideoStream(this ComPtr<IMFMediaEngineEx> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoNormalizedRect> pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<_MFARGB> pBorderClr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateVideoStream(in pSrc.GetPinnableReference(), in pDst.GetPinnableReference(), in pBorderClr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceCharacteristics(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> pCharacteristics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetResourceCharacteristics(ref pCharacteristics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, Guid* guidMFAttribute, Span<tagPROPVARIANT> pvValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPresentationAttribute(guidMFAttribute, ref pvValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Guid> guidMFAttribute, tagPROPVARIANT* pvValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPresentationAttribute(ref guidMFAttribute.GetPinnableReference(), pvValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentationAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Guid> guidMFAttribute, Span<tagPROPVARIANT> pvValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPresentationAttribute(ref guidMFAttribute.GetPinnableReference(), ref pvValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetNumberOfStreams(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> pdwStreamCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNumberOfStreams(ref pdwStreamCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Guid* guidMFAttribute, Span<tagPROPVARIANT> pvValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamAttribute(dwStreamIndex, guidMFAttribute, ref pvValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Span<Guid> guidMFAttribute, tagPROPVARIANT* pvValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamAttribute(dwStreamIndex, ref guidMFAttribute.GetPinnableReference(), pvValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamAttribute(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Span<Guid> guidMFAttribute, Span<tagPROPVARIANT> pvValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamAttribute(dwStreamIndex, ref guidMFAttribute.GetPinnableReference(), ref pvValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSelection(this ComPtr<IMFMediaEngineEx> thisVtbl, uint dwStreamIndex, Span<int> pEnabled)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSelection(dwStreamIndex, ref pEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsProtected(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<int> pProtected)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsProtected(ref pProtected.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int InsertVideoEffect<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pEffect, Silk.NET.Core.Bool32 fOptional) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InsertVideoEffect((Silk.NET.Core.Native.IUnknown*) pEffect.Handle, fOptional);
    }

    /// <summary>To be documented.</summary>
    public static int InsertVideoEffect(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pEffect, Silk.NET.Core.Bool32 fOptional)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InsertVideoEffect(ref pEffect.GetPinnableReference(), fOptional);
    }

    /// <summary>To be documented.</summary>
    public static int InsertAudioEffect<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl, ComPtr<TI0> pEffect, Silk.NET.Core.Bool32 fOptional) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InsertAudioEffect((Silk.NET.Core.Native.IUnknown*) pEffect.Handle, fOptional);
    }

    /// <summary>To be documented.</summary>
    public static int InsertAudioEffect(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pEffect, Silk.NET.Core.Bool32 fOptional)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InsertAudioEffect(ref pEffect.GetPinnableReference(), fOptional);
    }

    /// <summary>To be documented.</summary>
    public static int GetTimelineMarkerTimer(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<double> pTimeToFire)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimelineMarkerTimer(ref pTimeToFire.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStereo3DFramePackingMode(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<MediaEngineS3DPackingMode> packMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStereo3DFramePackingMode(ref packMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStereo3DRenderMode(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<_MF3DVideoOutputType> outputType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStereo3DRenderMode(ref outputType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAudioStreamCategory(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> pCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAudioStreamCategory(ref pCategory.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAudioEndpointRole(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<uint> pRole)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAudioEndpointRole(ref pRole.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRealTimeMode(this ComPtr<IMFMediaEngineEx> thisVtbl, Span<int> pfEnabled)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRealTimeMode(ref pfEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineEx> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
