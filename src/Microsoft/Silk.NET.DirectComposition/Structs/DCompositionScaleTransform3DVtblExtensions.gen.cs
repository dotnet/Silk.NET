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

public unsafe static class DCompositionScaleTransform3DVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionScaleTransform3D> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionScaleTransform3D> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetScaleX(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, float scaleX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[4])(@this, scaleX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetScaleY(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, float scaleY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[6])(@this, scaleY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetScaleZ(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, float scaleZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[8])(@this, scaleZ);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCenterX(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, float centerX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[10])(@this, centerX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCenterY(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, float centerY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[12])(@this, centerY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCenterZ(this ComPtr<IDCompositionScaleTransform3D> thisVtbl, float centerZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)@this->LpVtbl[14])(@this, centerZ);
        return ret;
    }

}
