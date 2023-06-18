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

public unsafe static class PSFactoryBufferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPSFactoryBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPSFactoryBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProxy(this ComPtr<IPSFactoryBuffer> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)@this->LpVtbl[3])(@this, pUnkOuter, riid, ppProxy, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStub(this ComPtr<IPSFactoryBuffer> thisVtbl, Guid* riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)@this->LpVtbl[4])(@this, riid, pUnkServer, ppStub);
        return ret;
    }

}
