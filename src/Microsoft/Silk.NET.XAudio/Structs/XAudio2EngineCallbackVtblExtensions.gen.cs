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

public unsafe static class XAudio2EngineCallbackVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static void OnProcessingPassStart(this ComPtr<IXAudio2EngineCallback> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2EngineCallback*, void>)@this->LpVtbl[0])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void OnProcessingPassEnd(this ComPtr<IXAudio2EngineCallback> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2EngineCallback*, void>)@this->LpVtbl[1])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void OnCriticalError(this ComPtr<IXAudio2EngineCallback> thisVtbl, int Error)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IXAudio2EngineCallback*, int, void>)@this->LpVtbl[2])(@this, Error);
    }

}
