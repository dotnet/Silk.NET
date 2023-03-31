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

public unsafe static class XAudio2VoiceCallbackVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static void OnVoiceProcessingPassStart(this ComPtr<IXAudio2VoiceCallback> thisVtbl, uint BytesRequired)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, uint, void>)@this->LpVtbl[0])(@this, BytesRequired);
    }

    /// <summary>To be documented.</summary>
    public static void OnVoiceProcessingPassEnd(this ComPtr<IXAudio2VoiceCallback> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void>)@this->LpVtbl[1])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void OnStreamEnd(this ComPtr<IXAudio2VoiceCallback> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void>)@this->LpVtbl[2])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OnBufferStart(this ComPtr<IXAudio2VoiceCallback> thisVtbl, void* pBufferContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)@this->LpVtbl[3])(@this, pBufferContext);
    }

    /// <summary>To be documented.</summary>
    public static void OnBufferStart<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, ref T0 pBufferContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pBufferContextPtr = &pBufferContext)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)@this->LpVtbl[3])(@this, pBufferContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OnBufferEnd(this ComPtr<IXAudio2VoiceCallback> thisVtbl, void* pBufferContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)@this->LpVtbl[4])(@this, pBufferContext);
    }

    /// <summary>To be documented.</summary>
    public static void OnBufferEnd<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, ref T0 pBufferContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pBufferContextPtr = &pBufferContext)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)@this->LpVtbl[4])(@this, pBufferContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OnLoopEnd(this ComPtr<IXAudio2VoiceCallback> thisVtbl, void* pBufferContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)@this->LpVtbl[5])(@this, pBufferContext);
    }

    /// <summary>To be documented.</summary>
    public static void OnLoopEnd<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, ref T0 pBufferContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pBufferContextPtr = &pBufferContext)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, void>)@this->LpVtbl[5])(@this, pBufferContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OnVoiceError(this ComPtr<IXAudio2VoiceCallback> thisVtbl, void* pBufferContext, int Error)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, int, void>)@this->LpVtbl[6])(@this, pBufferContext, Error);
    }

    /// <summary>To be documented.</summary>
    public static void OnVoiceError<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, ref T0 pBufferContext, int Error) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pBufferContextPtr = &pBufferContext)
        {
            ((delegate* unmanaged[Stdcall]<IXAudio2VoiceCallback*, void*, int, void>)@this->LpVtbl[6])(@this, pBufferContextPtr, Error);
        }
    }

    /// <summary>To be documented.</summary>
    public static void OnBufferStart<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, Span<T0> pBufferContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OnBufferStart(ref pBufferContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OnBufferEnd<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, Span<T0> pBufferContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OnBufferEnd(ref pBufferContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OnLoopEnd<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, Span<T0> pBufferContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OnLoopEnd(ref pBufferContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void OnVoiceError<T0>(this ComPtr<IXAudio2VoiceCallback> thisVtbl, Span<T0> pBufferContext, int Error) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->OnVoiceError(ref pBufferContext.GetPinnableReference(), Error);
    }

}
