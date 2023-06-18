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

public unsafe static class XAudio2SourceVoiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe void GetVoiceDetails(this ComPtr<IXAudio2SourceVoice> thisVtbl, VoiceDetails* pVoiceDetails)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceDetails*, void>)@this->LpVtbl[0])(@this, pVoiceDetails);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputVoices(this ComPtr<IXAudio2SourceVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceSends*, int>)@this->LpVtbl[1])(@this, pSendList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffectChain(this ComPtr<IXAudio2SourceVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, EffectChain*, int>)@this->LpVtbl[2])(@this, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableEffect(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint EffectIndex, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)@this->LpVtbl[3])(@this, EffectIndex, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableEffect(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint EffectIndex, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)@this->LpVtbl[4])(@this, EffectIndex, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEffectState(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint EffectIndex, int* pEnabled)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int*, void>)@this->LpVtbl[5])(@this, EffectIndex, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffectParameters(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pParameters, uint ParametersByteSize, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)@this->LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectParameters(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint EffectIndex, void* pParameters, uint ParametersByteSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, void*, uint, int>)@this->LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFilterParameters(this ComPtr<IXAudio2SourceVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)@this->LpVtbl[8])(@this, pParameters, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFilterParameters(this ComPtr<IXAudio2SourceVoice> thisVtbl, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, FilterParameters*, void>)@this->LpVtbl[9])(@this, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2SourceVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2SourceVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoice, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static int SetVolume(this ComPtr<IXAudio2SourceVoice> thisVtbl, float Volume, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float, uint, int>)@this->LpVtbl[12])(@this, Volume, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetVolume(this ComPtr<IXAudio2SourceVoice> thisVtbl, float* pVolume)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float*, void>)@this->LpVtbl[13])(@this, pVolume);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetChannelVolumes(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pVolumes, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, float*, uint, int>)@this->LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetChannelVolumes(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint Channels, float* pVolumes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, float*, void>)@this->LpVtbl[15])(@this, Channels, pVolumes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2SourceVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2SourceVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
    }

    /// <summary>To be documented.</summary>
    public static void DestroyVoice(this ComPtr<IXAudio2SourceVoice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, void>)@this->LpVtbl[18])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int Start(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint Flags, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)@this->LpVtbl[19])(@this, Flags, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stop(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint Flags, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)@this->LpVtbl[20])(@this, Flags, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SubmitSourceBuffer(this ComPtr<IXAudio2SourceVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferWma* pBufferWMA)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)@this->LpVtbl[21])(@this, pBuffer, pBufferWMA);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FlushSourceBuffers(this ComPtr<IXAudio2SourceVoice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, int>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Discontinuity(this ComPtr<IXAudio2SourceVoice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ExitLoop(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int>)@this->LpVtbl[24])(@this, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetState(this ComPtr<IXAudio2SourceVoice> thisVtbl, VoiceState* pVoiceState, uint Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceState*, uint, void>)@this->LpVtbl[25])(@this, pVoiceState, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetFrequencyRatio(this ComPtr<IXAudio2SourceVoice> thisVtbl, float Ratio, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float, uint, int>)@this->LpVtbl[26])(@this, Ratio, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFrequencyRatio(this ComPtr<IXAudio2SourceVoice> thisVtbl, float* pRatio)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float*, void>)@this->LpVtbl[27])(@this, pRatio);
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceSampleRate(this ComPtr<IXAudio2SourceVoice> thisVtbl, uint NewSourceSampleRate)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int>)@this->LpVtbl[28])(@this, NewSourceSampleRate);
        return ret;
    }

}
