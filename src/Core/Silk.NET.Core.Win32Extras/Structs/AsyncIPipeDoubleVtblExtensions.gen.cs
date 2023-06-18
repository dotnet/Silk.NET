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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class AsyncIPipeDoubleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeDouble> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<AsyncIPipeDouble> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<AsyncIPipeDouble> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginPull(this ComPtr<AsyncIPipeDouble> thisVtbl, uint cRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, uint, int>)@this->LpVtbl[3])(@this, cRequest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeDouble> thisVtbl, double* buf, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, double*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturned);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginPush(this ComPtr<AsyncIPipeDouble> thisVtbl, double* buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, double*, uint, int>)@this->LpVtbl[5])(@this, buf, cSent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishPush(this ComPtr<AsyncIPipeDouble> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

}
