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

public unsafe static class RpcOptionsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IRpcOptions> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IRpcOptions> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IRpcOptions> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Set(this ComPtr<IRpcOptions> thisVtbl, Silk.NET.Core.Native.IUnknown* pPrx, TagRPCOPTPROPERTIES dwProperty, nuint dwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint, int>)@this->LpVtbl[3])(@this, pPrx, dwProperty, dwValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Query(this ComPtr<IRpcOptions> thisVtbl, Silk.NET.Core.Native.IUnknown* pPrx, TagRPCOPTPROPERTIES dwProperty, nuint* pdwValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IRpcOptions*, Silk.NET.Core.Native.IUnknown*, TagRPCOPTPROPERTIES, nuint*, int>)@this->LpVtbl[4])(@this, pPrx, dwProperty, pdwValue);
        return ret;
    }

}
