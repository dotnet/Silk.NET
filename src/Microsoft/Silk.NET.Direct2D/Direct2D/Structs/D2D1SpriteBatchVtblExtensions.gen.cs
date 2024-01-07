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
    public static unsafe int QueryInterface(this ComPtr<ID2D1SpriteBatch> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SpriteBatch> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SpriteBatch> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe void GetFactory(this ComPtr<ID2D1SpriteBatch> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
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
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectangles, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectangles, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectangles, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectanglesPtr, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectanglesPtr, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectanglesPtr, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectangles, sourceRectanglesPtr, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectangles, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectangles, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectangles, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[4])(@this, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                    }
                }
            }
        }
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
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colors, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colorsPtr, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, uint, uint, uint, uint, int>)@this->LpVtbl[5])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colorsPtr, transformsPtr, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
                    }
                }
            }
        }
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
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transformsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colorsPtr, transforms);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectangles, colorsPtr, transformsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colors, transforms);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colors, transformsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colorsPtr, transforms);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectangles, sourceRectanglesPtr, colorsPtr, transformsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colors, transforms);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colors, transformsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colorsPtr, transforms);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectangles, colorsPtr, transformsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colors, transforms);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colors, transformsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colorsPtr, transforms);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, ref Silk.NET.Maths.Box2D<float> destinationRectangles, ref Silk.NET.Maths.Box2D<uint> sourceRectangles, ref Silk.NET.DXGI.D3Dcolorvalue colors, ref Silk.NET.Maths.Matrix3X2<float> transforms)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglesPtr = &destinationRectangles)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* sourceRectanglesPtr = &sourceRectangles)
            {
                fixed (Silk.NET.DXGI.D3Dcolorvalue* colorsPtr = &colors)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* transformsPtr = &transforms)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SpriteBatch*, uint, uint, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<uint>*, Silk.NET.DXGI.D3Dcolorvalue*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, startIndex, spriteCount, destinationRectanglesPtr, sourceRectanglesPtr, colorsPtr, transformsPtr);
                    }
                }
            }
        }
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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SpriteBatch> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SpriteBatch> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SpriteBatch> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SpriteBatch> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, sourceRectangles, colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, sourceRectangles, in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, sourceRectangles, in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static int AddSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSprites(spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, sourceRectangles, in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, sourceRectangles, in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, destinationRectangles, in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), sourceRectangles, in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), colors, in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static int SetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> destinationRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> sourceRectangles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> colors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transforms, uint destinationRectanglesStride, uint sourceRectanglesStride, uint colorsStride, uint transformsStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSprites(startIndex, spriteCount, in destinationRectangles.GetPinnableReference(), in sourceRectangles.GetPinnableReference(), in colors.GetPinnableReference(), in transforms.GetPinnableReference(), destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, sourceRectangles, ref colors.GetPinnableReference(), transforms);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, sourceRectangles, ref colors.GetPinnableReference(), ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, ref sourceRectangles.GetPinnableReference(), colors, transforms);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, ref sourceRectangles.GetPinnableReference(), colors, ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, ref sourceRectangles.GetPinnableReference(), ref colors.GetPinnableReference(), transforms);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Silk.NET.Maths.Box2D<float>* destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, destinationRectangles, ref sourceRectangles.GetPinnableReference(), ref colors.GetPinnableReference(), ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), sourceRectangles, colors, transforms);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), sourceRectangles, colors, ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), sourceRectangles, ref colors.GetPinnableReference(), transforms);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Silk.NET.Maths.Box2D<uint>* sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), sourceRectangles, ref colors.GetPinnableReference(), ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), ref sourceRectangles.GetPinnableReference(), colors, transforms);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Silk.NET.DXGI.D3Dcolorvalue* colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), ref sourceRectangles.GetPinnableReference(), colors, ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Silk.NET.Maths.Matrix3X2<float>* transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), ref sourceRectangles.GetPinnableReference(), ref colors.GetPinnableReference(), transforms);
    }

    /// <summary>To be documented.</summary>
    public static int GetSprites(this ComPtr<ID2D1SpriteBatch> thisVtbl, uint startIndex, uint spriteCount, Span<Silk.NET.Maths.Box2D<float>> destinationRectangles, Span<Silk.NET.Maths.Box2D<uint>> sourceRectangles, Span<Silk.NET.DXGI.D3Dcolorvalue> colors, Span<Silk.NET.Maths.Matrix3X2<float>> transforms)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSprites(startIndex, spriteCount, ref destinationRectangles.GetPinnableReference(), ref sourceRectangles.GetPinnableReference(), ref colors.GetPinnableReference(), ref transforms.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SpriteBatch> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
