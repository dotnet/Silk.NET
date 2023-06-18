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

public unsafe static class MarshalVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMarshal> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMarshal> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalData(this ComPtr<IMarshal> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[7])(@this, pStm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisconnectObject(this ComPtr<IMarshal> thisVtbl, uint dwReserved)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal*, uint, int>)@this->LpVtbl[8])(@this, dwReserved);
        return ret;
    }

}
