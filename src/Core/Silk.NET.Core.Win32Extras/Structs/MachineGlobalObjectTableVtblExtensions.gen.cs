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

public unsafe static class MachineGlobalObjectTableVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMachineGlobalObjectTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMachineGlobalObjectTable> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Silk.NET.Core.Native.IUnknown* @object, MachineGlobalObjectTableRegistrationToken** token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Silk.NET.Core.Native.IUnknown*, MachineGlobalObjectTableRegistrationToken**, int>)@this->LpVtbl[3])(@this, clsid, identifier, @object, token);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetObjectA(this ComPtr<IMachineGlobalObjectTable> thisVtbl, Guid* clsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* identifier, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, Guid*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, clsid, identifier, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RevokeObject(this ComPtr<IMachineGlobalObjectTable> thisVtbl, MachineGlobalObjectTableRegistrationToken* token)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMachineGlobalObjectTable*, MachineGlobalObjectTableRegistrationToken*, int>)@this->LpVtbl[5])(@this, token);
        return ret;
    }

}
