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

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionInkTrailDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionInkTrailDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionInkTrailDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrail(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, IDCompositionDelegatedInkTrail** inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[3])(@this, inkTrail);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDelegatedInkTrailForSwapChain(this ComPtr<IDCompositionInkTrailDevice> thisVtbl, Silk.NET.Core.Native.IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[4])(@this, swapChain, inkTrail);
        return ret;
    }

}
