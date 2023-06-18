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

public unsafe static class XAudio2VoiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe void GetVoiceDetails(this ComPtr<IXAudio2Voice> thisVtbl, VoiceDetails* pVoiceDetails)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, VoiceDetails*, void>)@this->LpVtbl[0])(@this, pVoiceDetails);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputVoices(this ComPtr<IXAudio2Voice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, VoiceSends*, int>)@this->LpVtbl[1])(@this, pSendList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffectChain(this ComPtr<IXAudio2Voice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, EffectChain*, int>)@this->LpVtbl[2])(@this, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableEffect(this ComPtr<IXAudio2Voice> thisVtbl, uint EffectIndex, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, uint, int>)@this->LpVtbl[3])(@this, EffectIndex, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableEffect(this ComPtr<IXAudio2Voice> thisVtbl, uint EffectIndex, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, uint, int>)@this->LpVtbl[4])(@this, EffectIndex, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEffectState(this ComPtr<IXAudio2Voice> thisVtbl, uint EffectIndex, int* pEnabled)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, int*, void>)@this->LpVtbl[5])(@this, EffectIndex, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffectParameters(this ComPtr<IXAudio2Voice> thisVtbl, uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pParameters, uint ParametersByteSize, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, void*, uint, uint, int>)@this->LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectParameters(this ComPtr<IXAudio2Voice> thisVtbl, uint EffectIndex, void* pParameters, uint ParametersByteSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, void*, uint, int>)@this->LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFilterParameters(this ComPtr<IXAudio2Voice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[8])(@this, pParameters, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFilterParameters(this ComPtr<IXAudio2Voice> thisVtbl, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[9])(@this, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2Voice> thisVtbl, IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2Voice> thisVtbl, IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoice, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static int SetVolume(this ComPtr<IXAudio2Voice> thisVtbl, float Volume, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, float, uint, int>)@this->LpVtbl[12])(@this, Volume, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetVolume(this ComPtr<IXAudio2Voice> thisVtbl, float* pVolume)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, float*, void>)@this->LpVtbl[13])(@this, pVolume);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetChannelVolumes(this ComPtr<IXAudio2Voice> thisVtbl, uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pVolumes, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, float*, uint, int>)@this->LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetChannelVolumes(this ComPtr<IXAudio2Voice> thisVtbl, uint Channels, float* pVolumes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, uint, float*, void>)@this->LpVtbl[15])(@this, Channels, pVolumes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2Voice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2Voice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
    }

    /// <summary>To be documented.</summary>
    public static void DestroyVoice(this ComPtr<IXAudio2Voice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2Voice*, void>)@this->LpVtbl[18])(@this);
    }

}
