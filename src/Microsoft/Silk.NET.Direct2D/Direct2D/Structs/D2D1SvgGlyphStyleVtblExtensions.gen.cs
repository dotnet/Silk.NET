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

public unsafe static class D2D1SvgGlyphStyleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)@this->LpVtbl[4])(@this, brush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)@this->LpVtbl[4])(@this, brushPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)@this->LpVtbl[5])(@this, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)@this->LpVtbl[5])(@this, brushPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dashesPtr = &dashes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brush, strokeWidth, dashesPtr, dashesCount, dashOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brushPtr, strokeWidth, dashes, dashesCount, dashOffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Brush* brushPtr = &brush)
        {
            fixed (float* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brushPtr, strokeWidth, dashesPtr, dashesCount, dashOffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetStrokeDashesCount(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dashOffsetPtr = &dashOffset)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashes, dashesCount, dashOffsetPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dashesPtr = &dashes)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashesPtr, dashesCount, dashOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dashesPtr = &dashes)
        {
            fixed (float* dashOffsetPtr = &dashOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashesPtr, dashesCount, dashOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, ref float strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* strokeWidthPtr = &strokeWidth)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashes, dashesCount, dashOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, ref float strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* strokeWidthPtr = &strokeWidth)
        {
            fixed (float* dashOffsetPtr = &dashOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashes, dashesCount, dashOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, ref float strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* strokeWidthPtr = &strokeWidth)
        {
            fixed (float* dashesPtr = &dashes)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashesPtr, dashesCount, dashOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, ref float strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (float* strokeWidthPtr = &strokeWidth)
        {
            fixed (float* dashesPtr = &dashes)
            {
                fixed (float* dashOffsetPtr = &dashOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidthPtr, dashesPtr, dashesCount, dashOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashes, dashesCount, dashOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* dashOffsetPtr = &dashOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashes, dashesCount, dashOffsetPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* dashesPtr = &dashes)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashesPtr, dashesCount, dashOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* dashesPtr = &dashes)
            {
                fixed (float* dashOffsetPtr = &dashOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidth, dashesPtr, dashesCount, dashOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, ref float strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashes, dashesCount, dashOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, ref float strokeWidth, float* dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                fixed (float* dashOffsetPtr = &dashOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashes, dashesCount, dashOffsetPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, ref float strokeWidth, ref float dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashesPtr, dashesCount, dashOffset);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, ref float strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Brush** brushPtr = &brush)
        {
            fixed (float* strokeWidthPtr = &strokeWidth)
            {
                fixed (float* dashesPtr = &dashes)
                {
                    fixed (float* dashOffsetPtr = &dashOffset)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brushPtr, strokeWidthPtr, dashesPtr, dashesCount, dashOffsetPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetFill<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetFill((ID2D1Brush*) brush.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Span<ID2D1Brush> brush)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFill(ref brush.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetFill<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFill((ID2D1Brush**) brush.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ComPtr<TI0> brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetStroke((ID2D1Brush*) brush.Handle, strokeWidth, dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetStroke(brush, strokeWidth, in dashes.GetPinnableReference(), dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static int SetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ComPtr<TI0> brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float dashes, uint dashesCount, float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetStroke((ID2D1Brush*) brush.Handle, strokeWidth, in dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Span<ID2D1Brush> brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetStroke(ref brush.GetPinnableReference(), strokeWidth, dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Span<ID2D1Brush> brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetStroke(ref brush.GetPinnableReference(), strokeWidth, in dashes.GetPinnableReference(), dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, strokeWidth, dashes, dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, float* strokeWidth, float* dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, dashes, dashesCount, ref dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, Span<float> dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, strokeWidth, ref dashes.GetPinnableReference(), dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, float* strokeWidth, ref float dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, ref dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, Span<float> dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, strokeWidth, ref dashes.GetPinnableReference(), dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, float* strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), strokeWidth, ref dashes, dashesCount, ref dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, Span<float> strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, ref strokeWidth.GetPinnableReference(), dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, ref float strokeWidth, float* dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, Span<float> strokeWidth, float* dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, ref strokeWidth.GetPinnableReference(), dashes, dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, ref float strokeWidth, float* dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, dashes, dashesCount, ref dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, Span<float> strokeWidth, Span<float> dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, ref strokeWidth.GetPinnableReference(), ref dashes.GetPinnableReference(), dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, ref float strokeWidth, ref float dashes, uint dashesCount, float* dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, ref dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, Span<float> strokeWidth, Span<float> dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(brush, ref strokeWidth.GetPinnableReference(), ref dashes.GetPinnableReference(), dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetStroke<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ComPtr<TI0> brush, ref float strokeWidth, ref float dashes, uint dashesCount, ref float dashOffset) where TI0 : unmanaged, IComVtbl<ID2D1Brush>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetStroke((ID2D1Brush**) brush.GetAddressOf(), ref strokeWidth, ref dashes, dashesCount, ref dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, float* dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, strokeWidth, dashes, dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, Span<float> dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, strokeWidth, ref dashes.GetPinnableReference(), dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, float* strokeWidth, Span<float> dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, strokeWidth, ref dashes.GetPinnableReference(), dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, Span<float> strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, ref strokeWidth.GetPinnableReference(), dashes, dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, Span<float> strokeWidth, float* dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, ref strokeWidth.GetPinnableReference(), dashes, dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, Span<float> strokeWidth, Span<float> dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, ref strokeWidth.GetPinnableReference(), ref dashes.GetPinnableReference(), dashesCount, dashOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ref ID2D1Brush* brush, Span<float> strokeWidth, Span<float> dashes, uint dashesCount, Span<float> dashOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetStroke(ref brush, ref strokeWidth.GetPinnableReference(), ref dashes.GetPinnableReference(), dashesCount, ref dashOffset.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
