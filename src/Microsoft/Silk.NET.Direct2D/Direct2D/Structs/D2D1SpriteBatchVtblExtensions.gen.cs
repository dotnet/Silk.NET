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

public unsafe static class D2D1SpriteBatchVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SpriteBatch> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SpriteBatch> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SpriteBatch> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SpriteBatch> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetSpriteCount(this ComPtr<ID2D1SpriteBatch> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void Clear(this ComPtr<ID2D1SpriteBatch> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, void>)@this->LpVtbl[8])(@this);
    }

}
