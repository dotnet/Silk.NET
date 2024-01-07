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

public unsafe static class D2D1SvgPaintVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPaint> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPaint> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPaint> thisVtbl, ID2D1SvgElement** element)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPaint> thisVtbl, ref ID2D1SvgElement* element)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** elementPtr = &element)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, elementPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<ID2D1SvgPaint> thisVtbl, ID2D1SvgAttribute** attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<ID2D1SvgPaint> thisVtbl, ref ID2D1SvgAttribute* attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgAttribute** attributePtr = &attribute)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attributePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPaintType(this ComPtr<ID2D1SvgPaint> thisVtbl, SvgPaintType paintType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType, int>)@this->LpVtbl[6])(@this, paintType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static SvgPaintType GetPaintType(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        SvgPaintType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[8])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.D3Dcolorvalue color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[8])(@this, colorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[9])(@this, color);
    }

    /// <summary>To be documented.</summary>
    public static void GetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, ref Silk.NET.DXGI.D3Dcolorvalue color)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[9])(@this, colorPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetId(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)@this->LpVtbl[10])(@this, id);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetId(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char id)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* idPtr = &id)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)@this->LpVtbl[10])(@this, idPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetId(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, byte*, int>)@this->LpVtbl[10])(@this, idPtr);
        SilkMarshal.Free((nint)idPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetId(this ComPtr<ID2D1SvgPaint> thisVtbl, char* id, uint idCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)@this->LpVtbl[11])(@this, id, idCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetId(this ComPtr<ID2D1SvgPaint> thisVtbl, ref char id, uint idCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* idPtr = &id)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)@this->LpVtbl[11])(@this, idPtr, idCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetId(this ComPtr<ID2D1SvgPaint> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, uint idCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, byte*, uint, int>)@this->LpVtbl[11])(@this, idPtr, idCount);
        SilkMarshal.Free((nint)idPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetIdLength(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SvgPaint> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SvgPaint> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetElement<TI0>(this ComPtr<ID2D1SvgPaint> thisVtbl, ref ComPtr<TI0> element) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetElement((ID2D1SvgElement**) element.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<ID2D1SvgPaint> thisVtbl, ref ComPtr<TI0> attribute) where TI0 : unmanaged, IComVtbl<ID2D1SvgAttribute>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((ID2D1SvgAttribute**) attribute.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.DXGI.D3Dcolorvalue> color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetColor(in color.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, Span<Silk.NET.DXGI.D3Dcolorvalue> color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetColor(ref color.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetId(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> id)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetId(in id.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetId(this ComPtr<ID2D1SvgPaint> thisVtbl, Span<char> id, uint idCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetId(ref id.GetPinnableReference(), idCount);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SvgPaint> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
