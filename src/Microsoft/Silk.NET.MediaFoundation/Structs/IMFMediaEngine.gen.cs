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

namespace Silk.NET.MediaFoundation
{
    [Guid("98a1b0bb-03eb-4935-ae7c-93c1fa0e1c93")]
    [NativeName("Name", "IMFMediaEngine")]
    public unsafe partial struct IMFMediaEngine : IComVtbl<IMFMediaEngine>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("98a1b0bb-03eb-4935-ae7c-93c1fa0e1c93");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngine val)
            => Unsafe.As<IMFMediaEngine, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngine
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(IMFMediaError** ppError)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppError);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ref IMFMediaError* ppError)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaError** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppErrorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetErrorCode(MediaEngineError error)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, MediaEngineError, int>)@this->LpVtbl[4])(@this, error);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElements);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceElements(ref IMFMediaEngineSrcElements pSrcElements)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaEngineSrcElements* pSrcElementsPtr = &pSrcElements)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElementsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSource(char* pUrl)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, int>)@this->LpVtbl[6])(@this, pUrl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSource(ref char pUrl)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pUrlPtr = &pUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSource([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pUrl)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pUrlPtr = (byte*) SilkMarshal.StringToPtr(pUrl, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, byte*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
            SilkMarshal.Free((nint)pUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentSource(char** ppUrl)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char**, int>)@this->LpVtbl[7])(@this, ppUrl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentSource(ref char* ppUrl)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppUrlPtr = &ppUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char**, int>)@this->LpVtbl[7])(@this, ppUrlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ushort GetNetworkState()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, ushort>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly MediaEnginePreload GetPreload()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            MediaEnginePreload ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, MediaEnginePreload>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPreload(MediaEnginePreload Preload)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, MediaEnginePreload, int>)@this->LpVtbl[10])(@this, Preload);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBuffered);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffered(ref IMFMediaTimeRange* ppBuffered)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppBufferedPtr = &ppBuffered)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBufferedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(char* type, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(char* type, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(ref char type, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanPlayType(ref char type, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CanPlayType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanPlayType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly ushort GetReadyState()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, ushort>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSeeking()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetCurrentTime()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentTime(double seekTime)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[17])(@this, seekTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetStartTime()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetDuration()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[19])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsPaused()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetDefaultPlaybackRate()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[21])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDefaultPlaybackRate(double Rate)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[22])(@this, Rate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetPlaybackRate()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPlaybackRate(double Rate)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[24])(@this, Rate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPlayed(IMFMediaTimeRange** ppPlayed)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPlayed(ref IMFMediaTimeRange* ppPlayed)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppPlayedPtr = &ppPlayed)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSeekable(IMFMediaTimeRange** ppSeekable)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSeekable(ref IMFMediaTimeRange* ppSeekable)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppSeekablePtr = &ppSeekable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsEnded()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetAutoPlay()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[28])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAutoPlay(Silk.NET.Core.Bool32 AutoPlay)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[29])(@this, AutoPlay);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetLoop()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLoop(Silk.NET.Core.Bool32 Loop)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[31])(@this, Loop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Play()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[32])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Pause()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetMuted()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[34])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMuted(Silk.NET.Core.Bool32 Muted)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[35])(@this, Muted);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetVolume()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double>)@this->LpVtbl[36])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVolume(double Volume)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, double, int>)@this->LpVtbl[37])(@this, Volume);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVideo()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[38])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasAudio()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Bool32>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNativeVideoSize(uint* cx, uint* cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cy);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNativeVideoSize(uint* cx, ref uint cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNativeVideoSize(ref uint cx, uint* cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cxPtr = &cx)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cxPtr, cy);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNativeVideoSize(ref uint cx, ref uint cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetVideoAspectRatio(uint* cx, uint* cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cy);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoAspectRatio(uint* cx, ref uint cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoAspectRatio(ref uint cx, uint* cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cxPtr = &cx)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cxPtr, cy);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoAspectRatio(ref uint cx, ref uint cy)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int Shutdown()
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, int>)@this->LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int OnVideoStreamTick(long* pPts)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, long*, int>)@this->LpVtbl[44])(@this, pPts);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OnVideoStreamTick(ref long pPts)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (long* pPtsPtr = &pPts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngine*, long*, int>)@this->LpVtbl[44])(@this, pPtsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetError<TI0>(ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetError((IMFMediaError**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceElements<TI0>(ComPtr<TI0> pSrcElements) where TI0 : unmanaged, IComVtbl<IMFMediaEngineSrcElements>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetSourceElements((IMFMediaEngineSrcElements*) pSrcElements.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentSource(string[] ppUrlSa)
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppUrl = (char**) SilkMarshal.StringArrayToPtr(ppUrlSa);
            var ret = @this->GetCurrentSource(ppUrl);
            SilkMarshal.CopyPtrToStringArray((nint) ppUrl, ppUrlSa);
            SilkMarshal.Free((nint) ppUrl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBuffered<TI0>(ref ComPtr<TI0> ppBuffered) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBuffered((IMFMediaTimeRange**) ppBuffered.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPlayed<TI0>(ref ComPtr<TI0> ppPlayed) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPlayed((IMFMediaTimeRange**) ppPlayed.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSeekable<TI0>(ref ComPtr<TI0> ppSeekable) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSeekable((IMFMediaTimeRange**) ppSeekable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngine*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
