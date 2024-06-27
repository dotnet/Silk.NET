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

public unsafe static class D2D1SvgPointCollectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPointCollection> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPointCollection> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgPointCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgPointCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ID2D1SvgElement** element)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref ID2D1SvgElement* element)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** elementPtr = &element)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, elementPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ID2D1SvgAttribute** attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref ID2D1SvgAttribute* attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgAttribute** attributePtr = &attribute)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attributePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemovePointsAtEnd(this ComPtr<ID2D1SvgPointCollection> thisVtbl, uint pointsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint, int>)@this->LpVtbl[6])(@this, pointsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdatePoints(this ComPtr<ID2D1SvgPointCollection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Silk.NET.Maths.Vector2D<float>*, uint, uint, int>)@this->LpVtbl[7])(@this, points, pointsCount, startIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdatePoints(this ComPtr<ID2D1SvgPointCollection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<float> points, uint pointsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* pointsPtr = &points)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Silk.NET.Maths.Vector2D<float>*, uint, uint, int>)@this->LpVtbl[7])(@this, pointsPtr, pointsCount, startIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPoints(this ComPtr<ID2D1SvgPointCollection> thisVtbl, Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Silk.NET.Maths.Vector2D<float>*, uint, uint, int>)@this->LpVtbl[8])(@this, points, pointsCount, startIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPoints(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref Silk.NET.Maths.Vector2D<float> points, uint pointsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<float>* pointsPtr = &points)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, Silk.NET.Maths.Vector2D<float>*, uint, uint, int>)@this->LpVtbl[8])(@this, pointsPtr, pointsCount, startIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPointsCount(this ComPtr<ID2D1SvgPointCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPointCollection*, uint>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SvgPointCollection> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPointCollection> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPointCollection> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetElement<TI0>(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref ComPtr<TI0> element) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetElement((ID2D1SvgElement**) element.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<ID2D1SvgPointCollection> thisVtbl, ref ComPtr<TI0> attribute) where TI0 : unmanaged, IComVtbl<ID2D1SvgAttribute>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((ID2D1SvgAttribute**) attribute.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int UpdatePoints(this ComPtr<ID2D1SvgPointCollection> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<float>> points, uint pointsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdatePoints(in points.GetPinnableReference(), pointsCount, startIndex);
    }

    /// <summary>To be documented.</summary>
    public static int GetPoints(this ComPtr<ID2D1SvgPointCollection> thisVtbl, Span<Silk.NET.Maths.Vector2D<float>> points, uint pointsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPoints(ref points.GetPinnableReference(), pointsCount, startIndex);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SvgPointCollection> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
