// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct IXAudio2MasteringVoice : IXAudio2Voice")]
[NativeInheritance("IXAudio2Voice")]
public unsafe partial struct IXAudio2MasteringVoice : IXAudio2MasteringVoice.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void GetVoiceDetails(XAUDIO2_VOICE_DETAILS* pVoiceDetails)
    {
        (
            (delegate* unmanaged<IXAudio2MasteringVoice*, XAUDIO2_VOICE_DETAILS*, void>)(
                (*lpVtbl)[0]
            )
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pVoiceDetails);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetOutputVoices(
        [NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList
    )
    {
        return (
            (delegate* unmanaged<IXAudio2MasteringVoice*, XAUDIO2_VOICE_SENDS*, int>)((*lpVtbl)[1])
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pSendList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SetEffectChain(
        [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain
    )
    {
        return (
            (delegate* unmanaged<IXAudio2MasteringVoice*, XAUDIO2_EFFECT_CHAIN*, int>)((*lpVtbl)[2])
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pEffectChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnableEffect(
        [NativeTypeName("UINT32")] uint EffectIndex,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return ((delegate* unmanaged<IXAudio2MasteringVoice*, uint, uint, int>)((*lpVtbl)[3]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            EffectIndex,
            OperationSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DisableEffect(
        [NativeTypeName("UINT32")] uint EffectIndex,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return ((delegate* unmanaged<IXAudio2MasteringVoice*, uint, uint, int>)((*lpVtbl)[4]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            EffectIndex,
            OperationSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetEffectState([NativeTypeName("UINT32")] uint EffectIndex, BOOL* pEnabled)
    {
        ((delegate* unmanaged<IXAudio2MasteringVoice*, uint, BOOL*, void>)((*lpVtbl)[5]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            EffectIndex,
            pEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetEffectParameters(
        [NativeTypeName("UINT32")] uint EffectIndex,
        [NativeTypeName("const void *")] void* pParameters,
        [NativeTypeName("UINT32")] uint ParametersByteSize,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return (
            (delegate* unmanaged<IXAudio2MasteringVoice*, uint, void*, uint, uint, int>)(
                (*lpVtbl)[6]
            )
        )(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            EffectIndex,
            pParameters,
            ParametersByteSize,
            OperationSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEffectParameters(
        [NativeTypeName("UINT32")] uint EffectIndex,
        void* pParameters,
        [NativeTypeName("UINT32")] uint ParametersByteSize
    )
    {
        return (
            (delegate* unmanaged<IXAudio2MasteringVoice*, uint, void*, uint, int>)((*lpVtbl)[7])
        )(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            EffectIndex,
            pParameters,
            ParametersByteSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFilterParameters(
        [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")]
            XAUDIO2_FILTER_PARAMETERS* pParameters,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return (
            (delegate* unmanaged<IXAudio2MasteringVoice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(
                (*lpVtbl)[8]
            )
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetFilterParameters(XAUDIO2_FILTER_PARAMETERS* pParameters)
    {
        (
            (delegate* unmanaged<IXAudio2MasteringVoice*, XAUDIO2_FILTER_PARAMETERS*, void>)(
                (*lpVtbl)[9]
            )
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetOutputFilterParameters(
        IXAudio2Voice* pDestinationVoice,
        [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")]
            XAUDIO2_FILTER_PARAMETERS* pParameters,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return (
            (delegate* unmanaged<
                IXAudio2MasteringVoice*,
                IXAudio2Voice*,
                XAUDIO2_FILTER_PARAMETERS*,
                uint,
                int>)((*lpVtbl)[10])
        )(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            pDestinationVoice,
            pParameters,
            OperationSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetOutputFilterParameters(
        IXAudio2Voice* pDestinationVoice,
        XAUDIO2_FILTER_PARAMETERS* pParameters
    )
    {
        (
            (delegate* unmanaged<
                IXAudio2MasteringVoice*,
                IXAudio2Voice*,
                XAUDIO2_FILTER_PARAMETERS*,
                void>)((*lpVtbl)[11])
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetVolume(float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0)
    {
        return ((delegate* unmanaged<IXAudio2MasteringVoice*, float, uint, int>)((*lpVtbl)[12]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            Volume,
            OperationSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void GetVolume(float* pVolume)
    {
        ((delegate* unmanaged<IXAudio2MasteringVoice*, float*, void>)((*lpVtbl)[13]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            pVolume
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetChannelVolumes(
        [NativeTypeName("UINT32")] uint Channels,
        [NativeTypeName("const float *")] float* pVolumes,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return (
            (delegate* unmanaged<IXAudio2MasteringVoice*, uint, float*, uint, int>)((*lpVtbl)[14])
        )((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void GetChannelVolumes([NativeTypeName("UINT32")] uint Channels, float* pVolumes)
    {
        ((delegate* unmanaged<IXAudio2MasteringVoice*, uint, float*, void>)((*lpVtbl)[15]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            Channels,
            pVolumes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetOutputMatrix(
        IXAudio2Voice* pDestinationVoice,
        [NativeTypeName("UINT32")] uint SourceChannels,
        [NativeTypeName("UINT32")] uint DestinationChannels,
        [NativeTypeName("const float *")] float* pLevelMatrix,
        [NativeTypeName("UINT32")] uint OperationSet = 0
    )
    {
        return (
            (delegate* unmanaged<
                IXAudio2MasteringVoice*,
                IXAudio2Voice*,
                uint,
                uint,
                float*,
                uint,
                int>)((*lpVtbl)[16])
        )(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            pDestinationVoice,
            SourceChannels,
            DestinationChannels,
            pLevelMatrix,
            OperationSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void GetOutputMatrix(
        IXAudio2Voice* pDestinationVoice,
        [NativeTypeName("UINT32")] uint SourceChannels,
        [NativeTypeName("UINT32")] uint DestinationChannels,
        float* pLevelMatrix
    )
    {
        (
            (delegate* unmanaged<
                IXAudio2MasteringVoice*,
                IXAudio2Voice*,
                uint,
                uint,
                float*,
                void>)((*lpVtbl)[17])
        )(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            pDestinationVoice,
            SourceChannels,
            DestinationChannels,
            pLevelMatrix
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void DestroyVoice()
    {
        ((delegate* unmanaged<IXAudio2MasteringVoice*, void>)((*lpVtbl)[18]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetChannelMask([NativeTypeName("DWORD *")] uint* pChannelmask)
    {
        return ((delegate* unmanaged<IXAudio2MasteringVoice*, uint*, int>)((*lpVtbl)[19]))(
            (IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this),
            pChannelmask
        );
    }

    public interface Interface : IXAudio2Voice.Interface
    {
        [VtblIndex(19)]
        HRESULT GetChannelMask([NativeTypeName("DWORD *")] uint* pChannelmask);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "void (XAUDIO2_VOICE_DETAILS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, XAUDIO2_VOICE_DETAILS*, void> GetVoiceDetails;

        [NativeTypeName(
            "HRESULT (const XAUDIO2_VOICE_SENDS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, XAUDIO2_VOICE_SENDS*, int> SetOutputVoices;

        [NativeTypeName(
            "HRESULT (const XAUDIO2_EFFECT_CHAIN *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, XAUDIO2_EFFECT_CHAIN*, int> SetEffectChain;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, int> EnableEffect;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, int> DisableEffect;

        [NativeTypeName("void (UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, void> GetEffectState;

        [NativeTypeName(
            "HRESULT (UINT32, const void *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void*, uint, uint, int> SetEffectParameters;

        [NativeTypeName(
            "HRESULT (UINT32, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void*, uint, int> GetEffectParameters;

        [NativeTypeName(
            "HRESULT (const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            XAUDIO2_FILTER_PARAMETERS*,
            uint,
            int> SetFilterParameters;

        [NativeTypeName(
            "void (XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, XAUDIO2_FILTER_PARAMETERS*, void> GetFilterParameters;

        [NativeTypeName(
            "HRESULT (IXAudio2Voice *, const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IXAudio2Voice*,
            XAUDIO2_FILTER_PARAMETERS*,
            uint,
            int> SetOutputFilterParameters;

        [NativeTypeName(
            "void (IXAudio2Voice *, XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IXAudio2Voice*,
            XAUDIO2_FILTER_PARAMETERS*,
            void> GetOutputFilterParameters;

        [NativeTypeName(
            "HRESULT (float, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float, uint, int> SetVolume;

        [NativeTypeName("void (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, void> GetVolume;

        [NativeTypeName(
            "HRESULT (UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, uint, int> SetChannelVolumes;

        [NativeTypeName("void (UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, void> GetChannelVolumes;

        [NativeTypeName(
            "HRESULT (IXAudio2Voice *, UINT32, UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IXAudio2Voice*,
            uint,
            uint,
            float*,
            uint,
            int> SetOutputMatrix;

        [NativeTypeName(
            "void (IXAudio2Voice *, UINT32, UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IXAudio2Voice*,
            uint,
            uint,
            float*,
            void> GetOutputMatrix;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DestroyVoice;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelMask;
    }
}
