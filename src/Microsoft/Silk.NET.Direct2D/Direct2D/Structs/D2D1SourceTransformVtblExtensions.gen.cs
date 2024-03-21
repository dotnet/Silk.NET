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

public unsafe static class D2D1SourceTransformVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SourceTransform> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SourceTransform> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SourceTransform> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SourceTransform> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1SourceTransform> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRects, inputRectsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRect, inputRectsPtr, inputRectsCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRectPtr, inputRects, inputRectsCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[4])(@this, outputRectPtr, inputRectsPtr, inputRectsCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRects, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRects, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputOpaqueSubRectPtr = &outputOpaqueSubRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRect, outputOpaqueSubRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* inputRectsPtr = &inputRects)
        {
            fixed (Silk.NET.Maths.Box2D<int>* inputOpaqueSubRectsPtr = &inputOpaqueSubRects)
            {
                fixed (Silk.NET.Maths.Box2D<int>* outputRectPtr = &outputRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRect);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> inputOpaqueSubRects, uint inputRectCount, ref Silk.NET.Maths.Box2D<int> outputRect, ref Silk.NET.Maths.Box2D<int> outputOpaqueSubRect)
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
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, inputRectsPtr, inputOpaqueSubRectsPtr, inputRectCount, outputRectPtr, outputOpaqueSubRectPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInvalidRect(this ComPtr<ID2D1SourceTransform> thisVtbl, uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, Silk.NET.Maths.Box2D<int>* invalidOutputRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MapInvalidRect(this ComPtr<ID2D1SourceTransform> thisVtbl, uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, ref Silk.NET.Maths.Box2D<int> invalidOutputRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* invalidOutputRectPtr = &invalidOutputRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint, Silk.NET.Maths.Box2D<int>, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[6])(@this, inputIndex, invalidInputRect, invalidOutputRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetRenderInfo(this ComPtr<ID2D1SourceTransform> thisVtbl, ID2D1RenderInfo* renderInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)@this->LpVtbl[7])(@this, renderInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderInfo(this ComPtr<ID2D1SourceTransform> thisVtbl, ref ID2D1RenderInfo renderInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderInfo* renderInfoPtr = &renderInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)@this->LpVtbl[7])(@this, renderInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, ID2D1Bitmap1* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Vector2D<uint>, int>)@this->LpVtbl[8])(@this, target, drawRect, targetOrigin);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, ID2D1Bitmap1* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* drawRectPtr = &drawRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Vector2D<uint>, int>)@this->LpVtbl[8])(@this, target, drawRectPtr, targetOrigin);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, ref ID2D1Bitmap1 target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap1* targetPtr = &target)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Vector2D<uint>, int>)@this->LpVtbl[8])(@this, targetPtr, drawRect, targetOrigin);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, ref ID2D1Bitmap1 target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap1* targetPtr = &target)
        {
            fixed (Silk.NET.Maths.Box2D<int>* drawRectPtr = &drawRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Vector2D<uint>, int>)@this->LpVtbl[8])(@this, targetPtr, drawRectPtr, targetOrigin);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SourceTransform> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SourceTransform> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SourceTransform> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapOutputRectToInputRects(outputRect, ref inputRects.GetPinnableReference(), inputRectsCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapOutputRectToInputRects(in outputRect.GetPinnableReference(), inputRects, inputRectsCount);
    }

    /// <summary>To be documented.</summary>
    public static int MapOutputRectToInputRects(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> inputRects, uint inputRectsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapOutputRectToInputRects(in outputRect.GetPinnableReference(), ref inputRects.GetPinnableReference(), inputRectsCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, inputOpaqueSubRects, inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(inputRects, in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), inputOpaqueSubRects, inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Silk.NET.Maths.Box2D<int>* outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, outputRect, ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Silk.NET.Maths.Box2D<int>* outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), outputOpaqueSubRect);
    }

    /// <summary>To be documented.</summary>
    public static int MapInputRectsToOutputRect(this ComPtr<ID2D1SourceTransform> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> inputOpaqueSubRects, uint inputRectCount, Span<Silk.NET.Maths.Box2D<int>> outputRect, Span<Silk.NET.Maths.Box2D<int>> outputOpaqueSubRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInputRectsToOutputRect(in inputRects.GetPinnableReference(), in inputOpaqueSubRects.GetPinnableReference(), inputRectCount, ref outputRect.GetPinnableReference(), ref outputOpaqueSubRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapInvalidRect(this ComPtr<ID2D1SourceTransform> thisVtbl, uint inputIndex, Silk.NET.Maths.Box2D<int> invalidInputRect, Span<Silk.NET.Maths.Box2D<int>> invalidOutputRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapInvalidRect(inputIndex, invalidInputRect, ref invalidOutputRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderInfo<TI0>(this ComPtr<ID2D1SourceTransform> thisVtbl, ComPtr<TI0> renderInfo) where TI0 : unmanaged, IComVtbl<ID2D1RenderInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetRenderInfo((ID2D1RenderInfo*) renderInfo.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderInfo(this ComPtr<ID2D1SourceTransform> thisVtbl, Span<ID2D1RenderInfo> renderInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetRenderInfo(ref renderInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<TI0>(this ComPtr<ID2D1SourceTransform> thisVtbl, ComPtr<TI0> target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw((ID2D1Bitmap1*) target.Handle, drawRect, targetOrigin);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, ID2D1Bitmap1* target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(target, in drawRect.GetPinnableReference(), targetOrigin);
    }

    /// <summary>To be documented.</summary>
    public static int Draw<TI0>(this ComPtr<ID2D1SourceTransform> thisVtbl, ComPtr<TI0> target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw((ID2D1Bitmap1*) target.Handle, in drawRect, targetOrigin);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, Span<ID2D1Bitmap1> target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref target.GetPinnableReference(), drawRect, targetOrigin);
    }

    /// <summary>To be documented.</summary>
    public static int Draw(this ComPtr<ID2D1SourceTransform> thisVtbl, Span<ID2D1Bitmap1> target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> drawRect, Silk.NET.Maths.Vector2D<uint> targetOrigin)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref target.GetPinnableReference(), in drawRect.GetPinnableReference(), targetOrigin);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SourceTransform> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
