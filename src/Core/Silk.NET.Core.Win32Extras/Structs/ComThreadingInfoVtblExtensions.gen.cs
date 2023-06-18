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

public unsafe static class ComThreadingInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IComThreadingInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IComThreadingInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IComThreadingInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentApartmentType(this ComPtr<IComThreadingInfo> thisVtbl, Apttype* pAptType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Apttype*, int>)@this->LpVtbl[3])(@this, pAptType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentThreadType(this ComPtr<IComThreadingInfo> thisVtbl, Thdtype* pThreadType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Thdtype*, int>)@this->LpVtbl[4])(@this, pThreadType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, Guid* pguidLogicalThreadId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[5])(@this, pguidLogicalThreadId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCurrentLogicalThreadId(this ComPtr<IComThreadingInfo> thisVtbl, Guid* rguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IComThreadingInfo*, Guid*, int>)@this->LpVtbl[6])(@this, rguid);
        return ret;
    }

}
