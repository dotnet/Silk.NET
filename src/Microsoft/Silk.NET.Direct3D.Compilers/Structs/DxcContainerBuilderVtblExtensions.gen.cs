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

public unsafe static class DxcContainerBuilderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcContainerBuilder> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDxcContainerBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcContainerBuilder> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IDxcContainerBuilder> thisVtbl, IDxcBlob* pDxilContainerHeader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pDxilContainerHeader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPart(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC, IDxcBlob* pSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)@this->LpVtbl[4])(@this, fourCC, pSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemovePart(this ComPtr<IDxcContainerBuilder> thisVtbl, uint fourCC)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, int>)@this->LpVtbl[5])(@this, fourCC);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SerializeContainer(this ComPtr<IDxcContainerBuilder> thisVtbl, IDxcOperationResult** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)@this->LpVtbl[6])(@this, ppResult);
        return ret;
    }

}
