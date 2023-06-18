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

public unsafe static class D2D1DrawingStateBlock1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDescription(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl, DrawingStateDescription* stateDescription)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)@this->LpVtbl[4])(@this, stateDescription);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescription(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* stateDescription)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)@this->LpVtbl[5])(@this, stateDescription);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTextRenderingParams(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void>)@this->LpVtbl[6])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1DrawingStateBlock1> thisVtbl, IDWriteRenderingParams** textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void>)@this->LpVtbl[7])(@this, textRenderingParams);
    }

}
