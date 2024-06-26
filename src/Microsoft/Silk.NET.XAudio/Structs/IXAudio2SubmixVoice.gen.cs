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
    [NativeName("Name", "IXAudio2SubmixVoice")]
    public unsafe partial struct IXAudio2SubmixVoice : IComVtbl<IXAudio2SubmixVoice>, IComVtbl<IXAudio2Voice>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IXAudio2Voice(IXAudio2SubmixVoice val)
            => Unsafe.As<IXAudio2SubmixVoice, IXAudio2Voice>(ref val);

        public IXAudio2SubmixVoice
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
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceDetails*, void>)@this->LpVtbl[0])(@this, pVoiceDetails);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetVoiceDetails(ref VoiceDetails pVoiceDetails)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VoiceDetails* pVoiceDetailsPtr = &pVoiceDetails)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceDetails*, void>)@this->LpVtbl[0])(@this, pVoiceDetailsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputVoices([Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceSends*, int>)@this->LpVtbl[1])(@this, pSendList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputVoices([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, VoiceSends*, int>)@this->LpVtbl[1])(@this, pSendListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffectChain([Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, EffectChain*, int>)@this->LpVtbl[2])(@this, pEffectChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffectChain([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, EffectChain*, int>)@this->LpVtbl[2])(@this, pEffectChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableEffect(uint EffectIndex, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, uint, int>)@this->LpVtbl[3])(@this, EffectIndex, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisableEffect(uint EffectIndex, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, uint, int>)@this->LpVtbl[4])(@this, EffectIndex, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEffectState(uint EffectIndex, int* pEnabled)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, int*, void>)@this->LpVtbl[5])(@this, EffectIndex, pEnabled);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetEffectState(uint EffectIndex, ref int pEnabled)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, int*, void>)@this->LpVtbl[5])(@this, EffectIndex, pEnabledPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffectParameters(uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pParameters, uint ParametersByteSize, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, uint, int>)@this->LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffectParameters<T0>(uint EffectIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pParameters, uint ParametersByteSize, uint OperationSet) where T0 : unmanaged
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, uint, int>)@this->LpVtbl[6])(@this, EffectIndex, pParametersPtr, ParametersByteSize, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, int>)@this->LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectParameters<T0>(uint EffectIndex, ref T0 pParameters, uint ParametersByteSize) where T0 : unmanaged
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, void*, uint, int>)@this->LpVtbl[7])(@this, EffectIndex, pParametersPtr, ParametersByteSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFilterParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, uint, int>)@this->LpVtbl[8])(@this, pParameters, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFilterParameters([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, uint, int>)@this->LpVtbl[8])(@this, pParametersPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFilterParameters(FilterParameters* pParameters)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, void>)@this->LpVtbl[9])(@this, pParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFilterParameters(ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, FilterParameters*, void>)@this->LpVtbl[9])(@this, pParametersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoice, pParametersPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)@this->LpVtbl[10])(@this, pDestinationVoicePtr, pParameters, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoice, pParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoice, pParametersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, FilterParameters* pParameters)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoicePtr, pParameters);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                fixed (FilterParameters* pParametersPtr = &pParameters)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, FilterParameters*, void>)@this->LpVtbl[11])(@this, pDestinationVoicePtr, pParametersPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVolume(float Volume, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, float, uint, int>)@this->LpVtbl[12])(@this, Volume, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetVolume(float* pVolume)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, float*, void>)@this->LpVtbl[13])(@this, pVolume);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetVolume(ref float pVolume)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pVolumePtr = &pVolume)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, float*, void>)@this->LpVtbl[13])(@this, pVolumePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetChannelVolumes(uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pVolumes, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, uint, int>)@this->LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetChannelVolumes(uint Channels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pVolumes, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pVolumesPtr = &pVolumes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, uint, int>)@this->LpVtbl[14])(@this, Channels, pVolumesPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetChannelVolumes(uint Channels, float* pVolumes)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, void>)@this->LpVtbl[15])(@this, Channels, pVolumes);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetChannelVolumes(uint Channels, ref float pVolumes)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pVolumesPtr = &pVolumes)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, uint, float*, void>)@this->LpVtbl[15])(@this, Channels, pVolumesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)@this->LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
                fixed (float* pLevelMatrixPtr = &pLevelMatrix)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)@this->LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DestroyVoice()
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2SubmixVoice*, void>)@this->LpVtbl[18])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters<TI0>(ComPtr<TI0> pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FilterParameters* pParameters, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, pParameters, OperationSet);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputFilterParameters<TI0>(ComPtr<TI0> pDestinationVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FilterParameters pParameters, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, in pParameters, OperationSet);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters<TI0>(ComPtr<TI0> pDestinationVoice, FilterParameters* pParameters) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, pParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputFilterParameters<TI0>(ComPtr<TI0> pDestinationVoice, ref FilterParameters pParameters) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetOutputFilterParameters((IXAudio2Voice*) pDestinationVoice.Handle, ref pParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix<TI0>(ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pLevelMatrix, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputMatrix<TI0>(ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pLevelMatrix, uint OperationSet) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, in pLevelMatrix, OperationSet);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix<TI0>(ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetOutputMatrix<TI0>(ComPtr<TI0> pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix) where TI0 : unmanaged, IComVtbl<IXAudio2Voice>, IComVtbl<TI0>
        {
            var @this = (IXAudio2SubmixVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetOutputMatrix((IXAudio2Voice*) pDestinationVoice.Handle, SourceChannels, DestinationChannels, ref pLevelMatrix);
        }

    }
}
