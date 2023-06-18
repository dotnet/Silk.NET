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

public unsafe static class AsyncIPipeLongVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<AsyncIPipeLong> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<AsyncIPipeLong> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<AsyncIPipeLong> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginPull(this ComPtr<AsyncIPipeLong> thisVtbl, uint cRequest)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, uint, int>)@this->LpVtbl[3])(@this, cRequest);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishPull(this ComPtr<AsyncIPipeLong> thisVtbl, int* buf, uint* pcReturned)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, int*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturned);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginPush(this ComPtr<AsyncIPipeLong> thisVtbl, int* buf, uint cSent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, int*, uint, int>)@this->LpVtbl[5])(@this, buf, cSent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FinishPush(this ComPtr<AsyncIPipeLong> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

}
