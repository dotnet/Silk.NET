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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1PrintControlVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1PrintControl> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1PrintControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1PrintControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddPage(this ComPtr<ID2D1PrintControl> thisVtbl, ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Win32Extras.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Win32Extras.IStream*, ulong*, ulong*, int>)@this->LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID2D1PrintControl> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

}
