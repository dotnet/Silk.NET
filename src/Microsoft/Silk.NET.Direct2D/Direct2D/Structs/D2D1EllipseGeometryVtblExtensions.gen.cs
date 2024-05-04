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

public unsafe static class D2D1EllipseGeometryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1EllipseGeometry> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1EllipseGeometry> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransform, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransform, boundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransformPtr, bounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[4])(@this, worldTransformPtr, boundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, boundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, bounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, boundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, bounds);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, boundsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, bounds);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, boundsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, contains);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* containsPtr = &contains)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, containsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, contains);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, containsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, contains);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, containsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, contains);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (int* containsPtr = &contains)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[6])(@this, point, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, containsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, contains);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* containsPtr = &contains)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransform, flatteningTolerance, containsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransformPtr, flatteningTolerance, contains);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (int* containsPtr = &contains)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Matrix3X2<float>*, float, int*, int>)@this->LpVtbl[7])(@this, point, worldTransformPtr, flatteningTolerance, containsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GeometryRelation* relationPtr = &relation)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransform, flatteningTolerance, relationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransformPtr, flatteningTolerance, relation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
        {
            fixed (GeometryRelation* relationPtr = &relation)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometry, inputGeometryTransformPtr, flatteningTolerance, relationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransform, flatteningTolerance, relation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            fixed (GeometryRelation* relationPtr = &relation)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransform, flatteningTolerance, relationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransformPtr, flatteningTolerance, relation);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                fixed (GeometryRelation* relationPtr = &relation)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, Silk.NET.Maths.Matrix3X2<float>*, float, GeometryRelation*, int>)@this->LpVtbl[8])(@this, inputGeometryPtr, inputGeometryTransformPtr, flatteningTolerance, relationPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransform, flatteningTolerance, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransformPtr, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, GeometrySimplificationOption, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[9])(@this, simplificationOption, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1TessellationSink tessellationSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1TessellationSink* tessellationSinkPtr = &tessellationSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransform, flatteningTolerance, tessellationSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransformPtr, flatteningTolerance, tessellationSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1TessellationSink tessellationSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (ID2D1TessellationSink* tessellationSinkPtr = &tessellationSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1TessellationSink*, int>)@this->LpVtbl[10])(@this, worldTransformPtr, flatteningTolerance, tessellationSinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometry, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransform, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Geometry* inputGeometryPtr = &inputGeometry)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransformPtr = &inputGeometryTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, ID2D1Geometry*, CombineMode, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[11])(@this, inputGeometryPtr, combineMode, inputGeometryTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransform, flatteningTolerance, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransformPtr, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[12])(@this, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* area)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransform, flatteningTolerance, area);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref float area)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* areaPtr = &area)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransform, flatteningTolerance, areaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, float* area)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransformPtr, flatteningTolerance, area);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref float area)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (float* areaPtr = &area)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[13])(@this, worldTransformPtr, flatteningTolerance, areaPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, float* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransform, flatteningTolerance, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref float length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* lengthPtr = &length)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransform, flatteningTolerance, lengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, float* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransformPtr, flatteningTolerance, length);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref float length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (float* lengthPtr = &length)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Silk.NET.Maths.Matrix3X2<float>*, float, float*, int>)@this->LpVtbl[14])(@this, worldTransformPtr, flatteningTolerance, lengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVector);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, point, unitTangentVectorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, pointPtr, unitTangentVector);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransform, flatteningTolerance, pointPtr, unitTangentVectorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, point, unitTangentVector);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, point, unitTangentVectorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, pointPtr, unitTangentVector);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Vector2D<float> point, ref Silk.NET.Maths.Vector2D<float> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (Silk.NET.Maths.Vector2D<float>* pointPtr = &point)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* unitTangentVectorPtr = &unitTangentVector)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, Silk.NET.Maths.Matrix3X2<float>*, float, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[15])(@this, length, worldTransformPtr, flatteningTolerance, pointPtr, unitTangentVectorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStyle, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransform, flatteningTolerance, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
        {
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, float, ID2D1StrokeStyle*, Silk.NET.Maths.Matrix3X2<float>*, float, ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[16])(@this, strokeWidth, strokeStylePtr, worldTransformPtr, flatteningTolerance, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetEllipse(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Ellipse* ellipse)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Ellipse*, void>)@this->LpVtbl[17])(@this, ellipse);
    }

    /// <summary>To be documented.</summary>
    public static void GetEllipse(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref Ellipse ellipse)
    {
        var @this = thisVtbl.Handle;
        fixed (Ellipse* ellipsePtr = &ellipse)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1EllipseGeometry*, Ellipse*, void>)@this->LpVtbl[17])(@this, ellipsePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(worldTransform, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(in worldTransform.GetPinnableReference(), bounds);
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(in worldTransform.GetPinnableReference(), ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, strokeStyle, worldTransform, flatteningTolerance, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, ref bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, strokeStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, strokeStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetWidenedBounds<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref Silk.NET.Maths.Box2D<float> bounds) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetWidenedBounds(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, ref bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, ref strokeStyle.GetPinnableReference(), worldTransform, flatteningTolerance, bounds);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, ref strokeStyle.GetPinnableReference(), worldTransform, flatteningTolerance, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, ref strokeStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, bounds);
    }

    /// <summary>To be documented.</summary>
    public static int GetWidenedBounds(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWidenedBounds(strokeWidth, ref strokeStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, contains);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<int> contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, strokeStyle, worldTransform, flatteningTolerance, ref contains.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref int contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, ref contains);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, strokeStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, contains);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, int* contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, contains);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<int> contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, strokeStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, ref contains.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int StrokeContainsPoint<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref int contains) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, ref contains);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, ref strokeStyle.GetPinnableReference(), worldTransform, flatteningTolerance, contains);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<int> contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, ref strokeStyle.GetPinnableReference(), worldTransform, flatteningTolerance, ref contains.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, ref strokeStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, contains);
    }

    /// <summary>To be documented.</summary>
    public static int StrokeContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<int> contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StrokeContainsPoint(point, strokeWidth, ref strokeStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, ref contains.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<int> contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillContainsPoint(point, worldTransform, flatteningTolerance, ref contains.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, int* contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillContainsPoint(point, in worldTransform.GetPinnableReference(), flatteningTolerance, contains);
    }

    /// <summary>To be documented.</summary>
    public static int FillContainsPoint(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Silk.NET.Maths.Vector2D<float> point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<int> contains)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillContainsPoint(point, in worldTransform.GetPinnableReference(), flatteningTolerance, ref contains.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, inputGeometryTransform, flatteningTolerance, relation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, Span<GeometryRelation> relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(inputGeometry, inputGeometryTransform, flatteningTolerance, ref relation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, inputGeometryTransform, flatteningTolerance, ref relation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(inputGeometry, in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, relation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, in inputGeometryTransform, flatteningTolerance, relation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, Span<GeometryRelation> relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(inputGeometry, in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, ref relation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CompareWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref GeometryRelation relation) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CompareWithGeometry((ID2D1Geometry*) inputGeometry.Handle, in inputGeometryTransform, flatteningTolerance, ref relation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(ref inputGeometry.GetPinnableReference(), inputGeometryTransform, flatteningTolerance, relation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, Span<GeometryRelation> relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(ref inputGeometry.GetPinnableReference(), inputGeometryTransform, flatteningTolerance, ref relation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, GeometryRelation* relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(ref inputGeometry.GetPinnableReference(), in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, relation);
    }

    /// <summary>To be documented.</summary>
    public static int CompareWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, Span<GeometryRelation> relation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CompareWithGeometry(ref inputGeometry.GetPinnableReference(), in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, ref relation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Simplify(simplificationOption, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Simplify(simplificationOption, worldTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Simplify(simplificationOption, in worldTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int Simplify<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Simplify(simplificationOption, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Simplify(this ComPtr<ID2D1EllipseGeometry> thisVtbl, GeometrySimplificationOption simplificationOption, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Simplify(simplificationOption, in worldTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> tessellationSink) where TI0 : unmanaged, IComVtbl<ID2D1TessellationSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Tessellate(worldTransform, flatteningTolerance, (ID2D1TessellationSink*) tessellationSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1TessellationSink> tessellationSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Tessellate(worldTransform, flatteningTolerance, ref tessellationSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Tessellate(in worldTransform.GetPinnableReference(), flatteningTolerance, tessellationSink);
    }

    /// <summary>To be documented.</summary>
    public static int Tessellate<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> tessellationSink) where TI0 : unmanaged, IComVtbl<ID2D1TessellationSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Tessellate(in worldTransform, flatteningTolerance, (ID2D1TessellationSink*) tessellationSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Tessellate(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1TessellationSink> tessellationSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Tessellate(in worldTransform.GetPinnableReference(), flatteningTolerance, ref tessellationSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry<TI0, TI1>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, inputGeometryTransform, flatteningTolerance, ref geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(inputGeometry, combineMode, in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int CombineWithGeometry<TI0, TI1>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, in inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ID2D1Geometry* inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(inputGeometry, combineMode, in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CombineWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ComPtr<TI0> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1Geometry>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CombineWithGeometry((ID2D1Geometry*) inputGeometry.Handle, combineMode, in inputGeometryTransform, flatteningTolerance, ref geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(ref inputGeometry.GetPinnableReference(), combineMode, inputGeometryTransform, flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CombineWithGeometry(ref inputGeometry, combineMode, inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* inputGeometryTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(ref inputGeometry.GetPinnableReference(), combineMode, inputGeometryTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(ref inputGeometry.GetPinnableReference(), combineMode, in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int CombineWithGeometry<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, ref ID2D1Geometry inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> inputGeometryTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CombineWithGeometry(ref inputGeometry, combineMode, in inputGeometryTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int CombineWithGeometry(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<ID2D1Geometry> inputGeometry, CombineMode combineMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> inputGeometryTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CombineWithGeometry(ref inputGeometry.GetPinnableReference(), combineMode, in inputGeometryTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Outline(worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Outline(worldTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Outline(in worldTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int Outline<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Outline(in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Outline(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Outline(in worldTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<float> area)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputeArea(worldTransform, flatteningTolerance, ref area.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, float* area)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputeArea(in worldTransform.GetPinnableReference(), flatteningTolerance, area);
    }

    /// <summary>To be documented.</summary>
    public static int ComputeArea(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<float> area)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputeArea(in worldTransform.GetPinnableReference(), flatteningTolerance, ref area.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<float> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputeLength(worldTransform, flatteningTolerance, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, float* length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputeLength(in worldTransform.GetPinnableReference(), flatteningTolerance, length);
    }

    /// <summary>To be documented.</summary>
    public static int ComputeLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<float> length)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputeLength(in worldTransform.GetPinnableReference(), flatteningTolerance, ref length.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Span<Silk.NET.Maths.Vector2D<float>> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, worldTransform, flatteningTolerance, point, ref unitTangentVector.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Vector2D<float>> point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, worldTransform, flatteningTolerance, ref point.GetPinnableReference(), unitTangentVector);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Vector2D<float>> point, Span<Silk.NET.Maths.Vector2D<float>> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, worldTransform, flatteningTolerance, ref point.GetPinnableReference(), ref unitTangentVector.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, in worldTransform.GetPinnableReference(), flatteningTolerance, point, unitTangentVector);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Silk.NET.Maths.Vector2D<float>* point, Span<Silk.NET.Maths.Vector2D<float>> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, in worldTransform.GetPinnableReference(), flatteningTolerance, point, ref unitTangentVector.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Vector2D<float>> point, Silk.NET.Maths.Vector2D<float>* unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, in worldTransform.GetPinnableReference(), flatteningTolerance, ref point.GetPinnableReference(), unitTangentVector);
    }

    /// <summary>To be documented.</summary>
    public static int ComputePointAtLength(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<Silk.NET.Maths.Vector2D<float>> point, Span<Silk.NET.Maths.Vector2D<float>> unitTangentVector)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComputePointAtLength(length, in worldTransform.GetPinnableReference(), flatteningTolerance, ref point.GetPinnableReference(), ref unitTangentVector.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen<TI0, TI1>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, strokeStyle, worldTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, worldTransform, flatteningTolerance, ref geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, strokeStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int Widen<TI0, TI1>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI1> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, strokeStyle, in worldTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Widen<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ComPtr<TI0> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ref ID2D1SimplifiedGeometrySink geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1StrokeStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Widen(strokeWidth, (ID2D1StrokeStyle*) strokeStyle.Handle, in worldTransform, flatteningTolerance, ref geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, ref strokeStyle.GetPinnableReference(), worldTransform, flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Widen(strokeWidth, ref strokeStyle, worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, ref strokeStyle.GetPinnableReference(), worldTransform, flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, ref strokeStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int Widen<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> worldTransform, float flatteningTolerance, ComPtr<TI0> geometrySink) where TI0 : unmanaged, IComVtbl<ID2D1SimplifiedGeometrySink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Widen(strokeWidth, ref strokeStyle, in worldTransform, flatteningTolerance, (ID2D1SimplifiedGeometrySink*) geometrySink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Widen(this ComPtr<ID2D1EllipseGeometry> thisVtbl, float strokeWidth, Span<ID2D1StrokeStyle> strokeStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> worldTransform, float flatteningTolerance, Span<ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Widen(strokeWidth, ref strokeStyle.GetPinnableReference(), in worldTransform.GetPinnableReference(), flatteningTolerance, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetEllipse(this ComPtr<ID2D1EllipseGeometry> thisVtbl, Span<Ellipse> ellipse)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetEllipse(ref ellipse.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1EllipseGeometry> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
