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

namespace Silk.NET.XAudio;

public unsafe static class XAudio2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterForCallbacks<TThis>(this TThis thisVtbl, IXAudio2EngineCallback* pCallback) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)@this->LpVtbl[3])(@this, pCallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterForCallbacks<TThis>(this TThis thisVtbl, ref IXAudio2EngineCallback pCallback) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)@this->LpVtbl[3])(@this, pCallbackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UnregisterForCallbacks<TThis>(this TThis thisVtbl, IXAudio2EngineCallback* pCallback) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallback);
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterForCallbacks<TThis>(this TThis thisVtbl, ref IXAudio2EngineCallback pCallback) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallbackPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice<TThis>(this TThis thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, EffectChain* pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice<TThis>(this TThis thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, ref EffectChain pEffectChain) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
        {
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* szDeviceIdPtr = &szDeviceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* szDeviceIdPtr = &szDeviceId)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
        SilkMarshal.Free((nint)szDeviceIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
        }
        SilkMarshal.Free((nint)szDeviceIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
        var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
        SilkMarshal.Free((nint)szDeviceIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice<TThis>(this TThis thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
        var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            }
        SilkMarshal.Free((nint)szDeviceIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StartEngine<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, int>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void StopEngine<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IXAudio2*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int CommitChanges<TThis>(this TThis thisVtbl, uint OperationSet) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint, int>)@this->LpVtbl[10])(@this, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPerformanceData<TThis>(this TThis thisVtbl, PerformanceData* pPerfData) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)@this->LpVtbl[11])(@this, pPerfData);
    }

    /// <summary>To be documented.</summary>
    public static void GetPerformanceData<TThis>(this TThis thisVtbl, ref PerformanceData pPerfData) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        fixed (PerformanceData* pPerfDataPtr = &pPerfData)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)@this->LpVtbl[11])(@this, pPerfDataPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration<TThis>(this TThis thisVtbl, DebugConfiguration* pDebugConfiguration, void* pReserved) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReserved);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration<T0, TThis>(this TThis thisVtbl, DebugConfiguration* pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        fixed (void* pReservedPtr = &pReserved)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration<TThis>(this TThis thisVtbl, ref DebugConfiguration pDebugConfiguration, void* pReserved) where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugConfiguration<T0, TThis>(this TThis thisVtbl, ref DebugConfiguration pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged where TThis : IComVtbl<IXAudio2>
    {
        var @this = (IXAudio2*) thisVtbl.AsVtblPtr();
        fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
            }
        }
    }

}
