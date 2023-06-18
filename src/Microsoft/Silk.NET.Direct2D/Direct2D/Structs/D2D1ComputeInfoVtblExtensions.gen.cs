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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1ComputeInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ComputeInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ComputeInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInputDescription(this ComPtr<ID2D1ComputeInfo> thisVtbl, uint inputIndex, InputDescription inputDescription)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, InputDescription, int>)@this->LpVtbl[3])(@this, inputIndex, inputDescription);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputBuffer(this ComPtr<ID2D1ComputeInfo> thisVtbl, BufferPrecision bufferPrecision, ChannelDepth channelDepth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, BufferPrecision, ChannelDepth, int>)@this->LpVtbl[4])(@this, bufferPrecision, channelDepth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCached(this ComPtr<ID2D1ComputeInfo> thisVtbl, Silk.NET.Core.Bool32 isCached)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, isCached);
    }

    /// <summary>To be documented.</summary>
    public static void SetInstructionCountHint(this ComPtr<ID2D1ComputeInfo> thisVtbl, uint instructionCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, void>)@this->LpVtbl[6])(@this, instructionCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetComputeShaderConstantBuffer(this ComPtr<ID2D1ComputeInfo> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buffer, uint bufferCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, buffer, bufferCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetComputeShader(this ComPtr<ID2D1ComputeInfo> thisVtbl, Guid* shaderId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, int>)@this->LpVtbl[8])(@this, shaderId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResourceTexture(this ComPtr<ID2D1ComputeInfo> thisVtbl, uint textureIndex, ID2D1ResourceTexture* resourceTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, ID2D1ResourceTexture*, int>)@this->LpVtbl[9])(@this, textureIndex, resourceTexture);
        return ret;
    }

}
