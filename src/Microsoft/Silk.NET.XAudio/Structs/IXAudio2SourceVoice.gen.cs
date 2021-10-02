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
    [NativeName("Name", "IXAudio2SourceVoice")]
    public unsafe partial struct IXAudio2SourceVoice
    {
        public static implicit operator IXAudio2Voice(IXAudio2SourceVoice val)
            => Unsafe.As<IXAudio2SourceVoice, IXAudio2Voice>(ref val);

        public IXAudio2SourceVoice
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
        public readonly unsafe void GetVoiceDetails(VoiceDetails* pVoiceDetails)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetails);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetVoiceDetails(ref VoiceDetails pVoiceDetails)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VoiceDetails* pVoiceDetailsPtr = &pVoiceDetails)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetailsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputVoices(VoiceSends* pSendList)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputVoices(ref VoiceSends pSendList)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffectChain(EffectChain* pEffectChain)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffectChain(ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableEffect(uint EffectIndex, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[3])(@this, EffectIndex, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisableEffect(uint EffectIndex, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[4])(@this, EffectIndex, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEffectState(uint EffectIndex, int* pEnabled)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetEffectState(uint EffectIndex, ref int pEnabled)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabledPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffectParameters<T0>(uint EffectIndex, ref T0 pParameters, uint ParametersByteSize, uint OperationSet) where T0 : unmanaged
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, T0*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParametersPtr, ParametersByteSize, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectParameters<T0>(uint EffectIndex, ref T0 pParameters, uint ParametersByteSize) where T0 : unmanaged
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, T0*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParametersPtr, ParametersByteSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFilterParameters(FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParameters, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFilterParameters(ref FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParametersPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFilterParameters(FilterParameters* pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFilterParameters(ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParametersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, ref FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParametersPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParameters, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, ref FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                fixed (FilterParameters* pParametersPtr = &pParameters)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParametersPtr, OperationSet);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParametersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, FilterParameters* pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParameters);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                fixed (FilterParameters* pParametersPtr = &pParameters)
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParametersPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVolume(float Volume, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[12])(@this, Volume, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetVolume(float* pVolume)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolume);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetVolume(ref float pVolume)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pVolumePtr = &pVolume)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolumePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetChannelVolumes(uint Channels, float* pVolumes, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetChannelVolumes(uint Channels, ref float pVolumes, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pVolumesPtr = &pVolumes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumesPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetChannelVolumes(uint Channels, float* pVolumes)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumes);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetChannelVolumes(uint Channels, ref float pVolumes)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pVolumesPtr = &pVolumes)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                fixed (float* pLevelMatrixPtr = &pLevelMatrix)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                fixed (float* pLevelMatrixPtr = &pLevelMatrix)
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DestroyVoice()
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, void>)LpVtbl[18])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int Start(uint Flags, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[19])(@this, Flags, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Stop(uint Flags, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[20])(@this, Flags, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitSourceBuffer(Buffer* pBuffer, BufferWma* pBufferWMA)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMA);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitSourceBuffer(Buffer* pBuffer, ref BufferWma pBufferWMA)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BufferWma* pBufferWMAPtr = &pBufferWMA)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMAPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitSourceBuffer(ref Buffer pBuffer, BufferWma* pBufferWMA)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pBufferPtr = &pBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMA);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitSourceBuffer(ref Buffer pBuffer, ref BufferWma pBufferWMA)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pBufferPtr = &pBuffer)
            {
                fixed (BufferWma* pBufferWMAPtr = &pBufferWMA)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMAPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FlushSourceBuffers()
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, int>)LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Discontinuity()
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, int>)LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ExitLoop(uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int>)LpVtbl[24])(@this, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetState(VoiceState* pVoiceState, uint Flags)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceState, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetState(ref VoiceState pVoiceState, uint Flags)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VoiceState* pVoiceStatePtr = &pVoiceState)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceStatePtr, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFrequencyRatio(float Ratio, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[26])(@this, Ratio, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFrequencyRatio(float* pRatio)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatio);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFrequencyRatio(ref float pRatio)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pRatioPtr = &pRatio)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatioPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceSampleRate(uint NewSourceSampleRate)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int>)LpVtbl[28])(@this, NewSourceSampleRate);
            return ret;
        }

    }
}
