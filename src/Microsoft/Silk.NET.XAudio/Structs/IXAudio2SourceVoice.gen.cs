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
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetails);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetails);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetails);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetVoiceDetails(ref VoiceDetails pVoiceDetails)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VoiceDetails* pVoiceDetailsPtr = &pVoiceDetails)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetailsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetailsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceDetails*, void>)LpVtbl[0])(@this, pVoiceDetailsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputVoices(VoiceSends* pSendList)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendList);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendList);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendList);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputVoices(ref VoiceSends pSendList)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendListPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendListPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceSends*, int>)LpVtbl[1])(@this, pSendListPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffectChain(EffectChain* pEffectChain)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChain);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChain);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChain);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffectChain(ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChainPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChainPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, EffectChain*, int>)LpVtbl[2])(@this, pEffectChainPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableEffect(uint EffectIndex, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[3])(@this, EffectIndex, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[3])(@this, EffectIndex, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[3])(@this, EffectIndex, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisableEffect(uint EffectIndex, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[4])(@this, EffectIndex, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[4])(@this, EffectIndex, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[4])(@this, EffectIndex, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetEffectState(uint EffectIndex, int* pEnabled)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabled);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabled);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabled);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetEffectState(uint EffectIndex, ref int pEnabled)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabledPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabledPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int*, void>)LpVtbl[5])(@this, EffectIndex, pEnabledPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParameters, ParametersByteSize, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEffectParameters<T0>(uint EffectIndex, ref T0 pParameters, uint ParametersByteSize, uint OperationSet) where T0 : unmanaged
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParametersPtr, ParametersByteSize, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParametersPtr, ParametersByteSize, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)LpVtbl[6])(@this, EffectIndex, pParametersPtr, ParametersByteSize, OperationSet);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParameters, ParametersByteSize);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectParameters<T0>(uint EffectIndex, ref T0 pParameters, uint ParametersByteSize) where T0 : unmanaged
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParametersPtr, ParametersByteSize);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParametersPtr, ParametersByteSize);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, void*, uint, int>)LpVtbl[7])(@this, EffectIndex, pParametersPtr, ParametersByteSize);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFilterParameters(FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParameters, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParameters, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParameters, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFilterParameters(ref FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParametersPtr, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParametersPtr, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, uint, int>)LpVtbl[8])(@this, pParametersPtr, OperationSet);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFilterParameters(FilterParameters* pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParameters);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParameters);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParameters);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFilterParameters(ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParametersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParametersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, FilterParameters*, void>)LpVtbl[9])(@this, pParametersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParameters, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, ref FilterParameters pParameters, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParametersPtr, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParametersPtr, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoice, pParametersPtr, OperationSet);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParameters, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParameters, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParameters, OperationSet);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParametersPtr, OperationSet);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParametersPtr, OperationSet);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)LpVtbl[10])(@this, pDestinationVoicePtr, pParametersPtr, OperationSet);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParameters);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParameters);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParameters);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, ref FilterParameters pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FilterParameters* pParametersPtr = &pParameters)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParametersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParametersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoice, pParametersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputFilterParameters(ref IXAudio2Voice pDestinationVoice, FilterParameters* pParameters)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParameters);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParameters);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParameters);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParametersPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParametersPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, FilterParameters*, void>)LpVtbl[11])(@this, pDestinationVoicePtr, pParametersPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVolume(float Volume, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[12])(@this, Volume, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[12])(@this, Volume, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[12])(@this, Volume, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetVolume(float* pVolume)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolume);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolume);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolume);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetVolume(ref float pVolume)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pVolumePtr = &pVolume)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolumePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolumePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[13])(@this, pVolumePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetChannelVolumes(uint Channels, float* pVolumes, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumes, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetChannelVolumes(uint Channels, ref float pVolumes, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pVolumesPtr = &pVolumes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumesPtr, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumesPtr, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, uint, int>)LpVtbl[14])(@this, Channels, pVolumesPtr, OperationSet);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetChannelVolumes(uint Channels, float* pVolumes)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumes);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumes);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetChannelVolumes(uint Channels, ref float pVolumes)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pVolumesPtr = &pVolumes)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, float*, void>)LpVtbl[15])(@this, Channels, pVolumesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)LpVtbl[16])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr, OperationSet);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, ref float pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLevelMatrixPtr = &pLevelMatrix)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrixPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutputMatrix(ref IXAudio2Voice pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2Voice* pDestinationVoicePtr = &pDestinationVoice)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrix);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)LpVtbl[17])(@this, pDestinationVoicePtr, SourceChannels, DestinationChannels, pLevelMatrixPtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[19])(@this, Flags, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[19])(@this, Flags, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[19])(@this, Flags, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Stop(uint Flags, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[20])(@this, Flags, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[20])(@this, Flags, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, uint, int>)LpVtbl[20])(@this, Flags, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitSourceBuffer(Buffer* pBuffer, BufferWma* pBufferWMA)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMA);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMA);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMA);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitSourceBuffer(Buffer* pBuffer, ref BufferWma pBufferWMA)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BufferWma* pBufferWMAPtr = &pBufferWMA)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMAPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMAPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBuffer, pBufferWMAPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMA);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMA);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMA);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMAPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMAPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, Buffer*, BufferWma*, int>)LpVtbl[21])(@this, pBufferPtr, pBufferWMAPtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, int>)LpVtbl[24])(@this, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int>)LpVtbl[24])(@this, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int>)LpVtbl[24])(@this, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetState(VoiceState* pVoiceState, uint Flags)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceState, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceState, Flags);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceState, Flags);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetState(ref VoiceState pVoiceState, uint Flags)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VoiceState* pVoiceStatePtr = &pVoiceState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceStatePtr, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceStatePtr, Flags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, VoiceState*, uint, void>)LpVtbl[25])(@this, pVoiceStatePtr, Flags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFrequencyRatio(float Ratio, uint OperationSet)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[26])(@this, Ratio, OperationSet);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[26])(@this, Ratio, OperationSet);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float, uint, int>)LpVtbl[26])(@this, Ratio, OperationSet);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFrequencyRatio(float* pRatio)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatio);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatio);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatio);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFrequencyRatio(ref float pRatio)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pRatioPtr = &pRatio)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatioPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatioPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, float*, void>)LpVtbl[27])(@this, pRatioPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceSampleRate(uint NewSourceSampleRate)
        {
            var @this = (IXAudio2SourceVoice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2SourceVoice*, uint, int>)LpVtbl[28])(@this, NewSourceSampleRate);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2SourceVoice*, uint, int>)LpVtbl[28])(@this, NewSourceSampleRate);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2SourceVoice*, uint, int>)LpVtbl[28])(@this, NewSourceSampleRate);
            }
            #endif
            return ret;
        }

    }
}
