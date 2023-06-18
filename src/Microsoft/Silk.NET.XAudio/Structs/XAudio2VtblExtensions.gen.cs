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
    public static unsafe void UnregisterForCallbacks(this ComPtr<IXAudio2> thisVtbl, IXAudio2EngineCallback* pCallback)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallback);
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
    public static unsafe int CreateSubmixVoice(this ComPtr<IXAudio2> thisVtbl, IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
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
    public static unsafe void SetDebugConfiguration(this ComPtr<IXAudio2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, void* pReserved)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReserved);
    }

}
