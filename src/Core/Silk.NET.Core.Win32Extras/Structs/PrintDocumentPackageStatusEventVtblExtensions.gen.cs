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

public unsafe static class PrintDocumentPackageStatusEventVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoCount(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, uint* pctinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint*, int>)@this->LpVtbl[3])(@this, pctinfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, uint iTInfo, uint lcid, Silk.NET.Core.Native.IUnknown** ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint, uint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[4])(@this, iTInfo, lcid, ppTInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIDsOfNames(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, Guid* riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNames, cNames, lcid, rgDispId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Invoke(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PackageStatusUpdated(this ComPtr<IPrintDocumentPackageStatusEvent> thisVtbl, MIDLMIDLItfDocumenttarget000000020001* packageStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, MIDLMIDLItfDocumenttarget000000020001*, int>)@this->LpVtbl[7])(@this, packageStatus);
        return ret;
    }

}
