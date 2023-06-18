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

namespace Silk.NET.Core.Native;

public unsafe static class D3DIncludeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<ID3DInclude> thisVtbl, D3DIncludeType IncludeType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pParentData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** ppData, uint* pBytes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Close(this ComPtr<ID3DInclude> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pData);
        return ret;
    }

}
