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

public unsafe static class D2D1BlendTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BlendTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1BlendTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1BlendTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1BlendTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputBuffer(this ComPtr<ID2D1BlendTransform> thisVtbl, BufferPrecision bufferPrecision, ChannelDepth channelDepth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BufferPrecision, ChannelDepth, int>)@this->LpVtbl[4])(@this, bufferPrecision, channelDepth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCached(this ComPtr<ID2D1BlendTransform> thisVtbl, Silk.NET.Core.Bool32 isCached)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, isCached);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescription(this ComPtr<ID2D1BlendTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* description)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)@this->LpVtbl[6])(@this, description);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDescription(this ComPtr<ID2D1BlendTransform> thisVtbl, BlendDescription* description)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)@this->LpVtbl[7])(@this, description);
    }

}
