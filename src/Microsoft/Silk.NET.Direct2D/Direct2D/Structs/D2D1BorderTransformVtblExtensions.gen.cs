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

public unsafe static class D2D1BorderTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BorderTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1BorderTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1BorderTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1BorderTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputBuffer(this ComPtr<ID2D1BorderTransform> thisVtbl, BufferPrecision bufferPrecision, ChannelDepth channelDepth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, BufferPrecision, ChannelDepth, int>)@this->LpVtbl[4])(@this, bufferPrecision, channelDepth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCached(this ComPtr<ID2D1BorderTransform> thisVtbl, Silk.NET.Core.Bool32 isCached)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, isCached);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeX(this ComPtr<ID2D1BorderTransform> thisVtbl, ExtendMode extendMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode, void>)@this->LpVtbl[6])(@this, extendMode);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeY(this ComPtr<ID2D1BorderTransform> thisVtbl, ExtendMode extendMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode, void>)@this->LpVtbl[7])(@this, extendMode);
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeX(this ComPtr<ID2D1BorderTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeY(this ComPtr<ID2D1BorderTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BorderTransform*, ExtendMode>)@this->LpVtbl[9])(@this);
        return ret;
    }

}
