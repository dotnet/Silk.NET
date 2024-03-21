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

public unsafe static class XAudio2SubmixVoiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe void GetVoiceDetails(this ComPtr<IXAudio2SubmixVoice> thisVtbl, VoiceDetails* pVoiceDetails)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceDetails*, void>)@this->LpVtbl[0])(@this, pVoiceDetails);
    }

    /// <summary>To be documented.</summary>
    public static void GetVoiceDetails(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref VoiceDetails pVoiceDetails)
    {
        var @this = thisVtbl.Handle;
        fixed (VoiceDetails* pVoiceDetailsPtr = &pVoiceDetails)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceDetails*, void>)@this->LpVtbl[0])(@this, pVoiceDetailsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputVoices(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceSends*, int>)@this->LpVtbl[1])(@this, pSendList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputVoices(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (VoiceSends* pSendListPtr = &pSendList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceSends*, int>)@this->LpVtbl[1])(@this, pSendListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffectChain(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, EffectChain*, int>)@this->LpVtbl[2])(@this, pEffectChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEffectChain(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, EffectChain*, int>)@this->LpVtbl[2])(@this, pEffectChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableEffect(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, uint, int>)@this->LpVtbl[3])(@this, EffectIndex, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableEffect(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, uint, int>)@this->LpVtbl[4])(@this, EffectIndex, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEffectState(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, int* pEnabled)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, int*, void>)@this->LpVtbl[5])(@this, EffectIndex, pEnabled);
    }

    /// <summary>To be documented.</summary>
    public static void GetEffectState(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, ref int pEnabled)
    {
        var @this = thisVtbl.Handle;
        fixed (int* pEnabledPtr = &pEnabled)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, int*, void>)@this->LpVtbl[5])(@this, EffectIndex, pEnabledPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffectParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pParameters, uint ParametersByteSize, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, uint, int>)@this->LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEffectParameters<T0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pParameters, uint ParametersByteSize, uint OperationSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, uint, int>)@this->LpVtbl[6])(@this, EffectIndex, pParametersPtr, ParametersByteSize, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, void* pParameters, uint ParametersByteSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, int>)@this->LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectParameters<T0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, ref T0 pParameters, uint ParametersByteSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, int>)@this->LpVtbl[7])(@this, EffectIndex, pParametersPtr, ParametersByteSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, uint, int>)@this->LpVtbl[8])(@this, pParameters, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FilterParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, uint, int>)@this->LpVtbl[8])(@this, pParametersPtr, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, void>)@this->LpVtbl[9])(@this, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static void GetFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref FilterParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        fixed (FilterParameters* pParametersPtr = &pParameters)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, void>)@this->LpVtbl[9])(@this, pParametersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FilterParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoice, pParametersPtr, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoicePtr, pParameters, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoicePtr, pParametersPtr, OperationSet);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoice, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, ref FilterParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        fixed (FilterParameters* pParametersPtr = &pParameters)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoice, pParametersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoicePtr, pParameters);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, ref FilterParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoicePtr, pParametersPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int SetVolume(this ComPtr<IXAudio2SubmixVoice> thisVtbl, float Volume, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, float, uint, int>)@this->LpVtbl[12])(@this, Volume, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetVolume(this ComPtr<IXAudio2SubmixVoice> thisVtbl, float* pVolume)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, float*, void>)@this->LpVtbl[13])(@this, pVolume);
    }

    /// <summary>To be documented.</summary>
    public static void GetVolume(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref float pVolume)
    {
        var @this = thisVtbl.Handle;
        fixed (float* pVolumePtr = &pVolume)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, float*, void>)@this->LpVtbl[13])(@this, pVolumePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetChannelVolumes(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pVolumes, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, uint, int>)@this->LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetChannelVolumes(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pVolumes, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pVolumesPtr = &pVolumes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, uint, int>)@this->LpVtbl[14])(@this, Channels, pVolumesPtr, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetChannelVolumes(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint Channels, float* pVolumes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, void>)@this->LpVtbl[15])(@this, Channels, pVolumes);
    }

    /// <summary>To be documented.</summary>
    public static void GetChannelVolumes(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint Channels, ref float pVolumes)
    {
        var @this = thisVtbl.Handle;
        fixed (float* pVolumesPtr = &pVolumes)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, void>)@this->LpVtbl[15])(@this, Channels, pVolumesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pLevelMatrixPtr = &pLevelMatrix)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        fixed (float* pLevelMatrixPtr = &pLevelMatrix)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
        {
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void DestroyVoice(this ComPtr<IXAudio2SubmixVoice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, void>)@this->LpVtbl[18])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void GetVoiceDetails(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<VoiceDetails> pVoiceDetails)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetVoiceDetails(ref pVoiceDetails.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputVoices(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VoiceSends> pSendList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputVoices(in pSendList.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetEffectChain(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EffectChain> pEffectChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEffectChain(in pEffectChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetEffectState(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, Span<int> pEnabled)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetEffectState(EffectIndex, ref pEnabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetEffectParameters<T0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pParameters, uint ParametersByteSize, uint OperationSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetEffectParameters(EffectIndex, in pParameters.GetPinnableReference(), ParametersByteSize, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static int GetEffectParameters<T0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint EffectIndex, Span<T0> pParameters, uint ParametersByteSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetEffectParameters(EffectIndex, ref pParameters.GetPinnableReference(), ParametersByteSize);
    }

    /// <summary>To be documented.</summary>
    public static int SetFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FilterParameters> pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFilterParameters(in pParameters.GetPinnableReference(), OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static void GetFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<FilterParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetFilterParameters(ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, pParameters, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FilterParameters> pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputFilterParameters(pDestinationVoice, in pParameters.GetPinnableReference(), OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputFilterParameters<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, in pParameters, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputFilterParameters(ref pDestinationVoice.GetPinnableReference(), pParameters, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FilterParameters> pParameters, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputFilterParameters(ref pDestinationVoice.GetPinnableReference(), in pParameters.GetPinnableReference(), OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, FilterParameters* pParameters) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, pParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, Span<FilterParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetOutputFilterParameters(pDestinationVoice, ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetOutputFilterParameters<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, ref FilterParameters pParameters) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, ref pParameters);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, FilterParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetOutputFilterParameters(ref pDestinationVoice.GetPinnableReference(), pParameters);
    }

    /// <summary>To be documented.</summary>
    public static void GetOutputFilterParameters(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, Span<FilterParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetOutputFilterParameters(ref pDestinationVoice.GetPinnableReference(), ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetVolume(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<float> pVolume)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetVolume(ref pVolume.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetChannelVolumes(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pVolumes, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetChannelVolumes(Channels, in pVolumes.GetPinnableReference(), OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static void GetChannelVolumes(this ComPtr<IXAudio2SubmixVoice> thisVtbl, uint Channels, Span<float> pVolumes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetChannelVolumes(Channels, ref pVolumes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputMatrix(pDestinationVoice, SourceChannels, DestinationChannels, in pLevelMatrix.GetPinnableReference(), OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputMatrix<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pLevelMatrix, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, in pLevelMatrix, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputMatrix(ref pDestinationVoice.GetPinnableReference(), SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pLevelMatrix, uint OperationSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputMatrix(ref pDestinationVoice.GetPinnableReference(), SourceChannels, DestinationChannels, in pLevelMatrix.GetPinnableReference(), OperationSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, pLevelMatrix);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, Span<float> pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetOutputMatrix(pDestinationVoice, SourceChannels, DestinationChannels, ref pLevelMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetOutputMatrix<TI0>(this ComPtr<IXAudio2SubmixVoice> thisVtbl, ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, ref pLevelMatrix);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetOutputMatrix(ref pDestinationVoice.GetPinnableReference(), SourceChannels, DestinationChannels, pLevelMatrix);
    }

    /// <summary>To be documented.</summary>
    public static void GetOutputMatrix(this ComPtr<IXAudio2SubmixVoice> thisVtbl, Span<IXAudio2Voice> pDestinationVoice, uint SourceChannels, uint DestinationChannels, Span<float> pLevelMatrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetOutputMatrix(ref pDestinationVoice.GetPinnableReference(), SourceChannels, DestinationChannels, ref pLevelMatrix.GetPinnableReference());
    }

}
