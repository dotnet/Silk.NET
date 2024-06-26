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
    public static unsafe int QueryInterface(this ComPtr<IXAudio2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IXAudio2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IXAudio2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, IXAudio2EngineCallback* pCallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)@this->LpVtbl[3])(@this, pCallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2EngineCallback pCallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)@this->LpVtbl[3])(@this, pCallbackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UnregisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, IXAudio2EngineCallback* pCallback)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallback);
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2EngineCallback pCallback)
    {
        var @this = thisVtbl.Handle;
        fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallbackPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szDeviceIdPtr = &szDeviceId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
        SilkMarshal.Free((nint)szDeviceIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
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
    public static int StartEngine(this ComPtr<IXAudio2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, int>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void StopEngine(this ComPtr<IXAudio2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int CommitChanges(this ComPtr<IXAudio2> thisVtbl, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint, int>)@this->LpVtbl[10])(@this, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPerformanceData(this ComPtr<IXAudio2> thisVtbl, PerformanceData* pPerfData)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)@this->LpVtbl[11])(@this, pPerfData);
    }

    /// <summary>To be documented.</summary>
    public static void GetPerformanceData(this ComPtr<IXAudio2> thisVtbl, ref PerformanceData pPerfData)
    {
        var @this = thisVtbl.Handle;
        fixed (PerformanceData* pPerfDataPtr = &pPerfData)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)@this->LpVtbl[11])(@this, pPerfDataPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, void* pReserved)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReserved);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration<T0>(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pReservedPtr = &pReserved)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugConfiguration pDebugConfiguration, void* pReserved)
    {
        var @this = thisVtbl.Handle;
        fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugConfiguration<T0>(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugConfiguration pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
        {
            fixed (void* pReservedPtr = &pReserved)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IXAudio2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IXAudio2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, Span<IXAudio2EngineCallback> pCallback)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterForCallbacks(ref pCallback.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, Span<IXAudio2EngineCallback> pCallback)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UnregisterForCallbacks(ref pCallback.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, pCallback, in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSourceVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WaveFormatEx> pSourceFormat, uint Flags, float MaxFrequencyRatio, Span<IXAudio2VoiceCallback> pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSourceVoice(ref ppSourceVoice, in pSourceFormat.GetPinnableReference(), Flags, MaxFrequencyRatio, ref pCallback.GetPinnableReference(), in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSubmixVoice(ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSubmixVoice(ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSubmixVoice(ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSubmixVoice(ref ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSubmixVoice(ref ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, in pSendList.GetPinnableReference(), pEffectChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSubmixVoice(ref ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, in pSendList.GetPinnableReference(), in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, in pEffectChain.GetPinnableReference(), StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ppMasteringVoice, InputChannels, InputSampleRate, Flags, in szDeviceId.GetPinnableReference(), pEffectChain, StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ppMasteringVoice, InputChannels, InputSampleRate, Flags, in szDeviceId.GetPinnableReference(), in pEffectChain.GetPinnableReference(), StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, in pEffectChain.GetPinnableReference(), StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ref ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, in pEffectChain.GetPinnableReference(), StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ref ppMasteringVoice, InputChannels, InputSampleRate, Flags, in szDeviceId.GetPinnableReference(), pEffectChain, StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ref ppMasteringVoice, InputChannels, InputSampleRate, Flags, in szDeviceId.GetPinnableReference(), in pEffectChain.GetPinnableReference(), StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMasteringVoice(this ComPtr<IXAudio2> thisVtbl, ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain, AudioStreamCategory StreamCategory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateMasteringVoice(ref ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, in pEffectChain.GetPinnableReference(), StreamCategory);
    }

    /// <summary>To be documented.</summary>
    public static void GetPerformanceData(this ComPtr<IXAudio2> thisVtbl, Span<PerformanceData> pPerfData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetPerformanceData(ref pPerfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration<T0>(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, Span<T0> pReserved) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDebugConfiguration(pDebugConfiguration, ref pReserved.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDebugConfiguration(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugConfiguration> pDebugConfiguration, void* pReserved)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDebugConfiguration(in pDebugConfiguration.GetPinnableReference(), pReserved);
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugConfiguration<T0>(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DebugConfiguration> pDebugConfiguration, Span<T0> pReserved) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetDebugConfiguration(in pDebugConfiguration.GetPinnableReference(), ref pReserved.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IXAudio2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
