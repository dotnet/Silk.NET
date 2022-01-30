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

namespace Silk.NET.XAudio
{
    [Guid("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d")]
    [NativeName("Name", "IXAudio2")]
    public unsafe partial struct IXAudio2
    {
        public static readonly Guid Guid = new("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IXAudio2 val)
            => Unsafe.As<IXAudio2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IXAudio2
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
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallback);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallback);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallback);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterForCallbacks(ref IXAudio2EngineCallback pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallbackPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallbackPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallbackPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UnregisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallback);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallback);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallback);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterForCallbacks(ref IXAudio2EngineCallback pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallbackPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallbackPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallbackPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (VoiceSends* pSendListPtr = &pSendList)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (VoiceSends* pSendListPtr = &pSendList)
                        {
                            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                            {
            #if NET5_0_OR_GREATER
                                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                                }
                                else
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            }
            #endif
            SilkMarshal.Free((nint)szDeviceIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
            #endif
            }
            SilkMarshal.Free((nint)szDeviceIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (char* szDeviceIdPtr = &szDeviceId)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (char* szDeviceIdPtr = &szDeviceId)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                }
            #endif
            SilkMarshal.Free((nint)szDeviceIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                    }
            #endif
                }
            SilkMarshal.Free((nint)szDeviceIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StartEngine()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, int>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void StopEngine()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, void>)LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int CommitChanges(uint OperationSet)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2*, uint, int>)LpVtbl[10])(@this, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint, int>)LpVtbl[10])(@this, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, uint, int>)LpVtbl[10])(@this, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPerformanceData(PerformanceData* pPerfData)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfData);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfData);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetPerformanceData(ref PerformanceData pPerfData)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PerformanceData* pPerfDataPtr = &pPerfData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfDataPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfDataPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration(DebugConfiguration* pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReserved);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReserved);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReserved);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration<T0>(DebugConfiguration* pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pReservedPtr = &pReserved)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration(ref DebugConfiguration pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugConfiguration<T0>(ref DebugConfiguration pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
                    }
            #endif
                }
            }
        }

    }
}
