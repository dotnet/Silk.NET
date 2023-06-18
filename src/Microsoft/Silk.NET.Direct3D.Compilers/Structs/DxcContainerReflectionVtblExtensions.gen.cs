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

public unsafe static class DxcContainerReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerReflection> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcContainerReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcContainerReflection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IDxcContainerReflection> thisVtbl, IDxcBlob* pContainer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pContainer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartCount(this ComPtr<IDxcContainerReflection> thisVtbl, uint* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)@this->LpVtbl[4])(@this, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, uint* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[5])(@this, idx, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartContent(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, IDxcBlob** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)@this->LpVtbl[6])(@this, idx, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFirstPartKind(this ComPtr<IDxcContainerReflection> thisVtbl, uint kind, uint* pResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[7])(@this, kind, pResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPartReflection(this ComPtr<IDxcContainerReflection> thisVtbl, uint idx, Guid* iid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, idx, iid, ppvObject);
        return ret;
    }

}
