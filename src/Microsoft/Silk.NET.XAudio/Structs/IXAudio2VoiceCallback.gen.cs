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
    [NativeName("Name", "IXAudio2VoiceCallback")]
    public unsafe partial struct IXAudio2VoiceCallback
    {
        public IXAudio2VoiceCallback
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
        public readonly void OnVoiceProcessingPassStart(uint BytesRequired)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2VoiceCallback*, uint, void>)LpVtbl[0])(@this, BytesRequired);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, uint, void>)LpVtbl[0])(@this, BytesRequired);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, uint, void>)LpVtbl[0])(@this, BytesRequired);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OnVoiceProcessingPassEnd()
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void>)LpVtbl[1])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void OnStreamEnd()
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void>)LpVtbl[2])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnBufferStart(void* pBufferContext)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContext);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContext);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContext);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OnBufferStart<T0>(ref T0 pBufferContext) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pBufferContextPtr = &pBufferContext)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContextPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContextPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[3])(@this, pBufferContextPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnBufferEnd(void* pBufferContext)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContext);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContext);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContext);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OnBufferEnd<T0>(ref T0 pBufferContext) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pBufferContextPtr = &pBufferContext)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContextPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContextPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[4])(@this, pBufferContextPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnLoopEnd(void* pBufferContext)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContext);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContext);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContext);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OnLoopEnd<T0>(ref T0 pBufferContext) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pBufferContextPtr = &pBufferContext)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContextPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContextPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, void>)LpVtbl[5])(@this, pBufferContextPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OnVoiceError(void* pBufferContext, int Error)
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContext, Error);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContext, Error);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContext, Error);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OnVoiceError<T0>(ref T0 pBufferContext, int Error) where T0 : unmanaged
        {
            var @this = (IXAudio2VoiceCallback*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pBufferContextPtr = &pBufferContext)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContextPtr, Error);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContextPtr, Error);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2VoiceCallback*, void*, int, void>)LpVtbl[6])(@this, pBufferContextPtr, Error);
                }
            #endif
            }
        }

    }
}
