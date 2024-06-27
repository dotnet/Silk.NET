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

public unsafe static class D2D1ComputeTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeTransform> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeTransform> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeTransform> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ComputeTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ComputeTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1ComputeTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRects, inputRectsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRectsPtr, inputRectsCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRectPtr, inputRects, inputRectsCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRectPtr, inputRectsPtr, inputRectsCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInvalidRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, Silk.NET.Maths.Box2D<int>* invalidOutputRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapInvalidRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, ref Silk.NET.Maths.Box2D<int> invalidOutputRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* invalidOutputRectPtr = &invalidOutputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetComputeInfo(this ComPtr<ID2D1ComputeTransform> thisVtbl, ID2D1ComputeInfo* computeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int>)@this->LpVtbl[7])(@this, computeInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetComputeInfo(this ComPtr<ID2D1ComputeTransform> thisVtbl, ref ID2D1ComputeInfo computeInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1ComputeInfo* computeInfoPtr = &computeInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int>)@this->LpVtbl[7])(@this, computeInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionY, dimensionZ);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, uint* dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionZPtr = &dimensionZ)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionY, dimensionZPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, ref uint dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionYPtr = &dimensionY)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionYPtr, dimensionZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, ref uint dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionYPtr = &dimensionY)
        {
            fixed (uint* dimensionZPtr = &dimensionZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionX, dimensionYPtr, dimensionZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionXPtr = &dimensionX)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionY, dimensionZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, uint* dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionXPtr = &dimensionX)
        {
            fixed (uint* dimensionZPtr = &dimensionZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionY, dimensionZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, ref uint dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionXPtr = &dimensionX)
        {
            fixed (uint* dimensionYPtr = &dimensionY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionYPtr, dimensionZ);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref uint dimensionX, ref uint dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* dimensionXPtr = &dimensionX)
        {
            fixed (uint* dimensionYPtr = &dimensionY)
            {
                fixed (uint* dimensionZPtr = &dimensionZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRect, dimensionXPtr, dimensionYPtr, dimensionZPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionY, dimensionZ);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, uint* dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionZPtr = &dimensionZ)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionY, dimensionZPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, ref uint dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionYPtr = &dimensionY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionYPtr, dimensionZ);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, uint* dimensionX, ref uint dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionYPtr = &dimensionY)
            {
                fixed (uint* dimensionZPtr = &dimensionZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionX, dimensionYPtr, dimensionZPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionY, dimensionZ);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, uint* dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                fixed (uint* dimensionZPtr = &dimensionZ)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionY, dimensionZPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, ref uint dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                fixed (uint* dimensionYPtr = &dimensionY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionYPtr, dimensionZ);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref uint dimensionX, ref uint dimensionY, ref uint dimensionZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (uint* dimensionXPtr = &dimensionX)
            {
                fixed (uint* dimensionYPtr = &dimensionY)
                {
                    fixed (uint* dimensionZPtr = &dimensionZ)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, Silk.NET.Maths.Box2D<int>*, uint*, uint*, uint*, int>)@this->LpVtbl[8])(@this, outputRectPtr, dimensionXPtr, dimensionYPtr, dimensionZPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1ComputeTransform> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeTransform> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ComputeTransform> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapOutputRectToInputRects(outputRect, ref inputRects.GetPinnableReference(), inputRectsCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapOutputRectToInputRects(in outputRect.GetPinnableReference(), inputRects, inputRectsCount);
    }

    /// <summary>To be documented.</summary>
    public static int MapOutputRectToInputRects(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapOutputRectToInputRects(in outputRect.GetPinnableReference(), ref inputRects.GetPinnableReference(), inputRectsCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, inputOpaqueSubRects, inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static int MapInputRectsToOutputRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapInvalidRect(this ComPtr<ID2D1ComputeTransform> thisVtbl, uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, Span<Silk.NET.Maths.Box2D<int>> invalidOutputRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInvalidRect(inputIndex, invalidInputRect, ref invalidOutputRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetComputeInfo<TI0>(this ComPtr<ID2D1ComputeTransform> thisVtbl, ComPtr<TI0> computeInfo) where TI0 : unmanaged, IComVtbl<ID2D1ComputeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetComputeInfo((ID2D1ComputeInfo*) computeInfo.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetComputeInfo(this ComPtr<ID2D1ComputeTransform> thisVtbl, Span<ID2D1ComputeInfo> computeInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetComputeInfo(ref computeInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, uint* dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, dimensionX, dimensionY, ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, Span<uint> dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, dimensionX, ref dimensionY.GetPinnableReference(), dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, uint* dimensionX, Span<uint> dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, dimensionX, ref dimensionY.GetPinnableReference(), ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Span<uint> dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, ref dimensionX.GetPinnableReference(), dimensionY, dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Span<uint> dimensionX, uint* dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, ref dimensionX.GetPinnableReference(), dimensionY, ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Span<uint> dimensionX, Span<uint> dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, ref dimensionX.GetPinnableReference(), ref dimensionY.GetPinnableReference(), dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Span<uint> dimensionX, Span<uint> dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(outputRect, ref dimensionX.GetPinnableReference(), ref dimensionY.GetPinnableReference(), ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), dimensionX, dimensionY, dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, uint* dimensionX, uint* dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), dimensionX, dimensionY, ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, uint* dimensionX, Span<uint> dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), dimensionX, ref dimensionY.GetPinnableReference(), dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, uint* dimensionX, Span<uint> dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), dimensionX, ref dimensionY.GetPinnableReference(), ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Span<uint> dimensionX, uint* dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), ref dimensionX.GetPinnableReference(), dimensionY, dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Span<uint> dimensionX, uint* dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), ref dimensionX.GetPinnableReference(), dimensionY, ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Span<uint> dimensionX, Span<uint> dimensionY, uint* dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), ref dimensionX.GetPinnableReference(), ref dimensionY.GetPinnableReference(), dimensionZ);
    }

    /// <summary>To be documented.</summary>
    public static int CalculateThreadgroups(this ComPtr<ID2D1ComputeTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Span<uint> dimensionX, Span<uint> dimensionY, Span<uint> dimensionZ)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CalculateThreadgroups(in outputRect.GetPinnableReference(), ref dimensionX.GetPinnableReference(), ref dimensionY.GetPinnableReference(), ref dimensionZ.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1ComputeTransform> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
