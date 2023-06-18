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

public unsafe static class GlobalInterfaceTableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IGlobalInterfaceTable> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IGlobalInterfaceTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IGlobalInterfaceTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterInterfaceInGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riid, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RevokeInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, int>)@this->LpVtbl[4])(@this, dwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInterfaceFromGlobal(this ComPtr<IGlobalInterfaceTable> thisVtbl, uint dwCookie, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riid, ppv);
        return ret;
    }

}
