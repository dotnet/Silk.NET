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
    [Guid("83015ead-b1e6-40d0-a98a-37145ffe1ad1")]
    [NativeName("Name", "IMFMediaEngineEx")]
    public unsafe partial struct IMFMediaEngineEx : IComVtbl<IMFMediaEngineEx>, IComVtbl<IMFMediaEngine>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("83015ead-b1e6-40d0-a98a-37145ffe1ad1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMFMediaEngine(IMFMediaEngineEx val)
            => Unsafe.As<IMFMediaEngineEx, IMFMediaEngine>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineEx val)
            => Unsafe.As<IMFMediaEngineEx, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineEx
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
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(IMFMediaError** ppError)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppError);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ref IMFMediaError* ppError)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaError** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaError**, int>)@this->LpVtbl[3])(@this, ppErrorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetErrorCode(MediaEngineError error)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineError, int>)@this->LpVtbl[4])(@this, error);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElements);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceElements(ref IMFMediaEngineSrcElements pSrcElements)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaEngineSrcElements* pSrcElementsPtr = &pSrcElements)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)@this->LpVtbl[5])(@this, pSrcElementsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSource(char* pUrl)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, int>)@this->LpVtbl[6])(@this, pUrl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSource(ref char pUrl)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pUrlPtr = &pUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSource([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pUrl)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pUrlPtr = (byte*) SilkMarshal.StringToPtr(pUrl, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, byte*, int>)@this->LpVtbl[6])(@this, pUrlPtr);
            SilkMarshal.Free((nint)pUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentSource(char** ppUrl)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char**, int>)@this->LpVtbl[7])(@this, ppUrl);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentSource(ref char* ppUrl)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppUrlPtr = &ppUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char**, int>)@this->LpVtbl[7])(@this, ppUrlPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ushort GetNetworkState()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, ushort>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly MediaEnginePreload GetPreload()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            MediaEnginePreload ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEnginePreload>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPreload(MediaEnginePreload Preload)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEnginePreload, int>)@this->LpVtbl[10])(@this, Preload);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBuffered);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffered(ref IMFMediaTimeRange* ppBuffered)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppBufferedPtr = &ppBuffered)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[11])(@this, ppBufferedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(char* type, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(char* type, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, type, pAnswerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CanPlayType(ref char type, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanPlayType(ref char type, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int CanPlayType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, MediaEngineCanPlay* pAnswer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[13])(@this, typePtr, pAnswer);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CanPlayType([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref MediaEngineCanPlay pAnswer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly ushort GetReadyState()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, ushort>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSeeking()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetCurrentTime()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentTime(double seekTime)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[17])(@this, seekTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetStartTime()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetDuration()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[19])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsPaused()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetDefaultPlaybackRate()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[21])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDefaultPlaybackRate(double Rate)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[22])(@this, Rate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetPlaybackRate()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPlaybackRate(double Rate)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[24])(@this, Rate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPlayed(IMFMediaTimeRange** ppPlayed)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPlayed(ref IMFMediaTimeRange* ppPlayed)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppPlayedPtr = &ppPlayed)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[25])(@this, ppPlayedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSeekable(IMFMediaTimeRange** ppSeekable)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSeekable(ref IMFMediaTimeRange* ppSeekable)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppSeekablePtr = &ppSeekable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[26])(@this, ppSeekablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsEnded()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetAutoPlay()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[28])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAutoPlay(Silk.NET.Core.Bool32 AutoPlay)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[29])(@this, AutoPlay);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetLoop()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLoop(Silk.NET.Core.Bool32 Loop)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[31])(@this, Loop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Play()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[32])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Pause()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetMuted()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[34])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMuted(Silk.NET.Core.Bool32 Muted)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[35])(@this, Muted);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetVolume()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[36])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVolume(double Volume)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[37])(@this, Volume);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVideo()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[38])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasAudio()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNativeVideoSize(uint* cx, uint* cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cy);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNativeVideoSize(uint* cx, ref uint cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cx, cyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNativeVideoSize(ref uint cx, uint* cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cxPtr = &cx)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[40])(@this, cxPtr, cy);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNativeVideoSize(ref uint cx, ref uint cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetVideoAspectRatio(uint* cx, uint* cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cy);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoAspectRatio(uint* cx, ref uint cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cyPtr = &cy)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cx, cyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoAspectRatio(ref uint cx, uint* cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* cxPtr = &cx)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, uint*, int>)@this->LpVtbl[41])(@this, cxPtr, cy);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoAspectRatio(ref uint cx, ref uint cy)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int Shutdown()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDst, pBorderClrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrc, pDstPtr, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurf, pSrcPtr, pDst, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(Silk.NET.Core.Native.IUnknown* pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDstSurfPtr = &pDstSurf)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[43])(@this, pDstSurfPtr, pSrc, pDst, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int TransferVideoFrame(ref Silk.NET.Core.Native.IUnknown pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int OnVideoStreamTick(long* pPts)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, long*, int>)@this->LpVtbl[44])(@this, pPts);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OnVideoStreamTick(ref long pPts)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (long* pPtsPtr = &pPts)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, long*, int>)@this->LpVtbl[44])(@this, pPtsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceFromByteStream(IMFByteStream* pByteStream, char* pURL)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStream, pURL);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceFromByteStream(IMFByteStream* pByteStream, ref char pURL)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pURLPtr = &pURL)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStream, pURLPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceFromByteStream(IMFByteStream* pByteStream, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pURLPtr = (byte*) SilkMarshal.StringToPtr(pURL, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, byte*, int>)@this->LpVtbl[45])(@this, pByteStream, pURLPtr);
            SilkMarshal.Free((nint)pURLPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSourceFromByteStream(ref IMFByteStream pByteStream, char* pURL)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pByteStreamPtr = &pByteStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, IMFByteStream*, char*, int>)@this->LpVtbl[45])(@this, pByteStreamPtr, pURL);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceFromByteStream(ref IMFByteStream pByteStream, ref char pURL)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int SetSourceFromByteStream(ref IMFByteStream pByteStream, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string pURL)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetStatistics(MediaEngineStatistic StatisticID, tagPROPVARIANT* pStatistic)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineStatistic, tagPROPVARIANT*, int>)@this->LpVtbl[46])(@this, StatisticID, pStatistic);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStatistics(MediaEngineStatistic StatisticID, ref tagPROPVARIANT pStatistic)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (tagPROPVARIANT* pStatisticPtr = &pStatistic)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineStatistic, tagPROPVARIANT*, int>)@this->LpVtbl[46])(@this, StatisticID, pStatisticPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDst, pBorderClr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* pBorderClrPtr = &pBorderClr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDst, pBorderClrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrc, pDstPtr, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoNormalizedRect* pSrcPtr = &pSrc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, VideoNormalizedRect*, Silk.NET.Maths.Box2D<int>*, _MFARGB*, int>)@this->LpVtbl[47])(@this, pSrcPtr, pDst, pBorderClr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int UpdateVideoStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly double GetBalance()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double>)@this->LpVtbl[48])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBalance(double balance)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[49])(@this, balance);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsPlaybackRateSupported(double rate)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, Silk.NET.Core.Bool32>)@this->LpVtbl[50])(@this, rate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FrameStep(Silk.NET.Core.Bool32 Forward)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[51])(@this, Forward);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceCharacteristics(uint* pCharacteristics)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[52])(@this, pCharacteristics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceCharacteristics(ref uint pCharacteristics)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCharacteristicsPtr = &pCharacteristics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[52])(@this, pCharacteristicsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPresentationAttribute(Guid* guidMFAttribute, tagPROPVARIANT* pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttribute, pvValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPresentationAttribute(Guid* guidMFAttribute, ref tagPROPVARIANT pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (tagPROPVARIANT* pvValuePtr = &pvValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttribute, pvValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPresentationAttribute(ref Guid guidMFAttribute, tagPROPVARIANT* pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMFAttributePtr = &guidMFAttribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[53])(@this, guidMFAttributePtr, pvValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPresentationAttribute(ref Guid guidMFAttribute, ref tagPROPVARIANT pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetNumberOfStreams(uint* pdwStreamCount)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[54])(@this, pdwStreamCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNumberOfStreams(ref uint pdwStreamCount)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwStreamCountPtr = &pdwStreamCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[54])(@this, pdwStreamCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamAttribute(uint dwStreamIndex, Guid* guidMFAttribute, tagPROPVARIANT* pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttribute, pvValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamAttribute(uint dwStreamIndex, Guid* guidMFAttribute, ref tagPROPVARIANT pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (tagPROPVARIANT* pvValuePtr = &pvValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttribute, pvValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStreamAttribute(uint dwStreamIndex, ref Guid guidMFAttribute, tagPROPVARIANT* pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMFAttributePtr = &guidMFAttribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Guid*, tagPROPVARIANT*, int>)@this->LpVtbl[55])(@this, dwStreamIndex, guidMFAttributePtr, pvValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStreamAttribute(uint dwStreamIndex, ref Guid guidMFAttribute, ref tagPROPVARIANT pvValue)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetStreamSelection(uint dwStreamIndex, int* pEnabled)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int*, int>)@this->LpVtbl[56])(@this, dwStreamIndex, pEnabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStreamSelection(uint dwStreamIndex, ref int pEnabled)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int*, int>)@this->LpVtbl[56])(@this, dwStreamIndex, pEnabledPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStreamSelection(uint dwStreamIndex, Silk.NET.Core.Bool32 Enabled)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[57])(@this, dwStreamIndex, Enabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ApplyStreamSelections()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[58])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsProtected(int* pProtected)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[59])(@this, pProtected);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsProtected(ref int pProtected)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pProtectedPtr = &pProtected)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[59])(@this, pProtectedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertVideoEffect(Silk.NET.Core.Native.IUnknown* pEffect, Silk.NET.Core.Bool32 fOptional)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[60])(@this, pEffect, fOptional);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertVideoEffect(ref Silk.NET.Core.Native.IUnknown pEffect, Silk.NET.Core.Bool32 fOptional)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pEffectPtr = &pEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[60])(@this, pEffectPtr, fOptional);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertAudioEffect(Silk.NET.Core.Native.IUnknown* pEffect, Silk.NET.Core.Bool32 fOptional)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[61])(@this, pEffect, fOptional);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertAudioEffect(ref Silk.NET.Core.Native.IUnknown pEffect, Silk.NET.Core.Bool32 fOptional)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pEffectPtr = &pEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[61])(@this, pEffectPtr, fOptional);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAllEffects()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[62])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTimelineMarkerTimer(double timeToFire)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, int>)@this->LpVtbl[63])(@this, timeToFire);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimelineMarkerTimer(double* pTimeToFire)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double*, int>)@this->LpVtbl[64])(@this, pTimeToFire);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimelineMarkerTimer(ref double pTimeToFire)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pTimeToFirePtr = &pTimeToFire)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double*, int>)@this->LpVtbl[64])(@this, pTimeToFirePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CancelTimelineMarkerTimer()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int>)@this->LpVtbl[65])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsStereo3D()
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32>)@this->LpVtbl[66])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStereo3DFramePackingMode(MediaEngineS3DPackingMode* packMode)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineS3DPackingMode*, int>)@this->LpVtbl[67])(@this, packMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStereo3DFramePackingMode(ref MediaEngineS3DPackingMode packMode)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MediaEngineS3DPackingMode* packModePtr = &packMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineS3DPackingMode*, int>)@this->LpVtbl[67])(@this, packModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStereo3DFramePackingMode(MediaEngineS3DPackingMode packMode)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, MediaEngineS3DPackingMode, int>)@this->LpVtbl[68])(@this, packMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStereo3DRenderMode(_MF3DVideoOutputType* outputType)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, _MF3DVideoOutputType*, int>)@this->LpVtbl[69])(@this, outputType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStereo3DRenderMode(ref _MF3DVideoOutputType outputType)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MF3DVideoOutputType* outputTypePtr = &outputType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, _MF3DVideoOutputType*, int>)@this->LpVtbl[69])(@this, outputTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStereo3DRenderMode(_MF3DVideoOutputType outputType)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, _MF3DVideoOutputType, int>)@this->LpVtbl[70])(@this, outputType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableWindowlessSwapchainMode(Silk.NET.Core.Bool32 fEnable)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[71])(@this, fEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoSwapchainHandle(void** phSwapchain)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, void**, int>)@this->LpVtbl[72])(@this, phSwapchain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoSwapchainHandle(ref void* phSwapchain)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** phSwapchainPtr = &phSwapchain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, void**, int>)@this->LpVtbl[72])(@this, phSwapchainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableHorizontalMirrorMode(Silk.NET.Core.Bool32 fEnable)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[73])(@this, fEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAudioStreamCategory(uint* pCategory)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[74])(@this, pCategory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAudioStreamCategory(ref uint pCategory)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCategoryPtr = &pCategory)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[74])(@this, pCategoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAudioStreamCategory(uint category)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int>)@this->LpVtbl[75])(@this, category);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAudioEndpointRole(uint* pRole)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[76])(@this, pRole);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAudioEndpointRole(ref uint pRole)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pRolePtr = &pRole)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint*, int>)@this->LpVtbl[76])(@this, pRolePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAudioEndpointRole(uint role)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, uint, int>)@this->LpVtbl[77])(@this, role);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRealTimeMode(int* pfEnabled)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[78])(@this, pfEnabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRealTimeMode(ref int pfEnabled)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfEnabledPtr = &pfEnabled)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, int*, int>)@this->LpVtbl[78])(@this, pfEnabledPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRealTimeMode(Silk.NET.Core.Bool32 fEnable)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[79])(@this, fEnable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCurrentTimeEx(double seekTime, MediaEngineSeekMode seekMode)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, double, MediaEngineSeekMode, int>)@this->LpVtbl[80])(@this, seekTime, seekMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableTimeUpdateTimer(Silk.NET.Core.Bool32 fEnableTimer)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEx*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[81])(@this, fEnableTimer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetError<TI0>(ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetError((IMFMediaError**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceElements<TI0>(ComPtr<TI0> pSrcElements) where TI0 : unmanaged, IComVtbl<IMFMediaEngineSrcElements>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetSourceElements((IMFMediaEngineSrcElements*) pSrcElements.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentSource(string[] ppUrlSa)
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBuffered((IMFMediaTimeRange**) ppBuffered.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPlayed<TI0>(ref ComPtr<TI0> ppPlayed) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPlayed((IMFMediaTimeRange**) ppPlayed.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSeekable<TI0>(ref ComPtr<TI0> ppSeekable) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSeekable((IMFMediaTimeRange**) ppSeekable.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoNormalizedRect* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, pSrc, in pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] _MFARGB* pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly int TransferVideoFrame<TI0>(ComPtr<TI0> pDstSurf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoNormalizedRect pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in _MFARGB pBorderClr) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TransferVideoFrame((Silk.NET.Core.Native.IUnknown*) pDstSurf.Handle, in pSrc, in pDst, in pBorderClr);
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertVideoEffect<TI0>(ComPtr<TI0> pEffect, Silk.NET.Core.Bool32 fOptional) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InsertVideoEffect((Silk.NET.Core.Native.IUnknown*) pEffect.Handle, fOptional);
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertAudioEffect<TI0>(ComPtr<TI0> pEffect, Silk.NET.Core.Bool32 fOptional) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InsertAudioEffect((Silk.NET.Core.Native.IUnknown*) pEffect.Handle, fOptional);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
