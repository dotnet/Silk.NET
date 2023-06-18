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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcResultVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcResult> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStatus(this ComPtr<IDxcResult> thisVtbl, int* pStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, int*, int>)@this->LpVtbl[3])(@this, pStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResult(this ComPtr<IDxcResult> thisVtbl, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetErrorBuffer(this ComPtr<IDxcResult> thisVtbl, IDxcBlobEncoding** ppErrors)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrors);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasOutput(this ComPtr<IDxcResult> thisVtbl, OutKind dxcOutKind)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Silk.NET.Core.Bool32>)@this->LpVtbl[6])(@this, dxcOutKind);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput(this ComPtr<IDxcResult> thisVtbl, OutKind dxcOutKind, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobUtf16**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObject, ppOutputName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumOutputs(this ComPtr<IDxcResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OutKind GetOutputByIndex(this ComPtr<IDxcResult> thisVtbl, uint Index)
    {
        var @this = thisVtbl.Handle;
        OutKind ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, uint, OutKind>)@this->LpVtbl[9])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OutKind PrimaryOutput(this ComPtr<IDxcResult> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        OutKind ret = default;
        ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, OutKind>)@this->LpVtbl[10])(@this);
        return ret;
    }

}
