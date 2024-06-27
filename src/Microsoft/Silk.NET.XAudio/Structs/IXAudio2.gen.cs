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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly int RegisterForCallbacks(ref IXAudio2EngineCallback pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, int>)@this->LpVtbl[3])(@this, pCallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UnregisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallback);
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterForCallbacks(ref IXAudio2EngineCallback pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2EngineCallback*, void>)@this->LpVtbl[4])(@this, pCallbackPtr);
            }
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
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (VoiceSends* pSendListPtr = &pSendList)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        fixed (VoiceSends* pSendListPtr = &pSendList)
                        {
                            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)@this->LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                            }
                        }
                    }
                }
            }
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
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VoiceSends* pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VoiceSends pSendList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)@this->LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
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
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            SilkMarshal.Free((nint)szDeviceIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            }
            SilkMarshal.Free((nint)szDeviceIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (char* szDeviceIdPtr = &szDeviceId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (char* szDeviceIdPtr = &szDeviceId)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            SilkMarshal.Free((nint)szDeviceIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string szDeviceId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            var szDeviceIdPtr = (byte*) SilkMarshal.StringToPtr(szDeviceId, NativeStringEncoding.LPWStr);
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)@this->LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
            SilkMarshal.Free((nint)szDeviceIdPtr);
            }
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
        public readonly void GetPerformanceData(ref PerformanceData pPerfData)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PerformanceData* pPerfDataPtr = &pPerfData)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, PerformanceData*, void>)@this->LpVtbl[11])(@this, pPerfDataPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration([Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReserved);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugConfiguration* pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pReservedPtr = &pReserved)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugConfiguration pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugConfiguration<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugConfiguration pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2*, DebugConfiguration*, void*, void>)@this->LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
