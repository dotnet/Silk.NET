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

public unsafe static class DCompositionTurbulenceEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOffset(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, Silk.NET.Maths.Vector2D<float>* offset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[4])(@this, offset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBaseFrequency(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, Silk.NET.Maths.Vector2D<float>* frequency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[5])(@this, frequency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSize(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, Silk.NET.Maths.Vector2D<float>* size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[6])(@this, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNumOctaves(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, uint numOctaves)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, int>)@this->LpVtbl[7])(@this, numOctaves);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSeed(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, uint seed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, int>)@this->LpVtbl[8])(@this, seed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNoise(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, Silk.NET.Direct2D.TurbulenceNoise noise)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Direct2D.TurbulenceNoise, int>)@this->LpVtbl[9])(@this, noise);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStitchable(this ComPtr<IDCompositionTurbulenceEffect> thisVtbl, Silk.NET.Core.Bool32 stitchable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, stitchable);
        return ret;
    }

}
