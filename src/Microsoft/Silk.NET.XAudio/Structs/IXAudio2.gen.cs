// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    public unsafe partial struct IXAudio2
    {
        public static readonly Guid Guid = new("2b02e3cf-2e0b-4ec3-be45-1b2a3fe7210d");

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
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterForCallbacks(ref IXAudio2EngineCallback pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, int>)LpVtbl[3])(@this, pCallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UnregisterForCallbacks(IXAudio2EngineCallback* pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallback);
        }

        /// <summary>To be documented.</summary>
        public readonly void UnregisterForCallbacks(ref IXAudio2EngineCallback pCallback)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IXAudio2EngineCallback* pCallbackPtr = &pCallback)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2EngineCallback*, void>)LpVtbl[4])(@this, pCallbackPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(IXAudio2SourceVoice** ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoice, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, WaveFormatEx* pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormat, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (VoiceSends* pSendListPtr = &pSendList)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, IXAudio2VoiceCallback* pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallback, pSendListPtr, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SourceVoice** ppSourceVoicePtr = &ppSourceVoice)
            {
                fixed (WaveFormatEx* pSourceFormatPtr = &pSourceFormat)
                {
                    fixed (IXAudio2VoiceCallback* pCallbackPtr = &pCallback)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChain);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, VoiceSends* pSendList, ref EffectChain pEffectChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendList, pEffectChainPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, EffectChain* pEffectChain)
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
                            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChain);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSourceVoice(ref IXAudio2SourceVoice* ppSourceVoice, ref WaveFormatEx pSourceFormat, uint Flags, float MaxFrequencyRatio, ref IXAudio2VoiceCallback pCallback, ref VoiceSends pSendList, ref EffectChain pEffectChain)
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
                                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SourceVoice**, WaveFormatEx*, uint, float, IXAudio2VoiceCallback*, VoiceSends*, EffectChain*, int>)LpVtbl[5])(@this, ppSourceVoicePtr, pSourceFormatPtr, Flags, MaxFrequencyRatio, pCallbackPtr, pSendListPtr, pEffectChainPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(IXAudio2SubmixVoice** ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VoiceSends* pSendListPtr = &pSendList)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, VoiceSends* pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, EffectChain* pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChain);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubmixVoice(ref IXAudio2SubmixVoice* ppSubmixVoice, uint InputChannels, uint InputSampleRate, uint Flags, uint ProcessingStage, ref VoiceSends pSendList, ref EffectChain pEffectChain)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2SubmixVoice** ppSubmixVoicePtr = &ppSubmixVoice)
            {
                fixed (VoiceSends* pSendListPtr = &pSendList)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2SubmixVoice**, uint, uint, uint, uint, VoiceSends*, EffectChain*, int>)LpVtbl[6])(@this, ppSubmixVoicePtr, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendListPtr, pEffectChainPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDeviceIdPtr = &szDeviceId)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, string szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDeviceIdPtr = (byte*) Marshal.StringToHGlobalAnsi(szDeviceId);
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            Marshal.FreeHGlobal((nint)szDeviceIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(IXAudio2MasteringVoice** ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, string szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDeviceIdPtr = (byte*) Marshal.StringToHGlobalAnsi(szDeviceId);
            fixed (EffectChain* pEffectChainPtr = &pEffectChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
            }
            Marshal.FreeHGlobal((nint)szDeviceIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, char* szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChainPtr, StreamCategory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (char* szDeviceIdPtr = &szDeviceId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, ref char szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
                fixed (char* szDeviceIdPtr = &szDeviceId)
                {
                    fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, char*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, string szDeviceId, EffectChain* pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            var szDeviceIdPtr = (byte*) Marshal.StringToHGlobalAnsi(szDeviceId);
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChain, StreamCategory);
            Marshal.FreeHGlobal((nint)szDeviceIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMasteringVoice(ref IXAudio2MasteringVoice* ppMasteringVoice, uint InputChannels, uint InputSampleRate, uint Flags, string szDeviceId, ref EffectChain pEffectChain, AudioStreamCategory StreamCategory)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IXAudio2MasteringVoice** ppMasteringVoicePtr = &ppMasteringVoice)
            {
            var szDeviceIdPtr = (byte*) Marshal.StringToHGlobalAnsi(szDeviceId);
                fixed (EffectChain* pEffectChainPtr = &pEffectChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, IXAudio2MasteringVoice**, uint, uint, uint, byte*, EffectChain*, AudioStreamCategory, int>)LpVtbl[7])(@this, ppMasteringVoicePtr, InputChannels, InputSampleRate, Flags, szDeviceIdPtr, pEffectChainPtr, StreamCategory);
                }
            Marshal.FreeHGlobal((nint)szDeviceIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StartEngine()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2*, int>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void StopEngine()
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2*, void>)LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int CommitChanges(uint OperationSet)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2*, uint, int>)LpVtbl[10])(@this, OperationSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPerformanceData(PerformanceData* pPerfData)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfData);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetPerformanceData(ref PerformanceData pPerfData)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PerformanceData* pPerfDataPtr = &pPerfData)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, PerformanceData*, void>)LpVtbl[11])(@this, pPerfDataPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration(DebugConfiguration* pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReserved);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration<T0>(DebugConfiguration* pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pReservedPtr = &pReserved)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, T0*, void>)LpVtbl[12])(@this, pDebugConfiguration, pReservedPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDebugConfiguration(ref DebugConfiguration pDebugConfiguration, void* pReserved)
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, void*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReserved);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugConfiguration<T0>(ref DebugConfiguration pDebugConfiguration, ref T0 pReserved) where T0 : unmanaged
        {
            var @this = (IXAudio2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DebugConfiguration* pDebugConfigurationPtr = &pDebugConfiguration)
            {
                fixed (T0* pReservedPtr = &pReserved)
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2*, DebugConfiguration*, T0*, void>)LpVtbl[12])(@this, pDebugConfigurationPtr, pReservedPtr);
                }
            }
        }

    }
}
