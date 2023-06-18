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

public unsafe static class D2D1ColorContext1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ColorContext1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ColorContext1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static ColorSpace GetColorSpace(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorSpace ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorSpace>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetProfileSize(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, byte* profile, uint profileSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, byte*, uint, int>)@this->LpVtbl[6])(@this, profile, profileSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ColorContextType GetColorContextType(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorContextType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, ColorContextType>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.DXGI.ColorSpaceType GetDXGIColorSpace(this ComPtr<ID2D1ColorContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.DXGI.ColorSpaceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, Silk.NET.DXGI.ColorSpaceType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSimpleColorProfile(this ComPtr<ID2D1ColorContext1> thisVtbl, SimpleColorProfile* simpleProfile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ColorContext1*, SimpleColorProfile*, int>)@this->LpVtbl[9])(@this, simpleProfile);
        return ret;
    }

}
