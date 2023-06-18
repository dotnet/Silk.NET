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

public unsafe static class ClientSecurityVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IClientSecurity> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IClientSecurity> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IClientSecurity> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryBlanket(this ComPtr<IClientSecurity> thisVtbl, Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBlanket(this ComPtr<IClientSecurity> thisVtbl, Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyProxy(this ComPtr<IClientSecurity> thisVtbl, Silk.NET.Core.Native.IUnknown* pProxy, Silk.NET.Core.Native.IUnknown** ppCopy)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[5])(@this, pProxy, ppCopy);
        return ret;
    }

}
