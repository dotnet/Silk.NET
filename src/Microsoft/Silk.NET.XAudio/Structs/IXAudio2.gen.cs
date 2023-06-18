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
    [Guid("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d")]
    [NativeName("Name", "IXAudio2")]
    public unsafe partial struct IXAudio2 : IComVtbl<IXAudio2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IXAudio2 val)
            => Unsafe.As<IXAudio2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IXAudio2
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
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)@this->LpVtbl[3])(@this, pCallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UnregisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallback);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StartEngine()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, int>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void StopEngine()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int CommitChanges(uint OperationSet)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint, int>)@this->LpVtbl[10])(@this, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPerformanceData(PerformanceData* pPerfData)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)@this->LpVtbl[11])(@this, pPerfData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration([Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReserved);
        }

    }
}
