// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice"]/*' />
[NativeTypeName("struct IXAudio2SourceVoice : IXAudio2Voice")]
[NativeInheritance("IXAudio2Voice")]
public unsafe partial struct IXAudio2SourceVoice : IXAudio2SourceVoice.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IXAudio2Voice.GetVoiceDetails" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void GetVoiceDetails(XAUDIO2_VOICE_DETAILS* pVoiceDetails)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_VOICE_DETAILS*, void>)(lpVtbl[0]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVoiceDetails);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetOutputVoices" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetOutputVoices([NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_VOICE_SENDS*, int>)(lpVtbl[1]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pSendList);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetEffectChain" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SetEffectChain([NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_EFFECT_CHAIN*, int>)(lpVtbl[2]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pEffectChain);
    }

    /// <inheritdoc cref="IXAudio2Voice.EnableEffect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[3]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.DisableEffect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[4]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetEffectState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetEffectState([NativeTypeName("UINT32")] uint EffectIndex, BOOL* pEnabled)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, uint, BOOL*, void>)(lpVtbl[5]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pEnabled);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetEffectParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)(lpVtbl[6]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetEffectParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, void*, uint, int>)(lpVtbl[7]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetFilterParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFilterParameters([NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(lpVtbl[8]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetFilterParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetFilterParameters(XAUDIO2_FILTER_PARAMETERS* pParameters)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_FILTER_PARAMETERS*, void>)(lpVtbl[9]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pParameters);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetOutputFilterParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(lpVtbl[10]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetOutputFilterParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, XAUDIO2_FILTER_PARAMETERS* pParameters)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, void>)(lpVtbl[11]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetVolume" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetVolume(float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, float, uint, int>)(lpVtbl[12]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Volume, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetVolume" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void GetVolume(float* pVolume)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, float*, void>)(lpVtbl[13]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVolume);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetChannelVolumes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("const float *")] float* pVolumes, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, float*, uint, int>)(lpVtbl[14]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetChannelVolumes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void GetChannelVolumes([NativeTypeName("UINT32")] uint Channels, float* pVolumes)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, uint, float*, void>)(lpVtbl[15]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes);
    }

    /// <inheritdoc cref="IXAudio2Voice.SetOutputMatrix" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetOutputMatrix(IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("const float *")] float* pLevelMatrix, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)(lpVtbl[16]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
    }

    /// <inheritdoc cref="IXAudio2Voice.GetOutputMatrix" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, float* pLevelMatrix)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)(lpVtbl[17]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
    }

    /// <inheritdoc cref="IXAudio2Voice.DestroyVoice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void DestroyVoice()
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, void>)(lpVtbl[18]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Start([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[19]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Flags, OperationSet);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Stop([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[20]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Flags, OperationSet);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.SubmitSourceBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SubmitSourceBuffer([NativeTypeName("const XAUDIO2_BUFFER *")] XAUDIO2_BUFFER* pBuffer, [NativeTypeName("const XAUDIO2_BUFFER_WMA *")] XAUDIO2_BUFFER_WMA* pBufferWMA = null)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_BUFFER*, XAUDIO2_BUFFER_WMA*, int>)(lpVtbl[21]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pBuffer, pBufferWMA);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.FlushSourceBuffers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FlushSourceBuffers()
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, int>)(lpVtbl[22]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.Discontinuity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Discontinuity()
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, int>)(lpVtbl[23]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.ExitLoop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ExitLoop([NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, int>)(lpVtbl[24]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), OperationSet);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.GetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void GetState(XAUDIO2_VOICE_STATE* pVoiceState, [NativeTypeName("UINT32")] uint Flags = 0)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, XAUDIO2_VOICE_STATE*, uint, void>)(lpVtbl[25]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVoiceState, Flags);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.SetFrequencyRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetFrequencyRatio(float Ratio, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, float, uint, int>)(lpVtbl[26]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Ratio, OperationSet);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.GetFrequencyRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void GetFrequencyRatio(float* pRatio)
    {
        ((delegate* unmanaged<IXAudio2SourceVoice*, float*, void>)(lpVtbl[27]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pRatio);
    }

    /// <include file='IXAudio2SourceVoice.xml' path='doc/member[@name="IXAudio2SourceVoice.SetSourceSampleRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetSourceSampleRate([NativeTypeName("UINT32")] uint NewSourceSampleRate)
    {
        return ((delegate* unmanaged<IXAudio2SourceVoice*, uint, int>)(lpVtbl[28]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), NewSourceSampleRate);
    }

    public interface Interface : IXAudio2Voice.Interface
    {
        [VtblIndex(19)]
        HRESULT Start([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [VtblIndex(20)]
        HRESULT Stop([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [VtblIndex(21)]
        HRESULT SubmitSourceBuffer([NativeTypeName("const XAUDIO2_BUFFER *")] XAUDIO2_BUFFER* pBuffer, [NativeTypeName("const XAUDIO2_BUFFER_WMA *")] XAUDIO2_BUFFER_WMA* pBufferWMA = null);

        [VtblIndex(22)]
        HRESULT FlushSourceBuffers();

        [VtblIndex(23)]
        HRESULT Discontinuity();

        [VtblIndex(24)]
        HRESULT ExitLoop([NativeTypeName("UINT32")] uint OperationSet = 0);

        [VtblIndex(25)]
        void GetState(XAUDIO2_VOICE_STATE* pVoiceState, [NativeTypeName("UINT32")] uint Flags = 0);

        [VtblIndex(26)]
        HRESULT SetFrequencyRatio(float Ratio, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [VtblIndex(27)]
        void GetFrequencyRatio(float* pRatio);

        [VtblIndex(28)]
        HRESULT SetSourceSampleRate([NativeTypeName("UINT32")] uint NewSourceSampleRate);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (XAUDIO2_VOICE_DETAILS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_VOICE_DETAILS*, void> GetVoiceDetails;

        [NativeTypeName("HRESULT (const XAUDIO2_VOICE_SENDS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_VOICE_SENDS*, int> SetOutputVoices;

        [NativeTypeName("HRESULT (const XAUDIO2_EFFECT_CHAIN *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_EFFECT_CHAIN*, int> SetEffectChain;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> EnableEffect;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> DisableEffect;

        [NativeTypeName("void (UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, void> GetEffectState;

        [NativeTypeName("HRESULT (UINT32, const void *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, uint, int> SetEffectParameters;

        [NativeTypeName("HRESULT (UINT32, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, int> GetEffectParameters;

        [NativeTypeName("HRESULT (const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_FILTER_PARAMETERS*, uint, int> SetFilterParameters;

        [NativeTypeName("void (XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_FILTER_PARAMETERS*, void> GetFilterParameters;

        [NativeTypeName("HRESULT (IXAudio2Voice *, const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, uint, int> SetOutputFilterParameters;

        [NativeTypeName("void (IXAudio2Voice *, XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, void> GetOutputFilterParameters;

        [NativeTypeName("HRESULT (float, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, uint, int> SetVolume;

        [NativeTypeName("void (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, void> GetVolume;

        [NativeTypeName("HRESULT (UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, uint, int> SetChannelVolumes;

        [NativeTypeName("void (UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, void> GetChannelVolumes;

        [NativeTypeName("HRESULT (IXAudio2Voice *, UINT32, UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXAudio2Voice*, uint, uint, float*, uint, int> SetOutputMatrix;

        [NativeTypeName("void (IXAudio2Voice *, UINT32, UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXAudio2Voice*, uint, uint, float*, void> GetOutputMatrix;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DestroyVoice;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Start;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Stop;

        [NativeTypeName("HRESULT (const XAUDIO2_BUFFER *, const XAUDIO2_BUFFER_WMA *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_BUFFER*, XAUDIO2_BUFFER_WMA*, int> SubmitSourceBuffer;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FlushSourceBuffers;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Discontinuity;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ExitLoop;

        [NativeTypeName("void (XAUDIO2_VOICE_STATE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XAUDIO2_VOICE_STATE*, uint, void> GetState;

        [NativeTypeName("HRESULT (float, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, uint, int> SetFrequencyRatio;

        [NativeTypeName("void (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, void> GetFrequencyRatio;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetSourceSampleRate;
    }
}
